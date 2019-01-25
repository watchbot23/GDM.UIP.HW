using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIP.GDM.HW5.OOP.Classes.Factory
{
    public class Car : Agregat
    {
        public string ItemType
        {
            get { return AgregatType; }
            set
            {
                AgregatType = "Car";
            }
        }
        public bool IsCarDone(int details)
        {
            bool isCarDone = false;
            if (details == CompleteItem)
            {
                isCarDone = true;
            }
            return isCarDone;
        }
    }
}