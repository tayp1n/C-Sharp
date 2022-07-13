using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class AcademicMobility: Student
    {
        public partial class InterProgram
        {
            
            public List<Student> studentss = new List<Student>();
            public List<InterProgram> inters = new List<InterProgram>();
            string name;
            string count;
            public InterProgram() { }
            public InterProgram(string _name, string _count)
            {
                name = _name;
                count = _count;
            }
            public void PresentationIntern()
            {
                foreach(var item in inters)
                {
                    Console.WriteLine($"Program: {item} \n");
                }
            }
            
        }
        string[] univers = {
            "University 1 Linz",
            "University 2 Ukraine",
            "University 3 Germany",
            "University 4 UK",
            "University 5 USA",
            "University 6, Kanada"
        };
        private string internationalPrograms;
        private string partnerUniversities;
        private string contacts;
        public List<AcademicMobility> academicMobilities = new List<AcademicMobility>();
        public AcademicMobility()
        {
            internationalPrograms = null;
            partnerUniversities = null;
            contacts = null;
        }

        public void Registration()
        {
            Console.WriteLine("Choose your university: ");
            string choose = Console.ReadLine();
            Console.WriteLine("You have been applied at the univesity.");
            StreamWriter fout = new StreamWriter("output.txt");
            fout.WriteLine($"Student: {Surname}  {Array.BinarySearch(univers, choose)}");
            fout.Close();
        }

        public int UniversSearch(string searchedValue)
        {
            return Array.BinarySearch(univers, searchedValue);
        }

       public AcademicMobility(string _internationalPrograms, string _partnetUniversities, string _contacts)
        {
            internationalPrograms = _internationalPrograms;
            partnerUniversities = _partnetUniversities;
            contacts = _contacts;
        }
        public void Presentation()
        {
            Console.WriteLine("Simple mobility");
            foreach(var item in academicMobilities)
            {
                Console.WriteLine($"{item}, ");
            }
        }






    }
}
