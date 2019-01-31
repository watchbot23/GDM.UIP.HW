using GDM.HW7.Interfaces;
using GDM.HW7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW7.Services
{
    class ConsoleStorage : IStorage
    {
        public void AddMessage(LogRecord logRecord)
        {
            Console.WriteLine("ConsoleStorage: " + logRecord.ToString());
        }
    }
}
