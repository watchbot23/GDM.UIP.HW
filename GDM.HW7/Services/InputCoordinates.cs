using GDM.HW7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW7.Services
{
    class InputCoordinates
    {
        SquareCalculator calc = new SquareCalculator();

        public IList<Point> Points = new List<Point>();

        public void AddPointToList(Point point)
        {
            Points.Add(point);
        }

        public void TypeCoordinates(Logger logger)
        {
            string coordinateX = "";

            int coordinateXNumeric = 0;

            string coordinateY = "";

            int coordinateYNumeric = 0;

            string isDone = "";

            while (isDone != "y")
            {
                do
                {
                    Console.WriteLine("Please enter X coordinate");
                    coordinateX = Console.ReadLine();
                } while (!Int32.TryParse(coordinateX, out coordinateXNumeric));

                do
                {
                    Console.WriteLine("Please enter Y coordinate");
                    coordinateY = Console.ReadLine();
                } while (!Int32.TryParse(coordinateY, out coordinateYNumeric));

                AddPointToList(new Point(coordinateXNumeric, coordinateYNumeric));
                logger.Info($"Created point with coordinates ({coordinateXNumeric},{coordinateYNumeric})");

                Console.WriteLine("Have you entered all coordinates? Type 'y' for Yes or 'n' for No:");
                isDone = Console.ReadLine();
            }
            calc.CalculatedLandSquare(Points, logger);
        }

        public IList<Point> GetPoints()
        {
            return Points;
        }
    }
}
