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
     }
}
