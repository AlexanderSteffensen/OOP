using DashSystem.Core.Transactions;
using DashSystem.Core;

namespace DashSystem.UI
{
    public delegate void CommandEntered(string command);
    public interface IDashSystemUI
    {
        event CommandEntered UserEnteredCommand;
        void DisplayUserNotFound(string username); 
        void DisplayProductNotFound(string product); 
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
       // event StregsystemEvent CommandEntered;
    }
}