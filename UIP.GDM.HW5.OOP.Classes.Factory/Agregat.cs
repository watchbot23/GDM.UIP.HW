using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIP.GDM.HW5.OOP.Classes.Factory
{
    public class Agregat
    {
        private string _agregatType;
        //public string AgregatType
        //{
        //    get { return _agregatType; }
        //    set
        //    {
        //        if (value == "Car")
        //        {
        //            _agregatType = value;
        //            CompleteItem = 50;
        //        }
        //        if (AgregatType == "Tank")
        //        {
        //            CompleteItem = 100;
        //        }
        //        if (AgregatType == "Plane")
        //        {
        //            CompleteItem = 150;
        //        }
        //    }
        //}

        public int CompletedItem { get; set; }
        //{
        //    get { return CompleteItem; }
        //    set
        //    {
        //        if (AgregatType == "Car")
        //        {
        //            CompleteItem = 50;
        //        }
        //        if (AgregatType == "Tank")
        //        {
        //            CompleteItem = 100;
        //        }
        //        if (AgregatType == "Plane")
        //        {
        //            CompleteItem = 150;
        //        }
        //    }
        //}
        public int CurrentDetalsCount;
        //public Car Car;
        //public Plane Plane;
        //public Tank Tank;
    }
}
