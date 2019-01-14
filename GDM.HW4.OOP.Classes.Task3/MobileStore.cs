using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task3
{
    public class MobileStore
    {
        private int _capascity;
        private string _address;
        public int Capacity
        {
            get { return _capascity; }
            set
            {
                if (value < 1 && value > 10)
                {
                    Console.WriteLine("Please write capasity (number > 1 && number <= 10) of phones which could be in store");
                }
                else
                {
                    _capascity = value;
                }
            }
        }
        public string Address
        {
            set
            {
                if (value.Length < 10)
                {
                    Console.WriteLine("Please write shop address (text with length > 10) of stores");
                }
                else
                {
                    _address = value;
                }
            }
            get { return _address; }
        }
        public Phone Phones { get; set; }
        public Phone[] PhonesArraysArray { get; set; }
        public void SetNewStoreAddress(Shop shop)
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
                if (shop.IsObjectInArrayNull(shop.MobStoresArray, i))
                {
                    shop.MobStoresArray[i] = new MobileStore { Address = storeAddress };
                    break;
                }
            }
        }
        public void SetStoreCapacity(Shop shop)
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
                if (!shop.IsObjectInArrayNull(shop.MobStoresArray, i) && shop.MobStoresArray[i].Capacity == 0)
                {
                    shop.MobStoresArray[i].Capacity = phonesQuantityInStoreNumeric;
                    shop.MobStoresArray[i].PhonesArraysArray = new Phone[shop.MobStoresArray[i].Capacity];
                    Console.WriteLine($"-> Shop with address '{shop.MobStoresArray[i].Address}' and Capacity '{shop.MobStoresArray[i].Capacity}' successfully created.");
                    break;
                }
            }
        }
        public int IndexOfEmptyCellInStore(MobileStore[] array)
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

    }
}
