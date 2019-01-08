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
        private static MobileStore[] _mobStore;
        private static Phone[][] _phone;
        static void Main(string[] args)
        {
            SetShopName();
            SetNumberOfStores();
            _mobStore = new MobileStore[_shop.NumberOfStores];
            _phone = new Phone[_shop.NumberOfStores][];
            ConsoleOptionMenu();

            Console.ReadLine();
        }
        public static void ConsoleOptionMenu ()
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
                        SetNewStoreAddress();
                        SetStoreCapasity();
                        ConsoleOptionMenu();
                        break;

                    case "2":
                        SetNewPhoneModelNameAndPrice();
                        ConsoleOptionMenu();
                        break;

                    case "3":
                        GetPhonesInStore();
                        ConsoleOptionMenu();
                        break;

                    case "4":
                        Console.Clear();
                        ConsoleOptionMenu();
                        break;

                    default:
                        Console.WriteLine("-> Invalid command");
                        ConsoleOptionMenu();
                        break;
                }
            }
         }
        public static void SetShopName()
        {
            Console.WriteLine("Please write valid (not empty) name for shop");
            string shopName = Console.ReadLine();
            _shop = new Shop();

            if (shopName.Length < 1)
            {
                SetShopName();
            }
            else
            {
                _shop.ShopName = shopName;
                Console.WriteLine($"-> Great, the name of shop is '{_shop.ShopName}'");
            }
        }
        public static void SetNumberOfStores()
        {
            Console.WriteLine($"Please write valid (number > 0 && number <= 10) number of stores for shop '{_shop.ShopName}'.");
            string storesNumber = Console.ReadLine();
            int tempNumberNumeric;
            if (IsDigitsOnly(storesNumber) || storesNumber == "")
            {
                SetNumberOfStores();
            }
            else
            {
                tempNumberNumeric = Int32.Parse(storesNumber);
                if (tempNumberNumeric < 1 || tempNumberNumeric > 10)
                {
                    SetNumberOfStores();
                }
                else
                {
                    _shop.NumberOfStores = tempNumberNumeric;
                    Console.WriteLine($"-> Great, the number of stores in shop '{_shop.ShopName}' is '{_shop.NumberOfStores}'.");
                }
            }
        }
        public static void GetPhonesInStore()
        {
            Console.WriteLine($"-> Store in ''{_shop.ShopName}'' ");
            for (int i = 0; i < _mobStore.Length; i++)
            {
                string storeCellStatus = "";
                if (IsObjectInArrayNull(_mobStore, i))
                {
                    storeCellStatus = "Store cell is empty";
                    Console.WriteLine($"[{i}] - {storeCellStatus}");
                }
                else
                {
                    Console.WriteLine($"[{i}] - Store cell is with address '{_mobStore[i].Address}' and capasity '{_mobStore[i].Capasity}'");
                    for (int j = 0; j < _mobStore[i].Capasity; j++)
                    {
                        string phoneCellStatus = "";
                        if (IsObjectInArraysArrayNull(_phone, i, j))
                        {
                            phoneCellStatus = "Phone cell is empty";
                            Console.WriteLine($"   [{j}] - {phoneCellStatus}");
                        }
                        else
                        {
                            Console.WriteLine($"   [{j}] - Phone cell is with model '{_phone[i][j].ModelName}' and price '{_phone[i][j].Price} UAH'");
                        }
                    }
                }
            }
        }
        public static void SetNewStoreAddress()
        {
            Console.WriteLine("Please write shop address (text with length > 10) of stores");
            string storeAddress = Console.ReadLine();
            if (storeAddress.Length <= 10)
            {
                SetNewStoreAddress();
            }
            else
            {
                for (int i = 0; i < _mobStore.Length; i++)
                {
                    if (_mobStore[i] == null)
                    {
                        _mobStore[i] = new MobileStore {
                            Address = storeAddress };
                        break;
                    }
                }
            }
        }
        public static bool IsDigitsOnly(string consoleString)
        {
            bool tempBool = true;
            foreach (char c in consoleString)
            {
                if (c < '0' || c > '9' || consoleString.Length > 8)
                {
                    tempBool = false;
                }
            }
            return tempBool;
        }
        public static void SetStoreCapasity()
        {
            Console.WriteLine("Please write capasity (number > 0 && number <= 10) of phones which could be in store");
            string phonesQuantityInStore = Console.ReadLine();
            if (IsDigitsOnly(phonesQuantityInStore))
            {
                SetStoreCapasity();
            }
            else
            {
                int phonesQuantityInStoreNumeric = Int32.Parse(phonesQuantityInStore);
                if (phonesQuantityInStoreNumeric < 1 || phonesQuantityInStoreNumeric > 10)
                {
                    SetStoreCapasity();
                }
                else
                {
                    for (int i = 0; i < _mobStore.Length; i++)
                    {
                        if (_mobStore[i] != null && _mobStore[i].Capasity == 0)
                        {
                            _mobStore[i].Capasity = phonesQuantityInStoreNumeric;
                            _phone[i] = new Phone[_mobStore[i].Capasity];
                            Console.WriteLine($"-> Shop with address '{_mobStore[i].Address}' and capasity '{_mobStore[i].Capasity}' successfully created.");
                            break;
                        }
                    }
                }
            }
        }
        public static void SetNewPhoneModelNameAndPrice()
        {
            int storeIndex;
            string modelName;
            string phonePrice;
            for (int i = 0; i < _mobStore.Length;)
            {
                if (IsObjectInArrayNull(_mobStore, i))
                {
                    Console.WriteLine($"-> In '{_shop.ShopName}' no real stores are available. Please add any real store before adding a phone.");
                    ConsoleOptionMenu();
                }
                break;
            }
            storeIndex = SelectStoreIndexToPutPhone();
            for (int i = storeIndex; i == storeIndex; i++)
            {
                for (int j = 0; j < _mobStore[i].Capasity; )
                {
                    if (IsObjectInArraysArrayNull(_phone, i, j) && i == storeIndex)
                    {
                        _phone[i][j] = new Phone();
                        Console.WriteLine($"Please write phone model name text with length > 10");
                        modelName = Console.ReadLine();
                        while (modelName.Length <= 10)
                        {
                            Console.WriteLine($"Please write phone model name text with length > 10");
                            modelName = Console.ReadLine();
                        }
                        _phone[i][j].ModelName = modelName;
                        break;
                    }
                    if (IsObjectInArraysArrayNull(_phone, i, j) && j < _mobStore[i].Capasity)
                    {
                        j++;
                    }
                    if (j > _mobStore[i].Capasity - 1)
                    {
                        Console.WriteLine($"-> There is no free cells in shop with address '{_mobStore[i].Address}' and capasity '{_mobStore[i].Capasity}'." +
                            $"\nPlease select another existing store or create a new one.");
                        ConsoleOptionMenu();
                    }
                }
            }
            for (int i = storeIndex; i == storeIndex; i++)
            {
                for (int j = 0; j < _mobStore[i].Capasity; j++)
                {
                    if (IsObjectInArraysArrayNull(_phone, i, j) && i == storeIndex && _phone[i][j].Price == 0)
                    {
                        Console.WriteLine($"Please write price (number > 0 && number <= 100000) of phones which could be in store");
                        phonePrice = Console.ReadLine();
                        while (IsDigitsOnly(phonePrice))
                        {
                            Console.WriteLine($"-> Invalid price. Please make sure you enter a correct price (number > 0 && number <= 100000).");
                            phonePrice = Console.ReadLine();
                        }
                        int phonePriceNumeric = Int32.Parse(phonePrice);
                        while (IsDigitsOnly(phonePrice) || phonePriceNumeric < 1 || phonePriceNumeric > 100000)
                        {
                            Console.WriteLine($"-> Invalid price. Please make sure you enter a correct price (number > 0 && number <= 100000).");
                            phonePrice = Console.ReadLine();
                        }
                        _phone[i][j].Price = phonePriceNumeric;
                        Console.WriteLine($"-> Phone with model Name '{_phone[i][j].ModelName}' and price '{_phone[i][j].Price}' successfully " +
                            $"\nadded to store with address '{_mobStore[storeIndex].Address}' and capasity '{_mobStore[storeIndex].Capasity}' ");
                        break;
                    }
                }
            }
        }
        public static int SelectStoreIndexToPutPhone ()
        {
            Console.WriteLine("Please write index number of Mobile Phone Store below. MobilePhoneStores:");
            int index = _mobStore.Length - 1;
            for (int i = 0; i < _mobStore.Length; i++)
            {
                if (_mobStore[i] != null)
                {
                    Console.WriteLine($" [{i}] - Store cell is with address '{_mobStore[i].Address}' and capasity '{_mobStore[i].Capasity}'");
                }
                else
                {
                    break;
                }
            }
            string storeIndex = Console.ReadLine();
            while (IsDigitsOnly(storeIndex))
            {
                Console.WriteLine($"-> Invalid index. Please make sure you enter a correct index.");
                Console.WriteLine("Please write index number of Mobile Phone Store below. MobilePhoneStores:");
                for (int i = 0; i < _mobStore.Length; i++)
                {
                    if (_mobStore[i] != null)
                    {
                        Console.WriteLine($" [{i}] - Store cell is with address '{_mobStore[i].Address}' and capasity '{_mobStore[i].Capasity}'");
                    }
                    else
                    {
                        break;
                    }
                }
                storeIndex = Console.ReadLine();
            }
            int storeIndexNumeric = Int32.Parse(storeIndex);
            index = IndexOfEmptyCellInStore(_mobStore);
            if (storeIndexNumeric > index && storeIndexNumeric < _mobStore.Length)
            {
                Console.WriteLine($"-> Store with index [{storeIndexNumeric}] in shop {_shop.ShopName} does not exist yet");
                SelectStoreIndexToPutPhone();
            }
            else if (storeIndexNumeric < 0 || storeIndexNumeric > _mobStore.Length - 1)
            {
                Console.WriteLine($"-> Invalid index. Please make sure you enter a correct index.");
                SelectStoreIndexToPutPhone();
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
            return index - 1;
        }
        public static bool IsObjectInArrayNull (MobileStore[] array, int index)
        {
            bool tempBool = false;
            for (int i = index; i == index;)
            {
                if (array[i] == null)
                {
                    tempBool = true;
                }
                break;
            }
            return tempBool;
        }
        public static bool IsObjectInArraysArrayNull (Phone[][] array, int indexI, int indexJ)
        {
            bool tempBool = false;
            for (int i = indexI; i == indexI;)
            {
                for (int j = indexJ; j == indexJ;)
                {
                    if (array[i][j] == null)
                    {
                        tempBool = true;
                    }
                    break;
                }
                break;
            }
            return tempBool;
        }
    }
}
