using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDV.HW1.VariablesTypesTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            // №1
            double a = 5;
            double b = 8;
            double S;
            double P;

            S = a * b;

            Console.WriteLine("S = " + S);

            P = 2 * (a + b);

            Console.WriteLine("P = " + P);

            // №2
            double R = 7.5;
            double pi = 3.14;
            double L = 2 * pi * R;

            Console.WriteLine("Длина окружности = " + L);

            S = pi * R * R;

            Console.WriteLine("Площадь круга = " + S);

            // №3

            a = 15;
            b = 9;

            Console.WriteLine("Среднее арифм. = " + ((a + b) / 2));

            // #4

            a = 7;
            b = 11;

            double Geom = Math.Pow(a * b, 1.0 / 2.0);

            Console.WriteLine("Срю геометрическое = " + Geom);

            // #5

            double x1 = 5;
            double x2 = 9;

            double rasst = Math.Sqrt(Math.Pow(x2 - x1, 2.0));

            Console.WriteLine("Расстояние между точками = " + rasst);

            // #6

            x1 = 2;
            double y1 = 2;
            x2 = 9;
            double y2 = 6;

            double rasstX = Math.Sqrt(Math.Pow(x2 - x1, 2.0));
            double rasstY = Math.Sqrt(Math.Pow(y2 - y1, 2.0));

            S = rasstX * rasstY;
            P = 2 * (rasstX + rasstY);

            Console.WriteLine("Площать прямоугольника = " + S);
            Console.WriteLine("Периметр прямоугольника = " + P);

            // #7

            double A = 1;
            double B = 2;
            double C = 3;
            a = B;
            B = A;
            A = C;
            C = a;

            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);

            Console.Write("Waiting for your command, leather Master: ");

            Console.ReadLine();
        }
    }
}
