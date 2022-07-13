using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public static class ResearchWork
    {
        public static double dt;          // время просеивания (сек)
        private static long t1;           // начало просеивания
        private static long t2;           // окончание просеивания
        private static uint limit;        // верхняя граница диапазона просеивания
        private static int arrlength;     // размер массива
        private static BitArray Prim;     // массив результатов просеивания
        private static int counter;

       public static void Research()
        {
            uint _limit = Convert.ToUInt32(Console.ReadLine());
            limit = _limit;
            if (limit % 2 == 0) limit -= 1;
            arrlength = (int)(limit / 2);
            Prim = new BitArray(arrlength);
            t1 = DateTime.Now.Ticks;
            Sieve();                 // Просеивание
            t2 = DateTime.Now.Ticks;
            dt = (double)(t2 - t1) / 10000000D;
            counter = -1;
        }

        public static uint NextPrime()
        {
                while (counter < arrlength - 1)
                {
                    counter++;
                    if (!Prim[counter])
                        return (uint)(2 * counter + 3);
                }
                return 0;
        }

        private static void Sieve()
        {
            int imax = ((int)Math.Sqrt(limit) - 1) / 2;
            for (int i = 1; i <= imax; i++)
            {
                int jmax = (arrlength - i) / (2 * i + 1);
                for (int j = i; j <= jmax; j++)
                {
                    Prim[2 * i * j + i + j - 1] = true;
                }
            }
        }
        
        public static void Matrix()
        {
            Random rand = new Random();
            Console.WriteLine("Enter count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rage of numbers like 5, 10");
            int[,] array = new int[count,count];
            string str = Console.ReadLine();
            var allNums = Regex.Matches(str, @"\d+");
            int[] nums = new int[allNums.Count];
            for (int i = 0; i < nums.Length; ++i)
                nums[i] = int.Parse(allNums[i].Value);
            for (int i = 0; i < count; i++)
                for (int j = 0; j < count; j++)
                    array[i, j] = rand.Next(nums[0], nums[1]);
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                    Console.Write($"{array[i, j]} ");
                Console.WriteLine();
            }
            int sum = 0;
            
            int[] grades = new int[count];
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                    sum += array[i, j];
                grades[i] = sum / count;
                sum = 0;
            }
            for (var i = 0; i < count; i++)
            {
                Console.Write($"Student №{i} - {grades[i]}");
                Console.WriteLine();
            }

            int min = grades[0];
            int pos = 0;
            for (int i = 1; i < array.Length; i++)
                if (grades[i] < min)
                {
                    min = grades[i];
                    pos = i;
                }
            Console.WriteLine($"Student # {pos} has the lowest rating");
            int max = -1;
            int index = -1;
            for (int i = 0; i < count; i++)
                // Если максимальная стоимость меньше, либо равно текущей проверяемой
                if (max <= grades[i])
                {
                    // Запоминаем новое максимальное значение
                    max = grades[i];
                    // Запоминаем порядковый номер
                    index = i;
                }

            Console.WriteLine($"Student # {index} has the lowest rating");
        }
        public static void StringOrder()
        {
            string order = Console.ReadLine();
            string[] stroka = order.Split(' ');
            Array.Sort(stroka);
            Array.ForEach(stroka.OrderByDescending(x => x.Length).ToArray(), x => Console.WriteLine(x));
        }
    }
}
