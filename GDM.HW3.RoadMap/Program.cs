using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW3.RoadMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] map = new int[][] {
            new int[] { 0, 0, 1, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 1, 0 },
            new int[] { 1, 1, 0, 1, 1, 1 },
            new int[] { 0, 0, 0, 0, 0, 0 },
            new int[] { 0, 1, 1, 1, 1, 1 },
            new int[] { 0, 0, 0, 0, 0, 0 },
        };
            for (int i = 0; i < map.Length; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    while (map[i][j] == 0 && j < map[i].Length - 1)
                    {
                        //map[i][j] = -1;
                        j++;
                    }
                    i++;
                }
            }
            Console.ReadLine();
        }
        static void GoDownAndTurnBackIfZero(int i, int j)
        {

        } 

    }
}
