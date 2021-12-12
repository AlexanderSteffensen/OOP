using System;
using System.Collections.Generic;
using Core;
using Core.Exceptions;
using Core.Transactions;
using UserInterface;

namespace Controller
{
    public class StregSystemCommandParser
    {
        private IStregSystem _stregSystem;
        private IStregSystemUI _stregSystemUi;
        private Dictionary<string, Action<string[]>> _adminCommands;

        public StregSystemCommandParser(IStregSystem stregSystem, IStregSystemUI stregSystemUi)
        {
            _stregSystem = stregSystem;
            _stregSystemUi = stregSystemUi;
            
            AdminCommands ac = new AdminCommands(stregSystem,stregSystemUi);
            _adminCommands = new Dictionary<string, Action<string[]>>()
            {
                {":q", ac.Quit},
                {":quit", ac.Quit},
                {":activate", ac.ActivateProduct},
                {":deactivate", ac.DeactivateProduct},
                {":crediton", ac.CreditOnProduct},
                {":creditoff", ac.CreditOffProduct},
                {":addcredits", ac.AddCredits}
            };
        }
        
        

        public void ParseAdminCommand(string command)
        {
            string[] splittedCommand = command.Split(" ");
            foreach (KeyValuePair<string, Action<string[]>> adminCommand in _adminCommands)
            {
                if (splittedCommand[0] == adminCommand.Key)
                {
                    adminCommand.Value(splittedCommand);
                    return;
                }
            }
            _stregSystemUi.DisplayAdminCommandNotFoundMessage(command);
        }

        public void ParseCommand(string command)
        {
            string[] splittedCommand = command.Split(" ");
            
            User user;

            try
            {
                user = _stregSystem.GetUserByUsername(splittedCommand[0]);
            }
            catch (UserDoesntExistException e)
            {
                _stregSystemUi.DisplayUserNotFound(e.Username);
                return;
            }
            
            switch (splittedCommand.Length)
            {
                case 1: UserInformationCommand(user);
                    break;
                
                case 2 : UserBuyProductCommand(user, 1, Convert.ToInt32(splittedCommand[1]));
                    break;
                
                case 3 : UserBuyProductCommand(user, Convert.ToInt32(splittedCommand[1]), Convert.ToInt32(splittedCommand[2]));
                    break;
                
                default: _stregSystemUi.DisplayTooManyArgumentsError(command);
                    break;
            }
        }

        public void UserInformationCommand(User user)
        {
            IEnumerable<Transaction> transactions = _stregSystem.GetTransactions(user, 10);
            _stregSystemUi.DisplayUserInfo(user);
            _stregSystemUi.DisplayTransactions(transactions);
            if (user.Balance < 50)
            {
                _stregSystemUi.DisplayUserBalanceWarning(user);
            }
        }

        public void UserBuyProductCommand(User user, int amount, int productId)
        {
            Product product;
            try
            {
                product = _stregSystem.GetProductByID(productId);
            }
            catch (ProductDoesntExistException e)
            {
                _stregSystemUi.DisplayProductNotFound(e.Id);
                return;
            }

            BuyTransaction buyTransaction;
            
            try
            {
                buyTransaction = _stregSystem.BuyProduct(user, product, amount);
            }
            catch (ProductNotActiveException e)
            {
                _stregSystemUi.DisplayProductNotActive(e.Product);
                return;
            }
            

            try
            {
                buyTransaction.Execute();
            }
            catch (InsufficientCreditsException e)
            {
                _stregSystemUi.DisplayInsufficientCash(e.User, amount, e.Product);
                return;
            }
            
            _stregSystem.AddTransaction(buyTransaction);
            _stregSystemUi.DisplayUserBuysProduct(amount,buyTransaction);
        }
    }
}