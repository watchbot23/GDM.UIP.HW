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
            SetShopName(shop);
            SetNumberOfStores(shop);
            MobileStore[] mobStore = new MobileStore[shop.NumberOfStores];
            Phone[][] phone = new Phone[shop.NumberOfStores][];
            MainProgramm(shop, mobStore, phone);

            Console.ReadLine();
        }
        public static void ConsoleOptionsMenu()
        {
            Console.WriteLine("- - - - - NEW COMMAND - - - - -");
            Console.WriteLine("Please write index of command from list below. Commands: " +
                "\n [0] - quit " +
                "\n [1] - add store to shop " +
                "\n [2] - add phone to store " +
                "\n [3] - show all phones in store " +
                "\n [4] - clear console");
        }
        public static void MainProgramm (Shop shop, MobileStore[] mobStore, Phone[][] phone)
        {
            ConsoleOptionsMenu();
            string response = Console.ReadLine();
            switch (response)
            {
                case "0":
                    Environment.Exit(0);
                    break;

                case "1":
                    SetNewStoreAddress(mobStore);
                    SetStoreCapacity(mobStore, phone);
                    MainProgramm(shop, mobStore, phone);
                    break;

                case "2":
                    SetNewPhoneModelNameAndPrice(shop, mobStore, phone);
                    MainProgramm(shop, mobStore, phone);
                    break;

                case "3":
                    GetPhonesInStore(shop, mobStore, phone);
                    MainProgramm(shop, mobStore, phone);
                    break;

                case "4":
                    Console.Clear();
                    MainProgramm(shop, mobStore, phone);
                    break;

                default:
                    Console.WriteLine("-> Invalid command");
                    MainProgramm(shop, mobStore, phone);
                    response = Console.ReadLine();
                    break;
            }
         }
        public static void SetShopName(Shop shop)
        {
            string shopName;
            do
            {
                Console.WriteLine("Please write valid (not empty) name for shop");
                shopName = Console.ReadLine();
            }
            while (shopName.Length < 1);
            shop.ShopName = shopName;
            Console.WriteLine($"-> Great, the name of shop is '{shop.ShopName}'");
        }
        public static void SetNumberOfStores(Shop shop)
        {
            string storesNumber;
            int tempNumberNumeric;
            do
            {
                Console.WriteLine($"Please write valid (number > 0 && number <= 10) number of stores for shop '{shop.ShopName}'.");
                storesNumber = Console.ReadLine();
            }
            while (!Int32.TryParse(storesNumber, out tempNumberNumeric) || tempNumberNumeric < 1 || tempNumberNumeric > 10);
            shop.NumberOfStores = tempNumberNumeric;
            Console.WriteLine($"-> Great, the number of stores in shop '{shop.ShopName}' is '{shop.NumberOfStores}'.");
        }
        public static void GetPhonesInStore(Shop shop, MobileStore[] mobStore, Phone[][] phone)
        {
            Console.WriteLine($"-> Store in ''{shop.ShopName}'' ");
            for (int i = 0; i < mobStore.Length; i++)
            {
                if (IsObjectInArrayNull(mobStore, i))
                {
                    Console.WriteLine($"[{i}] - Store cell is empty");
                }
                else
                {
                    Console.WriteLine($"[{i}] - Store cell is with address '{mobStore[i].Address}' and Capacity '{mobStore[i].Capacity}'");
                    for (int j = 0; j < mobStore[i].Capacity; j++)
                    {
                        if (IsObjectInArraysArrayNull(phone, i, j))
                        {
                            Console.WriteLine($"   [{j}] - Phone cell is empty");
                        }
                        else
                        {
                            Console.WriteLine($"   [{j}] - Phone cell is with model '{phone[i][j].ModelName}' and price '{phone[i][j].Price} UAH'");
                        }
                    }
                }
            }
        }
        public static void SetNewStoreAddress(MobileStore[] mobStore)
        {
            string storeAddress;
            do
            {
                Console.WriteLine("Please write shop address (text with length > 10) of stores");
                storeAddress = Console.ReadLine();
            }
            while (storeAddress.Length <= 10);
            for (int i = 0; i < mobStore.Length; i++)
            {
                if (IsObjectInArrayNull(mobStore, i))
                {
                    mobStore[i] = new MobileStore { Address = storeAddress };
                    break;
                }
            }
        }
        public static void SetStoreCapacity(MobileStore[] mobStore, Phone[][] phone)
        {
            string phonesQuantityInStore;
            int phonesQuantityInStoreNumeric;
            do
            {
                Console.WriteLine("Please write Capacity (number > 0 && number <= 10) of phones which could be in store");
                phonesQuantityInStore = Console.ReadLine();
            }
            while (!Int32.TryParse(phonesQuantityInStore, out phonesQuantityInStoreNumeric) || phonesQuantityInStoreNumeric < 1 || phonesQuantityInStoreNumeric > 10);
            for (int i = 0; i < mobStore.Length; i++)
            {
                    if (!IsObjectInArrayNull(mobStore, i) && mobStore[i].Capacity == 0)
                    {
                        mobStore[i].Capacity = phonesQuantityInStoreNumeric;
                        phone[i] = new Phone[mobStore[i].Capacity];
                        Console.WriteLine($"-> Shop with address '{mobStore[i].Address}' and Capacity '{mobStore[i].Capacity}' successfully created.");
                        break;
                    }
                }
        }
        public static void SetNewPhoneModelNameAndPrice(Shop shop, MobileStore[] mobStore, Phone[][] phone)
        {
            int storeIndex;
            string modelName;
            string phonePrice;
            for (int i = 0; i < mobStore.Length;)
            {
                if (IsObjectInArrayNull(mobStore, i))
                {
                    Console.WriteLine($"-> In '{shop.ShopName}' no real stores are available. Please add any real store before adding a phone.");
                    MainProgramm(shop, mobStore, phone);
                }
                break;
            }
            storeIndex = SelectStoreIndexToPutPhone(shop, mobStore, phone);
            for (int i = storeIndex; i == storeIndex; i++)
            {
                for (int j = 0; j < mobStore[i].Capacity; )
                {
                    if (IsObjectInArraysArrayNull(phone, i, j) && i == storeIndex)
                    {
                        phone[i][j] = new Phone();
                        Console.WriteLine($"Please write phone model name text with length > 10");
                        modelName = Console.ReadLine();
                        while (modelName.Length <= 10)
                        {
                            Console.WriteLine($"Please write phone model name text with length > 10");
                            modelName = Console.ReadLine();
                        }
                        phone[i][j].ModelName = modelName;
                        break;
                    }
                    if (!IsObjectInArraysArrayNull(phone, i, j) && j < mobStore[i].Capacity)
                    {
                        j++;
                    }
                    if (j > mobStore[i].Capacity - 1)
                    {
                        Console.WriteLine($"-> There is no free cells in shop with address '{mobStore[i].Address}' and Capacity '{mobStore[i].Capacity}'." +
                            $"\nPlease select another existing store or create a new one.");
                        MainProgramm(shop, mobStore, phone);
                    }
                }
            }
            for (int i = storeIndex; i == storeIndex; i++)
            {
                for (int j = 0; j < mobStore[i].Capacity; j++)
                {
                    if (!IsObjectInArraysArrayNull(phone, i, j) && i == storeIndex && phone[i][j].Price == 0)
                    {
                        Console.WriteLine($"Please write price (number > 0 && number <= 100000) of phones which could be in store");
                        phonePrice = Console.ReadLine();
                        int phonePriceNumeric;
                        while (!Int32.TryParse(phonePrice, out phonePriceNumeric) || string.IsNullOrWhiteSpace(phonePrice) || phonePriceNumeric < 1 || phonePriceNumeric > 100000)
                        {
                            Console.WriteLine($"-> Invalid price. Please make sure you enter a correct price (number > 0 && number <= 100000).");
                            phonePrice = Console.ReadLine();
                        }
                        phone[i][j].Price = phonePriceNumeric;
                        Console.WriteLine($"-> Phone with model Name '{phone[i][j].ModelName}' and price '{phone[i][j].Price}' successfully " +
                            $"\nadded to store with address '{mobStore[storeIndex].Address}' and Capacity '{mobStore[storeIndex].Capacity}' ");
                        break;
                    }
                }
            }
        }
        public static int SelectStoreIndexToPutPhone (Shop shop, MobileStore[] mobStore, Phone[][] phone)
        {
            Console.WriteLine("Please write index number of Mobile Phone Store below. MobilePhoneStores:");
            int index = mobStore.Length - 1;
            for (int i = 0; i < mobStore.Length; i++)
            {
                if (!IsObjectInArrayNull(mobStore, i))
                {
                    Console.WriteLine($" [{i}] - Store cell is with address '{mobStore[i].Address}' and Capacity '{mobStore[i].Capacity}'");
                }
                else
                {
                    break;
                }
            }
            string storeIndex = Console.ReadLine();
            int storeIndexNumeric;
            while (!Int32.TryParse(storeIndex, out storeIndexNumeric))
            {
                Console.WriteLine($"-> Invalid index. Please make sure you enter a correct index.");
                Console.WriteLine("Please write index number of Mobile Phone Store below. MobilePhoneStores:");
                for (int i = 0; i < mobStore.Length; i++)
                {
                    if (!IsObjectInArrayNull(mobStore, i))
                    {
                        Console.WriteLine($" [{i}] - Store cell is with address '{mobStore[i].Address}' and Capacity '{mobStore[i].Capacity}'");
                    }
                    else
                    {
                        break;
                    }
                }
                storeIndex = Console.ReadLine();
            }
            index = IndexOfEmptyCellInStore(mobStore);
            if (IsObjectInArrayNull(mobStore, storeIndexNumeric) && storeIndexNumeric < mobStore.Length)
            {
                Console.WriteLine($"-> Store with index [{storeIndexNumeric}] in shop {shop.ShopName} does not exist yet");
                SelectStoreIndexToPutPhone(shop, mobStore, phone);
            }
            else if (storeIndexNumeric < 0 || storeIndexNumeric > mobStore.Length - 1)
            {
                Console.WriteLine($"-> Invalid index. Please make sure you enter a correct index.");
                SelectStoreIndexToPutPhone(shop, mobStore, phone);
            }
            else
            {
                index = storeIndexNumeric;
            }
            return index;
        }
        public static int IndexOfEmptyCellInStore (MobileStore[] array)
        {
            int index = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    index = i;
                    break;
                }
            }
            return index;
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
        public static bool IsObjectInArraysArrayNull (Phone[][] array, int indexI, int indexJ)
        {
            bool isObjectInArraysArrayNull = false;
            for (int i = indexI; i == indexI;)
            {
                for (int j = indexJ; j == indexJ;)
                {
                    if (array[i][j] == null)
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
