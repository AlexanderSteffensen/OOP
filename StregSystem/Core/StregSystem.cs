using System;
using System.Collections.Generic;
using Core.Exceptions;
using Core.Transactions;

namespace Core
{
    public class StregSystem : IStregSystem
    {
        private IDataReader _dataReader;
        private List<User> _users;
        private List<Product> _products;
        private List<Transaction> _transactions = new List<Transaction>();
        private int _transactionId;

        public StregSystem()
        {
            _dataReader = new DataReader();
            _products = _dataReader.GetProducts();
            _users = _dataReader.GetUsers();
            _transactionId = 1;
            _transactions = new List<Transaction>();
            foreach (User user in _users)
            {
                user.UserBalanceChanged += CheckUserBalance;
            }
        }

        public void CheckUserBalance(User user)
        {
            if (user.Balance < 50)
            {
                UserBalanceWarning?.Invoke(user);
            }
        }
        
        public void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public event UserBalanceNotification UserBalanceWarning;

        IEnumerable<Product> IStregSystem.ActiveProducts => _products.FindAll(product => product.Active);

        public InsertCashTransaction AddCreditsToAccount(User user, int amount)
        {
            InsertCashTransaction transaction = new InsertCashTransaction(_transactionId, user, DateTime.Now, amount);
            _transactionId++;
            return transaction;
        }

        public BuyTransaction BuyProduct(User user, Product product, int amount)
        {
            BuyTransaction transaction = new BuyTransaction(_transactionId, user, DateTime.Now, product, amount);
            _transactionId++;
            return transaction;
        }

        public Product GetProductByID(int id)
        {
            return _products.Find(product => product.ID == id) ?? throw new ProductDoesntExistException(id);
        }

        public List<User> GetUsers(Func<User, bool> predicate)
        {
            List<User> users = new List<User>();
            foreach (User user in _users)
            {
                if (predicate(user))
                {
                    users.Add(user);
                }
            }
            return users;
        }

        public User GetUserByUsername(string username)
        {
            return _users.Find(user => user.Username == username) ?? throw new UserDoesntExistException(username);
        }
        
        public IEnumerable<Transaction> GetTransactions(User user, int count)
        {
            List<Transaction> allTransactions = _transactions;
            List<Transaction> transactions = new List<Transaction>();
            allTransactions.Reverse();

            foreach (Transaction transaction in allTransactions)
            {
                if (transaction.User.Username == user.Username)
                {
                    transactions.Add(transaction);
                    if (transactions.Count == count)
                    {
                        return transactions;
                    }
                }
            }
            return transactions;
        }

    }
}