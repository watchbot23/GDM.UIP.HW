using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW6.OOP.Classes
{
    public sealed class PlasmTV : Electronics
    {
        public string plazmTV = "PlasmTV";
        public string ScreenDiagonal;
        public string ScreenResolution;
        public PlasmTV(string name, int power, int screenDiagonal, string screenResolution) : base(name, power)
        {
            //IsSorce = false;
            Name = name;
            Power = power;
            ScreenDiagonal = $"{screenDiagonal}''";
            ScreenResolution = $"{screenResolution} Px";
        }
        public override string GetDescription()
        {
            return $"  ID: {ID} {Environment.NewLine}  Name: {Name} {Environment.NewLine}  " +
                $"Power: {Power} W {Environment.NewLine}  Screen Diagonal: {ScreenDiagonal} {Environment.NewLine}  Screen Resolution: {ScreenResolution}";
        }
    }
}
