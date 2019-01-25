using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW6.OOP.Classes
{
    public abstract class Computer : Electronics
    {
        public int Memory { get; set; }
        public static int GeneralMemory;
        public Computer(string name, int power, int memory) : base (name, power)
        {
            //IsSorce = false;
            Memory = memory;
            GeneralMemory += memory;
        }
        public string GetGeneralMemory()
        {
            return $"General memory of all computers is: {GeneralMemory} Gb";
        }
    }
}
