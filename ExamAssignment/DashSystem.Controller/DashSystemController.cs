using System;
using System.Collections.Generic;
using ExamAssignment.Core;
using ExamAssignment.Core.UI;

namespace DashSystemController
{
    public class DashSystemController
    {
        private IDashSystem _dashSystem;
        private IDashSystemUI _dashSystemUi;
        private Dictionary<string, Action<string[]>> _adminCommands;
        public DashSystemCommandParser CommandParser;

        public DashSystemController(IDashSystemUI ui, IDashSystem dashSystem)
        {
            _dashSystem = dashSystem;
            _dashSystemUi = ui;

            ui.UserEnteredCommand += CheckCommand;

            AdminCommands ac = new AdminCommands(dashSystem,ui);
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

        private void CheckCommand(string command)
        {
            if (command == "")
            {
                _dashSystemUi.DisplayGeneralError("Please enter a command");
            }
            else if (command.StartsWith(":"))
            {
                ParseAdminCommand(command);
            }
            else
            {
                ParseCommand(command);
            }
        }

        private void ParseAdminCommand(string command)
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

        private void ParseCommand(string command)
        {
            
        }
        
        
        
    }
}