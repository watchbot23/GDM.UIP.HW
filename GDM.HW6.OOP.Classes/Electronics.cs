using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW6.OOP.Classes
{
    public abstract class Electronics
    {
        public bool IsSorce { get; set; }
        public bool IsInNetWork { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int ID { get; set; }
        public static int UniqueID = GetStartID();
        public static int GeneralPower;
        public Electronics(string name, int power)
        {
            Name = name;
            Power = power;
            GeneralPower += power;
            GetUniqueID();
            ID = UniqueID;
        }
        public abstract string GetDescription();
        public override string ToString()
        {
            return GetDescription() + $"\n  {this.GetType()}";
        }
        public string GetGeneralPower()
        {
            return $"General power of all devices is: {GeneralPower} W";
        }
        private static int GetStartID()
        {
            Random randomizer = new Random();
            return randomizer.Next(1, 100);
        }
        private int GetUniqueID()
        {
            return UniqueID++;
        }
        //public bool IsAvailableGeneratorPowerEnoughForConnection()
        //{
        //    bool isAvailableGeneratorPowerEnoughForConnection = false;
        //    if (generator)
        //    {

        //    }
        //    return isAvailableGeneratorPowerEnoughForConnection;
        //}

    }
}
