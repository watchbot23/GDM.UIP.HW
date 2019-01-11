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
        public Phone[] PhonesArraysArray { get; set; }
    }
}
