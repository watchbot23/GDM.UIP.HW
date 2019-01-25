using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIP.GDM.HW5.OOP.Classes.Factory
{
    public class Tank : Agregat
    {
        public string ItemType
        {
            get { return AgregatType; }
            set
            {
                AgregatType = "Tank";
            }
        }
        public bool IsTankDone(int details)
        {
            bool isTankDone = false;
            if (details == CompleteItem)
            {
                isTankDone = true;
            }
            return isTankDone;
        }
    }
}
