using GDM.HW7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW7.Services
{
    public class SquareCalculator
    {
        private long CalculateArea(IList<Point> points, bool isAltAppr)
        {
            long landArea = 0;

            for (int i = 0; i < points.Count; i++)
            {
                int nextIndex = (i == points.Count - 1) ? 0 : i + 1;

                int prevIndex = (i == 0) ? points.Count - 1 : i - 1;

                long par1 = isAltAppr ? points[i].X : points[i].Y;

                long par2_1 = isAltAppr ? points[nextIndex].Y : points[prevIndex].X;

                long par2_2 = isAltAppr ? points[prevIndex].Y : points[nextIndex].X;

                long tempLandArea = landArea;

                landArea += par1 * (par2_1 - par2_2);
            }
            long result = (long)Math.Abs(landArea / 2);

            return result;
        }

        public void CalculatedLandSquare(IList<Point> points, Logger logger)
        {
            if (CalculateArea(points, true) == CalculateArea(points, false) && points.Count > 2)
            {
                long res = CalculateArea(points, true);
                Console.WriteLine($"Square is {res}");
                logger.Info($"Square was calculated");
            }
            else
            {
                Console.WriteLine("-> Invalid coordinates. Please try again.");
                logger.Warn("Invalid coordinates");
            }
        }
    }
}
