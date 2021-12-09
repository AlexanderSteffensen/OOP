using System.Collections.Generic;
using Core;
using Core.Transactions;

namespace UserInterface
{
    public delegate void CommandEntered(string command);
    public interface IStregSystemUI
    {
        event CommandEntered UserEnteredCommand;
        void DisplayUserNotFound(string username);
        void DisplayTransactions(IEnumerable<Transaction> transactions);
        void DisplayUserBalanceWarning(User user);
        void DisplayProductNotFound(); 
        void DisplayUserInfo(User user); 
        void DisplayTooManyArgumentsError(string command); 
        void DisplayAdminCommandNotFoundMessage(string adminCommand); 
        void DisplayUserBuysProduct(BuyTransaction transaction); 
        void DisplayUserBuysProduct(int count, BuyTransaction transaction); 
        void Close(); 
        void DisplayInsufficientCash(User user, Product product); 
        void DisplayGeneralError(string errorString);
        void DisplayGeneralMessage(string message);
        void Start();
    }
}