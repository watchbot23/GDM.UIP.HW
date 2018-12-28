using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW4.OOP.Classes.Task2
{
    class Worker
    {
        public string JuniorWorker(string agregat)
        {
            return agregat + "a";
        }
        public string MiddleWorker(string agregat, int completeAgrigat)
        {
            //string tempAgregat = agregat;
            for (int i = 0; i < 3; i++)
            {
                if (completeAgrigat - agregat.Length != 0)
                {
                    agregat = agregat + "b";
                }
            }
            return agregat;
        }
            public string SeniorWorker(string agregat, int completeAgrigat)
        {
            for (int i = 0; i < 5; i++)
            {
                if (completeAgrigat - agregat.Length != 0)
                {
                    agregat = agregat + "c";
                }
            }
            return agregat;
        }
    }
}
