using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIP.GDM.HW5.OOP.Classes.Factory
{
    public class Plane : Agregat
    {
        public string ItemType
        {
            get { return AgregatType; }
            set
            {
                AgregatType = "Plane";
            }
        }
        public bool IsPlaneDone(int details)
        {
            bool isPlaneDone = false;
            if (details == CompleteItem)
            {
                isPlaneDone = true;
            }
            return isPlaneDone;
        }
    }
}
