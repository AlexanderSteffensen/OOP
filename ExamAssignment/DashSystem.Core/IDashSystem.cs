using System;
using System.Collections.Generic;

namespace ExamAssignment
{
    public interface IDashSystem
    {
        IEnumerable<Product> ActiveProducts { get; } 
        InsertCashTransaction AddCreditsToAccount(User user, int amount); 
        BuyTransaction BuyProduct(User user, Product product); 
        Product GetProductByID(int id); 
        IEnumerable<Transaction> GetTransactions(User user, int count); 
        List<User> GetUsers(Func<User, bool> predicate); 
        User GetUserByUsername(string username); 
        //event UserBalanceNotification UserBalanceWarning;
    }
}