/*1. Заполнить одномерный массив случайными числами. Сжать
массив, удалив из него все 0 и заполнить освободившиеся
справа элементы значениями -1.
2. Заполнить одномерные массив случайными числами.
Преобразовать массив так, чтобы сначала шли отрицательные
элементы, а потом положительные.
3. В двумерном массиве, размеры которого вводятся с
клавиатуры, поменять местами заданные столбцы.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProjC
{
    class Program
    {

        static void Main(string[] args)
        {
            //1
            //Random rand = new Random();
            //int[] a = new int[10]; int[] a1 = new int[a.Length]; int ind = 0;

            //for (int i = 0; i < a.Length; i++)
            //    a[i] = rand.Next(0, 7);

            //for (int i = 0; i < a.Length; i++)
            //    if (a[i] != 0)
            //    {
            //        a1[ind] = a[i];
            //        ind++;
            //    }
            //for (int i = ind; i < a1.Length; i++)
            //    a1[i] = -1;

            //Console.WriteLine(String.Join(" ", a1));
            //2

            //Random rand = new Random();
            //int[] a = new int[10]; int[] a1 = new int[a.Length]; int ind = 0; int ind2 = 1;

            //for (int i = 0; i < a.Length; i++)
            //    a[i] = rand.Next(-7, 7);

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] >= 0)
            //    {
            //        a1[ind] = a[i];
            //        ind++;
            //    }
            //    if (a[i] < 0)
            //    {
            //        a1[a1.Length - ind2] = a[i];
            //        ind2++;
            //    }
            //}

            //Console.WriteLine(String.Join(" ", a1));
            //3
            Random rand = new Random();
            Console.Write("Input the columns: ");
            int columns = Int32.Parse(Console.ReadLine());
            Console.Write("Input the rows: ");
            int rows = Int32.Parse(Console.ReadLine());

            int[,] arr = new int[columns, rows];
            Console.Clear();
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    arr[i, j] = rand.Next(0, 15);
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("Input 1 if you want to change the columns");
            Console.WriteLine("Input 2 if you want to change the rows");
            int choice = Int32.Parse(Console.ReadLine());

            //Console.Clear();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Input the columns: ");
                    int c = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Input the columns to change with: ");
                    int c1 = Int32.Parse(Console.ReadLine());
                    int tmpC = 0;

                    for (int j = 0; j < rows; j++)
                    {
                        tmpC = arr[j, c];
                        arr[j, c] = arr[j, c1];
                        arr[j, c1] = tmpC;
                    }

                    for (int i = 0; i < columns; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            Console.Write("{0}\t", arr[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Input the rows: ");
                    int r = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Input the columns to change with: ");
                    int r1 = Int32.Parse(Console.ReadLine());
                    int tmpR = 0;

                    for (int j = 0; j < columns; j++)
                    {
                        tmpC = arr[r, j];
                        arr[r, j] = arr[r1, j];
                        arr[r1, j] = tmpC;
                    }

                    for (int i = 0; i < columns; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            Console.Write("{0}\t", arr[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;
            }
            Console.WriteLine("Input the columns: ");


        }






    }




}
