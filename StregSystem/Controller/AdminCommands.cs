using System;
using Core;
using UserInterface;

namespace Controller
{
    public class AdminCommands
    {
        private IStregSystem _stregSystem;
        private IStregSystemUI _stregSystemUi;


        public AdminCommands(IStregSystem stregSystem, IStregSystemUI stregSystemUi)
        {
            _stregSystem = stregSystem;
            _stregSystemUi = stregSystemUi;
        }

        public void Quit(string[] args)
        {
            _stregSystemUi.Close();
            _stregSystemUi.DisplayGeneralMessage("Closing, bye");
        }

        public void ActivateProduct(string[] args)
        {
            _stregSystem.GetProductByID(Convert.ToInt32(args[1])).Activate();
        }

        public void DeactivateProduct(string[] args)
        {
            _stregSystem.GetProductByID(Convert.ToInt32(args[1])).Deactivate();
        }

        public void CreditOnProduct(string[] args)
        {
            _stregSystem.GetProductByID(Convert.ToInt32(args[1])).CreditOn();
        }

        public void CreditOffProduct(string[] args)
        {
            _stregSystem.GetProductByID(Convert.ToInt32(args[1])).CreditOff();
        }

        public void AddCredits(string[] args)
        {
            _stregSystem.AddCreditsToAccount(_stregSystem.GetUserByUsername(args[1]), Convert.ToInt32(args[2]));
        }
    }
}