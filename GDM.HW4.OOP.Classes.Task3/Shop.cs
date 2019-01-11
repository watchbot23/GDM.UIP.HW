using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task3
{
    public class Shop
    {
        private string _name;
        private int _numberOfStores;
        public string ShopName
        {
            get { return _name; }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Please write valid (not empty) name for shop");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public int NumberOfStores
        {
            get { return _numberOfStores; }
            set
            {
                if (value < 1 && value > 10)
                {
                    Console.WriteLine($"Please write valid (not empty) number of stores for shop.");
                }
                else
                {
                    _numberOfStores = value;
                }
            }
        }
        public MobileStore MobStores { get; set; }
        public MobileStore[] MobStoresArray { get; set; }
        public void SetShopName()
        {
            string shopName;
            do
            {
                Console.WriteLine("Please write valid (not empty) name for shop");
                shopName = Console.ReadLine();
            }
            while (shopName.Length < 1);
            ShopName = shopName;
            Console.WriteLine($"-> Great, the name of shop is '{ShopName}'");
        }
        /// <summary>
        /// sets quantity of stores in the shop
        /// </summary>
        public void SetNumberOfStores()
        {
            string storesNumber;
            int tempNumberNumeric;
            do
            {
                Console.WriteLine($"Please write valid (number > 0 && number <= 10) number of stores for shop '{ShopName}'.");
                storesNumber = Console.ReadLine();
            }
            while (!Int32.TryParse(storesNumber, out tempNumberNumeric) || tempNumberNumeric < 1 || tempNumberNumeric > 10);
            NumberOfStores = tempNumberNumeric;
            Console.WriteLine($"-> Great, the number of stores in shop '{ShopName}' is '{NumberOfStores}'.");
        }
        public void GetPhonesInStore(Shop shop)
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
        public bool IsObjectInArrayNull(MobileStore[] array, int index)
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
        public bool IsObjectInArraysArrayNull(Phone[] array, int indexI, int indexJ)
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
