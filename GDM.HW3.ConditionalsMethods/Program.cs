using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW3.ConditionalsMethods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            //Task 1
            string task1 = "Task 1.";
            var eggsNumberInBox = 10;
            var eggs = 0;
            while (eggs < eggsNumberInBox)
            {
                eggs++;
            }
            Console.WriteLine(task1 + $"1. Количество яиц в лотке {eggs} шт.");
            int eggs2 = 10;
            int count = 0;
            do
            {
                eggs--;
                count++;
            } while (eggs != 0);
            Console.WriteLine(task1 + $"2. При наличии {eggs2} яиц в лотке, можно достать по 1 яйцу {count} раз");

            //Task 2
            string task2 = "Task 2. ";
            double fac = randomizer.Next(0, 20);
            Console.WriteLine(task2 + $"Факториал({fac}) = {Factorial(fac)}");

            //Task 3
            string task3 = "Task 3. ";
            int fib = randomizer.Next(0, 30);
            int[] fibArray = FibonachiArray(fib);
            Console.WriteLine(task3 + $"Последовательностью чисел Фибоначчи для {fib} является:");
            for (int i = 0; i < fibArray.Length; i++)
            {
                Console.Write(fibArray[i] + " ");
            }


            //Task 4
            string task4 = "Task 4. ";
            var year = randomizer.Next(1500, 3000); ;
            var month = randomizer.Next(1, 12);
            string[] months = new string[] { "январе", "феврале", "марте", "апреле", "мае", "июне", "июле", "августе", "сентябре", "октябре", "ноябре", "декабре", };
            int daysNumberInMonth = DaysNumberInMonth(month, year);
            Console.WriteLine("\n" + task4 + $"Количество дней в {months[month - 1]} {year}-го года - {daysNumberInMonth}");

            //Task 5
            string task5 = "Task 5:";
            Console.WriteLine(task5);
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomizer.Next(-50, 50);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int[] sortedArray = ReccursiveQuickArraySort(array, 0, array.Length - 1);
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

            //Task 6
            //В этом задании не нужно было создавать метод, но я все же в целях тренировки создал его, так что не сершай))
            //И еще я узнал, что некоторые мои методы говно, т.к. там больше 15-ти строк кода. Буду в будущем исправляться.
            string task6 = "Task 6:";
            Console.WriteLine("\n" + task6);
            int randomArrayLength = randomizer.Next(7, 20);
            int[] randomArray = new int[randomArrayLength];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randomizer.Next(-50, 50);
                Console.Write(randomArray[i] + " ");
            }
            Console.WriteLine();

            PutZeroBetweenMimMaxValueArray(randomArray);
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.Write(randomArray[i] + " ");
            }

            //Task 7
            string task7 = "Task 7:";
            Console.WriteLine("\n" + task7 + "1:");

            //создаем рандомный массив массивов
            int arrN = randomizer.Next(1, 10);
            int[][] mainArray = new int[arrN][];
            for (int i = 0; i < mainArray.Length; i++)
            {
                mainArray[i] = new int[randomizer.Next(20, 50)];
                for (int j = 0; j < mainArray[i].Length; j++)
                {
                    if (j != mainArray[i].Length - 1)
                    {
                        mainArray[i][j] = randomizer.Next(0, 9);
                        Console.Write(mainArray[i][j] + " ");
                    }
                    else
                    {
                        mainArray[i][j] = randomizer.Next(0, 9);
                        Console.Write(mainArray[i][j] + "\n");
                    }
                }
            }
            Console.WriteLine("\n" + task7 + "2:");


            //сортируем значения массива по возрастанию
            for (int i = 0; i < mainArray.Length; i++)
            {
                for (int j = 0; j < mainArray[i].Length; j++)
                {
                    for (int k = 0; k < mainArray[i].Length - 1; k++)
                    {
                        if (mainArray[i][k] > mainArray[i][k + 1])
                        {
                            int temp = mainArray[i][k];
                            mainArray[i][k] = mainArray[i][k + 1];
                            mainArray[i][k + 1] = temp;
                        }
                    }
                }
            }
            //выводим на консоль отсортированный массив
            for (int i = 0; i < mainArray.Length; i++)
            {
                for (int j = 0; j < mainArray[i].Length; j++)
                {
                    if (j != mainArray[i].Length - 1)
                    {
                        Console.Write(mainArray[i][j] + " ");
                    }
                    else
                    {
                        Console.Write(mainArray[i][j] + "\n");
                    }
                }
            }

            //Task 8
            string task8 = "Task 8:";
            Console.WriteLine("\n" + task8 + "1:");
            string[] task = new string[15];
            int[] tempArray = new int[15];
            int tempA;
            int tempB;
            int tempRes = 0;
            for (int i = 0; i < task.Length; i++)
            {
                do
                {
                    tempA = randomizer.Next(2, 9);
                    tempB = randomizer.Next(2, 9);
                    tempRes = tempA * tempB;
                    tempArray[i] = tempRes;
                    task[i] = $"Сколько будет {tempA} * {tempB}";
                }
                while (IsDupl(tempArray, tempRes, i));
            }

            for (int i = 0; i < task.Length; i++)
            {
                Console.WriteLine(task[i]);
            }

            Console.ReadLine();
        }
        
        //Task 2
        static double Factorial(double fac)
        {
            if (fac < 0)
            {
                return 0;
            }
            return fac == 0 ? 1 : fac * Factorial(fac - 1);
         }

        //Task 3
        static int Fibonachi(int n)
        {
            return n > 1 ? Fibonachi(n - 1) + Fibonachi(n - 2) : n;
        }
        static int[] FibonachiArray(int n)
        {
            int[] tempArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                tempArray[i] = Fibonachi(i);
            }
            return tempArray;
        }

        //Task 4
        static int DaysNumberInMonth(int month, int year)
        {
            if (month == 2 && year % 4 == 0 && year % 100 != 0 || month == 2 && year % 100 == 0)
            {
                return 29;
            }
            if (month == 2)
            {
                return 28;
            }
            if (month % 2 == 1 && month < 7 || month > 8 && month % 2 == 1)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }

        //Task 5
        static int[] ReccursiveQuickArraySort(int[] array, int firstArrayIndex, int lastArrayIndex)
        {
            int f = firstArrayIndex;
            int l = lastArrayIndex;
            int mid = array[(f + l) / 2];
            do
            {
                while (array[f] < mid)
                {
                    ++f;
                }
                while (array[l] > mid)
                {
                    --l;
                }
                if (f <= l)
                {
                    if (f < l)
                    {
                        int temp = array[f];
                        array[f] = array[l];
                        array[l] = temp;
                    }
                    ++f;
                    --l;
                }
            }
            while (f <= l);
            if (firstArrayIndex < l)
            {
                ReccursiveQuickArraySort(array, firstArrayIndex, l);
            }
            if (f < lastArrayIndex)
            {
                ReccursiveQuickArraySort(array, f, lastArrayIndex);
            }
            return array;
        }

        //Task 6
        static int[] PutZeroBetweenMimMaxValueArray(int[] array)
        {
            int[] tempArray = (int[])array.Clone();
            int[] sortedRandomArray = ReccursiveQuickArraySort(tempArray, 0, tempArray.Length - 1);
            int min = 0;
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == sortedRandomArray[0])
                {
                    min = i;
                }
                if (array[i] == sortedRandomArray[sortedRandomArray.Length - 1])
                {
                    max = i;
                }
            }
            if (min > max)
            {
                for (int i = max + 1; i < min; i++)
                {
                    array[i] = 0;
                }
            }
            else
            {
                for (int i = min + 1; i < max; i++)
                {
                    array[i] = 0;
                }
            }
            return array;
        }

        //Task 8
        static bool IsDupl(int[] array, int veriable, int arrayIndex)
        {
            bool temp = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == veriable && arrayIndex != i)
                {
                    temp = true;
                    return temp;
                }
            }
            return temp;
        }
    }
}
