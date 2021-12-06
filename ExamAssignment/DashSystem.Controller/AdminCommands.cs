using System;
using ExamAssignment.Core;
using ExamAssignment.Core.UI;

namespace DashSystemController
{
    public class AdminCommands
    {
        private IDashSystem _dashSystem;
        private IDashSystemUI _dashSystemUi;


        public AdminCommands(IDashSystem dashSystem, IDashSystemUI dashSystemUi)
        {
            _dashSystem = dashSystem;
            _dashSystemUi = dashSystemUi;
        }

        public void Quit(string[] args)
        {
            _dashSystemUi.Close();
            _dashSystemUi.DisplayGeneralMessage("Closing, bye");
        }

        public void ActivateProduct(string[] args)
        {
            _dashSystem.GetProductByID(Convert.ToInt32(args[1])).Activate();
        }

        public void DeactivateProduct(string[] args)
        {
            _dashSystem.GetProductByID(Convert.ToInt32(args[1])).Deactivate();
        }

        public void CreditOnProduct(string[] args)
        {
            _dashSystem.GetProductByID(Convert.ToInt32(args[1])).CreditOn();
        }

        public void CreditOffProduct(string[] args)
        {
            _dashSystem.GetProductByID(Convert.ToInt32(args[1])).CreditOff();
        }

        public void AddCredits(string[] args)
        {
            _dashSystem.AddCreditsToAccount(_dashSystem.GetUserByUsername(args[1]), Convert.ToInt32(args[2]));
        }
    }
}