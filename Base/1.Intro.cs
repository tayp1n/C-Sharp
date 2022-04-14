/*1. Если выписать все натуральные числа меньше 10, кратные 3 или 5, то
получим 3, 5, 6 и 9. Сумма этих чисел - 23.
Найдите сумму всех чисел меньше 1000, кратных 3 или 5.
2. Каждый следующий элемент ряда Фибоначчи получается при сложении
двух предыдущих. Начиная с 1 и 2, первые 10 элементов будут:
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
Найдите сумму всех четных элементов ряда Фибоначчи, которые не
превышают четыре миллиона.
3. Простые делители числа 13195 - это 5, 7, 13 и 29.
Каков самый большой делитель числа 600851475143, являющийся
простым числом?
4. Число-палиндром с обеих сторон (справа налево и слева направо)
читается одинаково. Самое большое число-палиндром, полученное
умножением двух двузначных чисел – 9009 = 91 × 99.
Найдите самый большой палиндром, полученный умножением двух
трёхзначных чисел.
5. 2520 - самое маленькое число, которое делится без остатка на все
числа от 1 до 10.
Какое самое маленькое число делится нацело на все числа от 1 до 20?*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProjC
{
    class Program
    {
        
        //public static long divd(long N, long start)
        //{
        //    for (long i = start; i * i <= N; i += 2)
        //    {
        //        if (N % i == 0) return i;
        //    }
        //    return N;
        //}
        static void Main(string[] args)
        {
            //1
            //int sum = 0;
            //for(int i = 0; i <1000; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        sum += i;
            //    }
            //    else if(i % 5 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //2
            //ulong q = 1;
            //ulong i = 1;
            //ulong w = 0;
            //ulong res = 0;
            //for(int count = 1; count <=4000000; count++)
            //{
            //    w = q + i;
            //    q = i;
            //    i = w;
            //    if(w % 2 == 0)
            //    {
            //        res += i;
            //    }
            //}
            //Console.WriteLine(res);
            //3
            //long N = 15;
            //long start = 3;

            //while (N % 2 == 0)
            //{
            //    N /= 2;
            //}

            //while (N > 1)
            //{
            //    start = divd(N, start);
            //    N /= start;

            //}
            //Console.WriteLine(start);
            //4

            //int maximum = 0;
            //for (int i = 900; i < 1000; i++)
            //{
            //    for (int j = 900; j < 1000; j++)
            //    {
            //        int c = i * j;
            //        string s = c.ToString();
            //        char[] charArr = s.ToCharArray();
            //        char[] charArrRev = s.ToCharArray();
            //        Array.Reverse(charArrRev);

            //        if (charArr.SequenceEqual(charArrRev) == true)
            //        {
            //            maximum = Int32.Parse(s);
            //        }
            //    }
            //}
            //Console.WriteLine(maximum);


            //5
            //int i = 2520;
            //bool c = false;
            //int[] nums = new int[15] { 3, 4, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //while (c == false)
            //{
            //    //string str = Convert.ToString(i);
            //    for(int j = 0; j < nums.Length; j++)
            //    {
            //        if (i % nums[j] == 0)
            //        {
            //            c = true;
            //            continue;
            //        }
            //        else
            //        {
            //            c = false;
            //            break;
            //        }
            //    }
            //    i += 10;
            //}
            //Console.WriteLine(i-10);

        }
        
    }
}
