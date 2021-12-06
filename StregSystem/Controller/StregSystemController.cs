using System;
using System.Collections.Generic;
using Core;
using UserInterface;

namespace Controller
{
    public class StregSystemController
    {
        private IStregSystem _stregSystem;
        private IStregSystemUI _stregSystemUi;
        public StregSystemCommandParser CommandParser;

        public StregSystemController(IStregSystemUI ui, IStregSystem stregSystem)
        {
            _stregSystem = stregSystem;
            _stregSystemUi = ui;

            CommandParser = new StregSystemCommandParser(stregSystem, ui);

            ui.UserEnteredCommand += CheckCommand;

            
        }

        private void CheckCommand(string command)
        {
            if (command == "")
            {
                _stregSystemUi.DisplayGeneralError("Please enter a command");
            }
            else if (command.StartsWith(":"))
            {
                CommandParser.ParseAdminCommand(command);
            }
            else
            {
                CommandParser.ParseCommand(command);
            }
        }



    }
}