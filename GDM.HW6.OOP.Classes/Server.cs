using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW6.OOP.Classes
{
    class Server : Computer
    {
        public string server = "Server";
        protected int ProcessorQuantity;
        public Server(string name, int power, int memory, int processorQuantity) : base(name, power, memory)
        {
            //IsSorce = false;
            Name = name;
            Power = power;
            ProcessorQuantity = processorQuantity;
        }
        public override string GetDescription()
        {
            return $"  ID: {ID} {Environment.NewLine}  Name: {Name} {Environment.NewLine}  " +
                $"Power: {Power} W {Environment.NewLine}  Memory: {Memory} Gb {Environment.NewLine}  Processors Quantity: {ProcessorQuantity}";
        }
    }
}
