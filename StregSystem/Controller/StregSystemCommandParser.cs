using System;
using System.Collections.Generic;
using Core;
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
                    break;
                }
            }
        }

        public void ParseCommand(string command)
        {
            string[] splittedCommand = command.Split(" ");
            
            User user;
            
            try
            {
                user = _stregSystem.GetUserByUsername(splittedCommand[0]);
            }
            catch (Exception e)
            {
                _stregSystemUi.DisplayUserNotFound(splittedCommand[0]);
                return;
            }

            switch (splittedCommand.Length)
            {
                case 1: UserInformationCommand(user);
                    break;
                
                case 2 : UserBuyProductCommand(user, Convert.ToInt32(splittedCommand[1]));
                    break;
                
                case 3 : UserMultiBuyProductCommand(user, Convert.ToInt32(splittedCommand[1]), Convert.ToInt32(splittedCommand[2]));
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
                _stregSystemUi.DisplayUserBalanceWarning();
            }
        }

        public void UserBuyProductCommand(User user, int productId)
        {
            Product product;
            try
            {
                product = _stregSystem.GetProductByID(productId);
            }
            catch (Exception e)
            {
                _stregSystemUi.DisplayProductNotFound();
                return;
            }
            
            BuyTransaction buyTransaction = _stregSystem.BuyProduct(user, product, 1);
            
            _stregSystem.ExecuteTransaction(buyTransaction);
            
            _stregSystemUi.DisplayUserBuysProduct(buyTransaction);
        }

        public void UserMultiBuyProductCommand(User user, int amount, int productId)
        {
            Product product;
            try
            {
                product = _stregSystem.GetProductByID(productId);
            }
            catch (Exception e)
            {
                _stregSystemUi.DisplayProductNotFound();
                return;
            }

            
            
            BuyTransaction buyTransaction = _stregSystem.BuyProduct(user, product, amount);
            
            _stregSystem.ExecuteTransaction(buyTransaction);
            
            _stregSystemUi.DisplayUserBuysProduct(amount,buyTransaction);
            
            
        }
    }
}