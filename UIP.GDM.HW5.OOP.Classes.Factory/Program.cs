using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIP.GDM.HW5.OOP.Classes.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country();
            country.GetOrders();
            Factory factory = new Factory();
            factory.Name = "GigaFac";
        }
    }
}
