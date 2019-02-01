using GDM.HW7.Interfaces;
using GDM.HW7.Models;
using GDM.HW7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareCalculator calc = new SquareCalculator();
            InputCoordinates prog = new InputCoordinates();

            string path = @"C:\Users\guzhvad\Downloads\Guzhva\C Sharp\Log.txt";

            List<IStorage> storages = new List<IStorage>() {
            new ConsoleStorage(),
            new FileStorage(path)
            };
            Logger logger = new Logger(storages);

            logger.LogLevel = Models.LogLevel.Info;

            prog.InputCoordinate(logger);
            calc.CalculateLandSquare(prog.GetPoints(), logger);

            Console.ReadLine();

        }
    }
}
