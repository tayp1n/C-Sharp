/*1. Придумать класс, описывающий студента и предусмотреть в
нем следующие поля: имя, фамилия, отчество, группа,
возраст, массив (рваный) оценок по программированию,
администрированию и дизайну. Также добавить методы по
работе с перечисленными данными: возможность установки/
получения оценки, получение среднего балла по данному
предмету, распечатка данных о студенте.
2. Написать статический класс, который предоставляет
статические методы для:
- расчета экспоненциальной функции;
- нахождения арксинуса заданного аргумента;
- нахождения расстояния между двумя точками в
трехмерном пространстве;
- транспонирования матрицы.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Student
    {

        string name;
        string surname;
        string patronymic;
        string group;
        int age;
        int[][] marks = new int[3][] { new int[0], new int[0], new int[0] };


        public string setName(string _name) => name = _name;
        public string setSurName(string _surname) => surname = _surname;
        public string setPatronymic(string _patronymic) => patronymic = _patronymic;
        public string setGroup(string _group) => group = _group;
        public int setAge(int _age) => age = _age;

        public string getName() => name;
        public string getSurName() => surname;
        public string getPatronymic() => patronymic;
        public string getGroup() => group;
        public int getAge() => age;
        public void GradeProg(int n)
        {
            int[] buf = new int[marks[0].Length + 1];
            for (int i = 0; i < buf.Length - 1; i++)
            {
                buf[i] = marks[0][i];
            }

            buf[buf.Length - 1] = n;

            marks[0] = new int[buf.Length];
            for (int i = 0; i < buf.Length; i++)
            {
                marks[0][i] = buf[i];
            }



        }
        public void GradeAdmin(int n)
        {
            int[] buf = new int[marks[1].Length + 1];
            for (int i = 0; i < buf.Length - 1; i++)
            {
                buf[i] = marks[1][i];
            }
            buf[buf.Length - 1] = n;
            marks[1] = new int[buf.Length];
            for (int i = 0; i < buf.Length; i++)
            {
                marks[1][i] = buf[i];
            }
        }
        public void GradeDesign(int n)
        {
            int[] buf = new int[marks[2].Length + 1];
            for (int i = 0; i < buf.Length - 1; i++)
            {
                buf[i] = marks[2][i];
            }
            buf[buf.Length - 1] = n;
            marks[2] = new int[buf.Length];
            for (int i = 0; i < buf.Length; i++)
            {
                marks[2][i] = buf[i];
            }
        }
        public void PrintInfo()
        {
            double pm = 0, am = 0, dm = 0;
            Console.WriteLine("Name " + name);
            Console.WriteLine("SurName " + surname);
            Console.WriteLine("Patronymic " + patronymic);
            Console.WriteLine("Group " + group);
            Console.WriteLine("Age " + age);


            Console.Write("Programing marks: ");
            for (int i = 0; i < marks[0].Length; i++)
            {
                pm += marks[0][i];
                Console.Write(marks[0][i] + " ");
            }
            Console.WriteLine("Average score " + pm / marks[0].Length);


            Console.Write("Administration ");
            for (int i = 0; i < marks[1].Length; i++)
            {
                am += marks[1][i];
                Console.Write(marks[1][i] + " ");
            }
            Console.WriteLine("Average score " + am / marks[1].Length);


            Console.Write("Design ");
            for (int i = 0; i < marks[2].Length; i++)
            {
                dm += marks[2][i];
                Console.Write(marks[2][i] + " ");
            }
            Console.WriteLine("Average score " + dm / marks[2].Length);

        }

    }
    
   

    static class MyMath
    {
        public static double ExponentialFunction(int x)
        {
            return Math.Round(Math.Exp(x), 5);
        }
        public static double ArcSinFunction(int x)
        {
            return Math.Round(Math.Asin(x), 5);
        }
        public static double DistanceBetweenTwoPoints(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            return res;
        }
        public static void MatrixTranspose(int cols, int row)
        {
         
            Random rand = new Random();
            int[,] arr = new int[cols, row];
            int[,] tmp = new int[cols, row];

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    arr[i, j] = rand.Next(1, 25);
                    Console.Write(arr[i, j] + " \t ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    tmp[i, j] = arr[j, i];
                    Console.Write(tmp[i, j] + " \t ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
           

            //Console.WriteLine(MyMath.ExponentialFunction(2));
            //Console.WriteLine(MyMath.ArcSinFunction(1));
            //Console.WriteLine(MyMath.DistanceBetweenTwoPoints(1, 2, 3, 4, 5, 6));
            MyMath.MatrixTranspose(3,3);
          


        }

    }
}
