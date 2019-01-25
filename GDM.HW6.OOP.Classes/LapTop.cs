using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW6.OOP.Classes
{
    class LapTop : Computer
    {
        public string laptop = "Laptop";
        protected string Weight;
        public LapTop(string name, int power, int memory, double weight) : base(name, power, memory)
        {
            //IsSorce = false;
            Name = name;
            Power = power;
            Weight = $"{weight} Kg";
        }
        public override string GetDescription()
        {
            return $"  ID: {ID} {Environment.NewLine}  Name: {Name} {Environment.NewLine}  " +
                $"Power: {Power} W {Environment.NewLine}  Memory: {Memory} Gb {Environment.NewLine}  Waight: {Weight}";
        }
    }
}
