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
                        SetNewStoreAddress(shop);
                        SetStoreCapacity(shop);
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    case "2":
                        SetNewPhoneModelNameAndPrice(shop);
                        PrintOptionsMenu();
                        response = Console.ReadLine();
                        break;

                    case "3":
                        GetPhonesInStore(shop);
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
        public static void GetPhonesInStore(Shop shop)
        {
            Console.WriteLine($"-> Store in ''{shop.ShopName}'' ");
            for (int i = 0; i < shop.MobStoresArray.Length; i++)
            {
                if (IsObjectInArrayNull(shop.MobStoresArray, i))
                {
                    Console.WriteLine($"[{i}] - Store cell is empty");
                }
                else
                {
                    Console.WriteLine($"[{i}] - Store cell is with address '{shop.MobStoresArray[i].Address}' and Capacity '{shop.MobStoresArray[i].Capacity}'");
                    for (int j = 0; j < shop.MobStoresArray[i].Capacity; j++)
                    {
                        if (IsObjectInArraysArrayNull(shop.MobStoresArray[i].PhonesArraysArray, i, j))
                        {
                            Console.WriteLine($"   [{j}] - Phone cell is empty");
                        }
                        else
                        {
                            Console.WriteLine($"   [{j}] - Phone cell is with model '{shop.MobStoresArray[i].PhonesArraysArray[j].ModelName}' and price '{shop.MobStoresArray[i].PhonesArraysArray[j].Price} UAH'");
                        }
                    }
                }
            }
        }
        public static void SetNewStoreAddress(Shop shop)
        {
            string storeAddress;
            do
            {
                Console.WriteLine("Please write shop address (text with length > 10) of stores");
                storeAddress = Console.ReadLine();
            }
            while (storeAddress.Length <= 10);
            for (int i = 0; i < shop.MobStoresArray.Length; i++)
            {
                if (IsObjectInArrayNull(shop.MobStoresArray, i))
                {
                    shop.MobStoresArray[i] = new MobileStore { Address = storeAddress };
                    break;
                }
            }
        }
        public static void SetStoreCapacity(Shop shop)
        {
            string phonesQuantityInStore;
            int phonesQuantityInStoreNumeric;
            do
            {
                Console.WriteLine("Please write Capacity (number > 0 && number <= 10) of phones which could be in store");
                phonesQuantityInStore = Console.ReadLine();
            }
            while (!Int32.TryParse(phonesQuantityInStore, out phonesQuantityInStoreNumeric) || phonesQuantityInStoreNumeric < 1 || phonesQuantityInStoreNumeric > 10);
            for (int i = 0; i < shop.MobStoresArray.Length; i++)
            {
                    if (!IsObjectInArrayNull(shop.MobStoresArray, i) && shop.MobStoresArray[i].Capacity == 0)
                    {
                        shop.MobStoresArray[i].Capacity = phonesQuantityInStoreNumeric;
                        shop.MobStoresArray[i].PhonesArraysArray = new Phone[shop.MobStoresArray[i].Capacity];
                        Console.WriteLine($"-> Shop with address '{shop.MobStoresArray[i].Address}' and Capacity '{shop.MobStoresArray[i].Capacity}' successfully created.");
                        break;
                    }
                }
        }
        public static void SetNewPhoneModelNameAndPrice(Shop shop)
        {
            int storeIndex;
            string modelName;
            string phonePrice;
            for (int i = 0; i < shop.MobStoresArray.Length;)
            {
                if (IsObjectInArrayNull(shop.MobStoresArray, i))
                {
                    Console.WriteLine($"-> In '{shop.ShopName}' no real stores are available. Please add any real store before adding a phone.");
                    MainProgramm(shop);
                }
                break;
            }
            AvailableStoresToPutPhone(shop);
            storeIndex = Index(shop);
            for (int i = storeIndex; i == storeIndex; i++)
            {
                for (int j = 0; j < shop.MobStoresArray[i].Capacity; )
                {
                    if (IsObjectInArraysArrayNull(shop.MobStoresArray[i].PhonesArraysArray, i, j) && i == storeIndex)
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
                    if (!IsObjectInArraysArrayNull(shop.MobStoresArray[i].PhonesArraysArray, i, j) && j < shop.MobStoresArray[i].Capacity)
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
                    if (!IsObjectInArraysArrayNull(shop.MobStoresArray[i].PhonesArraysArray, i, j) && i == storeIndex && shop.MobStoresArray[i].PhonesArraysArray[j].Price == 0)
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
        public static void AvailableStoresToPutPhone(Shop shop)
        {
            Console.WriteLine("Please write index number of Mobile Phone Store below. MobilePhoneStores:");
            for (int i = 0; i < shop.MobStoresArray.Length; i++)
            {
                if (!IsObjectInArrayNull(shop.MobStoresArray, i))
                {
                    Console.WriteLine($" [{i}] - Store cell is with address '{shop.MobStoresArray[i].Address}' and Capacity '{shop.MobStoresArray[i].Capacity}'");
                }
                else
                {
                    break;
                }
            }
        }
        public static int Index(Shop shop) { 
            string storeIndex = Console.ReadLine();
            int index = shop.MobStoresArray.Length - 1;
            int storeIndexNumeric;
            while (!Int32.TryParse(storeIndex, out storeIndexNumeric) || storeIndexNumeric < 0 || storeIndexNumeric > shop.MobStoresArray.Length - 1 || 
                IsObjectInArrayNull(shop.MobStoresArray, storeIndexNumeric) && storeIndexNumeric < shop.MobStoresArray.Length)
            {
                Console.WriteLine($"-> Invalid index. Please make sure you enter a correct index.");
                AvailableStoresToPutPhone(shop);
                storeIndex = Console.ReadLine();
            }
            index = storeIndexNumeric;
            return index;
        }
        public static int IndexOfEmptyCellInStore (MobileStore[] array)
        {
            int index = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    index = i;
                    break;
                }
            }
            return index - 1;
        }
        public static bool IsObjectInArrayNull (MobileStore[] array, int index)
        {
            bool isObjectInArrayNull = false;
            for (int i = index; i == index && i < array.Length;)
            {
                if (array[i] == null)
                {
                    isObjectInArrayNull = true;
                }
                break;
            }
            return isObjectInArrayNull;
        }
        public static bool IsObjectInArraysArrayNull (Phone[] array, int indexI, int indexJ)
        {
            bool isObjectInArraysArrayNull = false;
            for (int i = indexI; i == indexI;)
            {
                for (int j = indexJ; j == indexJ;)
                {
                    if (array[j] == null)
                    {
                        isObjectInArraysArrayNull = true;
                    }
                    break;
                }
                break;
            }
            return isObjectInArraysArrayNull;
        }
    }
}
