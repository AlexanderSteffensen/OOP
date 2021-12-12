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

        private bool CheckArgs(string[] args, int number)
        {
            try
            {
                var check = args[number];
            }
            catch (Exception e)
            {
                _stregSystemUi.DisplayGeneralError("Too few arguments..");
                return false;
            }

            return true;
        }

        public void ActivateProduct(string[] args)
        {
            if (CheckArgs(args, 1))
                _stregSystem.GetProductByID(Convert.ToInt32(args[1])).Activate();
        }

        public void DeactivateProduct(string[] args)
        {
            if (CheckArgs(args, 1))
                _stregSystem.GetProductByID(Convert.ToInt32(args[1])).Deactivate();
        }

        public void CreditOnProduct(string[] args)
        {
            if (CheckArgs(args, 1))
                _stregSystem.GetProductByID(Convert.ToInt32(args[1])).CreditOn();
        }

        public void CreditOffProduct(string[] args)
        {
            if (CheckArgs(args, 1))
                _stregSystem.GetProductByID(Convert.ToInt32(args[1])).CreditOff();
        }

        public void AddCredits(string[] args)
        {
            if (CheckArgs(args, 2))
                _stregSystem.AddCreditsToAccount(_stregSystem.GetUserByUsername(args[1]), Convert.ToInt32(args[2]));
        }
    }
}