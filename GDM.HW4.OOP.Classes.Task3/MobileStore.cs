using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task3
{
    public class MobileStore
    {
        private string _capasity;
        private int _address;

        public string Capasity
        {
            get { return _capasity; }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Please write valid (not empty) name for store");
                }
                else
                {
                    _capasity = value;
                }
            }
        }
        public int Address
        {
            set
            {
                if (value < 0 && value > 100000)
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
    }
}
