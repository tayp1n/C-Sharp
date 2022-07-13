using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    internal class Software
    {
        private static string[] _readText;
        private const string TxtSourcePath = "People.txt";

        public static void GeneratePersonsInFile(IEnumerable<Person> people)
        {
            try
            {
                var fs = new FileStream(TxtSourcePath, FileMode.OpenOrCreate, FileAccess.Write);
                using (var sw = new StreamWriter(fs))
                {
                    foreach (var item in people)
                        sw.WriteLine(item);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            
        }
        public static void ReadFromFile()
        {
            try
            {
                const string path = "People.txt";
                _readText = File.ReadAllLines(path);
                foreach (var s in _readText)
                {
                    Console.WriteLine(s);
                }
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }

        public static int SelectUser()
        {
            Console.WriteLine("Select a User by pressing a number");
            int choose = 0;
            bool flag = true;
            while (flag)
            {
                if (int.TryParse(Console.ReadLine(), out choose) && choose >= 1 && choose <= 4)
                {
                    choose = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
            }
            return choose;
        }

        public static void GenerateInfoAboutUserInFile(Person person)
        {
            try
            {
                var fs = new FileStream(person.Name + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                using (var sw = new StreamWriter(fs))
                { 
                    sw.WriteLine(person);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e);
                throw;
            }
            
        }
        
        
    }
}

