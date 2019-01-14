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
            int workersQuantity = 3;
            string[] workersNames = new string[3] { "Anton", "Bogdan", "Clark" };//примитивная симуляция базы данных
            int[] workersXP = new int[3] { 1, 3, 7 };//примитивная симуляция базы данных
            var workers = new Worker[workersQuantity];
            for (int i = 0; i < workersQuantity; i++)
            {
                workers[i] = new Worker();
                workers[i].Name = workersNames[i];
                workers[i].Expirience = workersXP[i];
            }
            Agregat agregatValue = new Agregat();
            string agregat = agregatValue.GetAgregatValue();
            int completeAgrigat = 50;

            for (int i = 0; agregat.Length < completeAgrigat; i++)
            {
                agregat = workers[0].DoWork(agregat, completeAgrigat, workers[0].Expirience);
                agregat = workers[1].DoWork(agregat, completeAgrigat, workers[1].Expirience);
                agregat = workers[2].DoWork(agregat, completeAgrigat, workers[2].Expirience);
                Console.WriteLine(agregat);
            }
            Console.ReadLine();
        }
    }
}
