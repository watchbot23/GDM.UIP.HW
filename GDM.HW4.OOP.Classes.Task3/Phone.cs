using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task3
{
    public class Phone
    {
        private string _name;
        private int _price;

        public string ModelName
        {
            get { return _name; }
            set
            {
                if (value.Length < 10)
                {
                    Console.WriteLine("Please write phone model name (text with length > 10)");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public int Price
        {
            get { return _price; }
            set
            {
                if (value < 0 && value > 100000)
                {
                    Console.WriteLine("Please write phone price (0 < Value < 100000)");
                }
                else
                {
                    _price = value;
                }
            }
        }
        
        public void AvailableStoresToPutPhone(Shop shop)
        {
            Console.WriteLine("Please write index number of Mobile Phone Store below. MobilePhoneStores:");
            for (int i = 0; i < shop.MobStoresArray.Length; i++)
            {
                if (!shop.IsObjectInArrayNull(shop.MobStoresArray, i))
                {
                    Console.WriteLine($" [{i}] - Store cell is with address '{shop.MobStoresArray[i].Address}' and Capacity '{shop.MobStoresArray[i].Capacity}'");
                }
                else
                {
                    break;
                }
            }
        }
        public int Index(Shop shop)
        {
            string storeIndex = Console.ReadLine();
            int index = shop.MobStoresArray.Length - 1;
            int storeIndexNumeric;
            while (!Int32.TryParse(storeIndex, out storeIndexNumeric) || storeIndexNumeric < 0 || storeIndexNumeric > shop.MobStoresArray.Length - 1 ||
                shop.IsObjectInArrayNull(shop.MobStoresArray, storeIndexNumeric) && storeIndexNumeric < shop.MobStoresArray.Length)
            {
                Console.WriteLine($"-> Invalid index. Please make sure you enter a correct index.");
                AvailableStoresToPutPhone(shop);
                storeIndex = Console.ReadLine();
            }
            index = storeIndexNumeric;
            return index;
        }
        public static int IndexOfEmptyCellInStore(MobileStore[] array)
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
