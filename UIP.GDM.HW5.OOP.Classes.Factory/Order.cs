using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIP.GDM.HW5.OOP.Classes.Factory
{
    class Order
    {
        public List<Car> Cars = new List<Car>();
        public List<Plane> Planes = new List<Plane>();
        public List<Tank> Tanks = new List<Tank>();
        //public List<Agregat> Agregats= new List<Agregat>();
        public int OrderNumber;
        public bool IsOrderCompleted
        {
            get
            {
                if (true)
                {

                }
                foreach (Agregat currentAgregat in Agregats)
                {
                    if (currentAgregat.Car.IsCarDone(currentAgregat.Car.CurrentDetalsCount))
                    {

                    }
                }
            }
        }
    }
}
