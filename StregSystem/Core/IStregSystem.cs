using System;
using System.Collections.Generic;
using Core.Transactions;

namespace Core
{
    public delegate void UserBalanceNotification(User user);
    public interface IStregSystem
    {
        IEnumerable<Product> ActiveProducts { get; } 
        InsertCashTransaction AddCreditsToAccount(User user, int amount); 
        BuyTransaction BuyProduct(User user, Product product, int amount); 
        Product GetProductByID(int id); 
        IEnumerable<Transaction> GetTransactions(User user, int count); 
        List<User> GetUsers(Func<User, bool> predicate); 
        User GetUserByUsername(string username);

        public void AddTransaction(Transaction transaction);
        event UserBalanceNotification UserBalanceWarning;
    }
}