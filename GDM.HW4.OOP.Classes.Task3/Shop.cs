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
     }
}
