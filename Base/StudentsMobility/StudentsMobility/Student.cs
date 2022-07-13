using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {

        private string surname;
        private string name;
        private string course;
        private string nameOfProgram;
        private string university;
        private int rating;
        private string awards;

        public Student()
        {
            surname = null;
            name = null;
            course = null;
            nameOfProgram = null;
            university = null;
            rating = 0;
            awards = null;
        }
        public Student(string _surname, string _name, string _course, string _nameOfProgram, string _university, int _rating, string _awards)
        {
            surname = _surname;
            name = _name;
            course = _course;
            nameOfProgram = _nameOfProgram;
            university = _university;
            rating = _rating;
            awards = _awards;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                value = name;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                value = surname;
            }
        }
        public string Course
        {
            get
            {
                return course;
            }
            set
            {
                value = course;
            }
        }
        public string NameOfProgram
        {
            get
            {
                return nameOfProgram;
            }
            set
            {
                value = nameOfProgram;
            }
        }
        public string University
        {
            get
            {
                return university;
            }
            set
            {
                value = university;
            }
        }
        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                value = rating;
            }
        }
        public string Awards
        {
            get
            {
                return awards;
            }
            set
            {
                value = awards;
            }
        }

        public void Read()
        {
            Console.WriteLine($"{name}, {surname}, {course}, {nameOfProgram}, {university}, {rating}, {awards}");
        }
        public void Write(string n,string sn, string c, string np,string u, int r, string a)
        {
            surname = sn;
            name = n;
            course = c;
            nameOfProgram = np;
            university = u;
            rating = r;
            awards = a;
        }
        public void Save()
        {
            StreamWriter fout = new StreamWriter("output.txt");      // 2
            fout.Write($"{Surname} ");
            fout.Write($"{Name} ");                              
            fout.Write($"{Course} ");                              
            fout.Write($"{NameOfProgram} ");                              
            fout.Write($"{University} ");                              
            fout.Write($"{Rating} ");                              
            fout.Write($"{Awards} ");                              
            fout.WriteLine();                              
            fout.Close();
        }

        public int StudentAverage()
        {
            Random random = new Random();
            int sum = 0;
            int articles = random.Next(0,3);
            int conferences = random.Next(0,5);
            int englishGrades = random.Next(10, 15);
            for (int i =0; i <=10; i++)
            {
                sum += random.Next(40,100);
            }
            sum /= 10;
            sum += articles;
            sum += conferences;
            sum += englishGrades;
            rating = sum;
            return sum;
        }
        public void IQTest()
        {
            double iq = StudentAverage() / 3;
            StreamWriter fout = new StreamWriter("iq.txt");      // 2
            fout.WriteLine(iq);
            fout.Close();
        }

        public override string ToString()
        {
            return $"Name - {Name}\nSurname - {Surname}\nAdress - {Course}\n";
        }
    }
}
