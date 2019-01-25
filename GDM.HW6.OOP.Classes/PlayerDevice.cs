using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW6.OOP.Classes
{
    public class PlayerDevice : Electronics
    {
        public string player = "Pleyer Device";
        protected string KodekSupported;
        public PlayerDevice(string name, int power, string kodek) : base(name, power)
        {
            //IsSorce = false;
            Name = name;
            Power = power;
            KodekSupported = $"{kodek}";
        }
        public override string GetDescription()
        {
            return $"  ID: {ID} {Environment.NewLine}  Name: {Name} {Environment.NewLine}  " +
                $"Power: {Power} W {Environment.NewLine}  Supported kodek: {KodekSupported}";
        }
    }
}
