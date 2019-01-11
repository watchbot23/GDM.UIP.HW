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
    }
}
