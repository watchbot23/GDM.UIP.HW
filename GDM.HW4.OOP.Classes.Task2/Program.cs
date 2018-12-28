using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker anton = new Worker();
            Worker bogdan = new Worker();
            Worker clark = new Worker();
            string agregat = "Agregat";

            for (int i = 0; agregat.Length < 50; i++)
            {
                if (50 - agregat.Length > 0) {
                    agregat = anton.JuniorWorker(agregat);
                }
                if (50 - agregat.Length >= 3)
                {
                    agregat = bogdan.MiddleWorker(agregat);
                }
                if (50 - agregat.Length >= 5)
                {
                    agregat = clark.SeniorWorker(agregat);
                }
                Console.WriteLine(agregat);
            }
            Console.ReadLine();
        }
    }
}
