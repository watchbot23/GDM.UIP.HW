using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task3
{
    class ConsoleCommands
    {
        private int _mainMenu;

        public int MainMenu
        {
            set
            {
                if (value < 0 && value > 4)
                {
                    Console.WriteLine("Invalid command");
                }
                else
                {
                    _mainMenu = value;
                }
            }
            get { return _mainMenu; }
        }

        public void ConsoleCommand (int commandValue)
        {
            string response = "";
            response = Console.ReadLine();
            while (response != "")
            {
                switch (response)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":


                    case "4":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
            if (response == "0")
            {

            }
        }
    }
}
