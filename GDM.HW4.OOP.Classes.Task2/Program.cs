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

            Agregat agregatValue = new Agregat();
            string agregat = agregatValue.GetAgregatValue();
            
            int completeAgrigat = 50;

            for (int i = 0; agregat.Length < completeAgrigat; i++)
            {
                agregat = anton.JuniorWorker(agregat);
                agregat = bogdan.MiddleWorker(agregat, completeAgrigat);
                agregat = clark.SeniorWorker(agregat, completeAgrigat);
                Console.WriteLine(agregat);
            }
            Console.ReadLine();
        }
    }
}
