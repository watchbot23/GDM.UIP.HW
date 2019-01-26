using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW6.OOP.Classes
{
    public class LEDTV : Electronics
    {
        public string ledTV = "LED TV";
        protected string ScreenDiagonal;
        protected string Frequency;
        public LEDTV(string name, int power, int screenDiagonal, int frequency) : base(name, power)
        {
            //IsSorce = false;
            Name = name;
            Power = power;
            ScreenDiagonal = $"{screenDiagonal}''";
            Frequency = $"{frequency} Hz";
        }
        public override string GetDescription()
        {
            return $"  ID: {ID} {Environment.NewLine}  Name: {Name} {Environment.NewLine}  " +
                $"Power: {Power} W {Environment.NewLine}  ScreenDiagonal: {ScreenDiagonal} {Environment.NewLine}  Frequency: {Frequency}";
        }
    }
}
