using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task2
{
    class Worker
    {
        string[] WorkersXP = new string[3] { "Junior", "Middle", "Senior" };
        public string Name { get; set; }
        public int Expirience { get; set; }

        public string DoWork(string agregat, int completeAgrigat, int workersXPYears)
        {
            string tempAgregat = agregat;
            if (workersXPYears <= 1)
            {
                tempAgregat = tempAgregat + "a";
            }
            if (workersXPYears > 1 && workersXPYears < 5)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (completeAgrigat - tempAgregat.Length != 0)
                    {
                        tempAgregat = tempAgregat + "b";
                    }
                }
            }
            if (workersXPYears >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (completeAgrigat - tempAgregat.Length != 0)
                    {
                        tempAgregat = tempAgregat + "c";
                    }
                }
            }
            return tempAgregat;
        }
    }
}
