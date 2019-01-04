using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task3
{
    class Program
    {
        private static Shop _shop;
        static void Main(string[] args)
        {
            Console.WriteLine("Please write valid (not empty) name for shop");
            string shopName = Console.ReadLine();

            SetShopName(shopName);
            ConsoleOptionMenu();
            
            Console.ReadLine();
        }
        static void ConsoleOptionMenu ()
        {
            Console.WriteLine("- - - - - NEW COMMAND - - - - -");
            Console.WriteLine("Please write index of command from list below. Commands: " +
                "\n [0] - quit " +
                "\n [1] - add store to shop " +
                "\n [2] - add phone to store " +
                "\n [3] - show all phones in store " +
                "\n [4] - clear console");

            string response = "";
            response = Console.ReadLine();
            if (response == "")
            {
                Console.WriteLine("Invalid command");
                ConsoleOptionMenu();
            }
            while (response != "")
            {
                switch (response)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":


                    case "3":
                        StoreDataBase();
                        ConsoleOptionMenu();
                        break;

                    case "4":
                        Console.Clear();
                        ConsoleOptionMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        ConsoleOptionMenu();
                        break;
                }
            }
         }
        static string SetShopName(string name)
        {
            _shop = new Shop();
            string tempname = name;

            if (name.Length < 1)
            {
                Console.WriteLine("Please write valid (not empty) name for shop");
                tempname = Console.ReadLine();
                SetShopName(tempname);
            }
            else
            {
                _shop.ShopName = name;
                Console.WriteLine($"-> Great, the name of shop is '{_shop.ShopName}'");
            }
            return _shop.ShopName;
        }
        static void StoreDataBase()
        {
            string storeStatus = "";
            Console.WriteLine($"-> Store in ''{_shop.ShopName}'' " +
                $"\n [0] - {storeStatus}" +
                $"\n [1] - {storeStatus}" +
                $"\n [2] - {storeStatus}" +
                $"\n [3] - {storeStatus}" +
                $"\n [4] - {storeStatus}");
        }
    }
}
