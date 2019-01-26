using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIP.GDM.HW5.OOP.Classes.Factory
{
    class Worker
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Qualification { get; set; }
        private int _workerOutput;
        public int WorkerOutput
        {
            get { return _workerOutput; }
            set
            {
                if (Qualification == "Junior")
                {
                    _workerOutput = 1;
                }
                if (Qualification == "Middle")
                {
                    _workerOutput = 3;
                }
                if (Qualification == "Senior")
                {
                    _workerOutput = 5;
                }
            }
        }
    }
}
