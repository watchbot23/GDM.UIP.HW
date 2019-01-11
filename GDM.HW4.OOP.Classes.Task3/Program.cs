using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.SetShopName();
            shop.SetNumberOfStores();
            shop.MobStoresArray = new MobileStore[shop.NumberOfStores];
            MainProgramm(shop);

            Console.ReadLine();
        }
        public static void PrintOptionsMenu()
        {
            string[] optionsArray = new string[] { "quit", "add store to shop", "add phone to store", "show all phones in store", "clear console" };
            Console.WriteLine("- - - - - NEW COMMAND - - - - -");
            for (int i = 0; i < optionsArray.Length; i++)
            {
                Console.WriteLine($" [{i}] - {optionsArray[i]}");
            }
        }
        public static void MainProgramm (Shop shop)
        {
            string response;
            PrintOptionsMenu();
            response = Console.ReadLine();
            while (response != "0")
            {
                switch (response)
                {
                    case "1":
                        shop.MobStores.SetNewStoreAddress(shop);
                        shop.MobStores.SetStoreCapacity(shop);
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    case "2":
                        SetNewPhoneModelNameAndPrice(shop);
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    case "3":
                        shop.GetPhonesInStore(shop);
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    case "4":
                        Console.Clear();
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("-> Invalid command");
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;
                }
            }
            Environment.Exit(0);
        }
        public static void SetNewPhoneModelNameAndPrice(Shop shop)
        {
            int storeIndex;
            string modelName;
            string phonePrice;
            for (int i = 0; i < shop.MobStoresArray.Length;)
            {
                if (shop.IsObjectInArrayNull(shop.MobStoresArray, i))
                {
                    Console.WriteLine($"-> In '{shop.ShopName}' no real stores are available. Please add any real store before adding a phone.");
                    MainProgramm(shop);
                }
                break;
            }
            shop.MobStores.Phones.AvailableStoresToPutPhone(shop);
            storeIndex = shop.MobStores.Phones.Index(shop);
            for (int i = storeIndex; i == storeIndex; i++)
            {
                for (int j = 0; j < shop.MobStoresArray[i].Capacity;)
                {
                    if (shop.IsObjectInArraysArrayNull(shop.MobStoresArray[i].PhonesArraysArray, i, j) && i == storeIndex)
                    {
                        shop.MobStoresArray[i].PhonesArraysArray[j] = new Phone();
                        Console.WriteLine($"Please write phone model name text with length > 10");
                        modelName = Console.ReadLine();
                        while (modelName.Length <= 10)
                        {
                            Console.WriteLine($"Please write phone model name text with length > 10");
                            modelName = Console.ReadLine();
                        }
                        shop.MobStoresArray[i].PhonesArraysArray[j].ModelName = modelName;
                        break;
                    }
                    if (!shop.IsObjectInArraysArrayNull(shop.MobStoresArray[i].PhonesArraysArray, i, j) && j < shop.MobStoresArray[i].Capacity)
                    {
                        j++;
                    }
                    if (j > shop.MobStoresArray[i].Capacity - 1)
                    {
                        Console.WriteLine($"-> There is no free cells in shop with address '{shop.MobStoresArray[i].Address}' and Capacity '{shop.MobStoresArray[i].Capacity}'." +
                            $"\nPlease select another existing store or create a new one.");
                        MainProgramm(shop);
                    }
                }
            }
            for (int i = storeIndex; i == storeIndex; i++)
            {
                for (int j = 0; j < shop.MobStoresArray[i].Capacity; j++)
                {
                    if (!shop.IsObjectInArraysArrayNull(shop.MobStoresArray[i].PhonesArraysArray, i, j) && i == storeIndex && shop.MobStoresArray[i].PhonesArraysArray[j].Price == 0)
                    {
                        Console.WriteLine($"Please write price (number > 0 && number <= 100000) of phones which could be in store");
                        phonePrice = Console.ReadLine();
                        int phonePriceNumeric;
                        while (!Int32.TryParse(phonePrice, out phonePriceNumeric) || string.IsNullOrWhiteSpace(phonePrice) || phonePriceNumeric < 1 || phonePriceNumeric > 100000)
                        {
                            Console.WriteLine($"-> Invalid price. Please make sure you enter a correct price (number > 0 && number <= 100000).");
                            phonePrice = Console.ReadLine();
                        }
                        shop.MobStoresArray[i].PhonesArraysArray[j].Price = phonePriceNumeric;
                        Console.WriteLine($"-> Phone with model Name '{shop.MobStoresArray[i].PhonesArraysArray[j].ModelName}' and price '{shop.MobStoresArray[i].PhonesArraysArray[j].Price}' successfully " +
                            $"\nadded to store with address '{shop.MobStoresArray[storeIndex].Address}' and Capacity '{shop.MobStoresArray[storeIndex].Capacity}' ");
                        break;
                    }
                }
            }
        }
    }
}
