using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExamAssignment.Factory;
using Microsoft.VisualBasic.FileIO;

namespace ExamAssignment
{
    public class DashSystem : IDashSystem
    {
        private ProductFactory _productFactory;
        private UserFactory _userFactory;
        private List<User> _users;
        private List<Product> _products;
        private List<Product> _activeProducts;
        private List<Transaction> _transactions;
        private IEnumerable<Product> _activeProducts1;
        private int _transactionId;

        public DashSystem()
        {
            _productFactory = new ProductFactory();
            _userFactory = new UserFactory();
            _products = _productFactory.Items;
            _users = _userFactory.Items;
            _transactionId = 1;

        }

        // TODO: write funcions for DashSystem class

        public void ExecuteTransaction(Transaction transaction)
        {
            transaction.Execute();   
        }

        IEnumerable<Product> IDashSystem.ActiveProducts => _activeProducts1;

        public InsertCashTransaction AddCreditsToAccount(User user, int amount)
        {
            InsertCashTransaction transaction = new InsertCashTransaction(_transactionId, user, DateTime.Now, amount);
            _transactionId++;
            return transaction;
        }

        public BuyTransaction BuyProduct(User user, Product product)
        {
            BuyTransaction transaction = new BuyTransaction(_transactionId, user, DateTime.Now, product);
            _transactionId++;
            return transaction;
        }

        public Product GetProductByID(int id)
        {
            return _products.Find(product => product.ID == id);
        }

        IEnumerable<Transaction> IDashSystem.GetTransactions(User user, int count)
        {
            return GetTransactions(user, count);
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
            foreach (User user in _users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }

            throw new Exception("No user with found with that username");
        }

        //public event UserBalanceNotification UserBalanceWarning;

        public List<Transaction> GetTransactions(User user, int count)
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

        public List<Product> ActiveProducts()
        {
            return _activeProducts;
        }
        


    }
}