using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApplication3
{
    public class WorkingFiles
    {
        public void Start()
        {
            Console.WriteLine("1. Find files and dir. by name, size, date of create, access and modification");
            Console.WriteLine("2. Content search in txt - files");
            //SearchBySize(685);
        }
        
        public static void SearchByName(string fileName) 
        {
            
            string[] allFoundFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), fileName, SearchOption.AllDirectories);
            int i = 1;
            try
            {
                if (allFoundFiles[0] == null) return;
                Console.WriteLine();
                foreach (var item in allFoundFiles)
                {

                    Console.WriteLine($"{i++} - {item}");
                }

                Console.WriteLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Not exist");
            }
        }
        
        public static void SearchBySize(int size)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(".");
                foreach (var directory in dir.GetDirectories())
                {
                    foreach (var dInfo in dir.GetFiles())
                    {
                        if (dInfo.Length/1024 == size)
                        {
                            Console.WriteLine($"{dInfo.CreationTime}  {dInfo.Length/1024}  {dInfo.Name,-50}");
                        }
                    }
                }
                foreach (var dInfo in dir.GetFiles())
                {
                    if (dInfo.Length/1024 == size)
                    {
                        Console.WriteLine($"{dInfo.CreationTime}  {dInfo.Length/1024}  {dInfo.Name,-50}");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not exist");
            }
        }
        
        public static void SearchByDate(DateTime dateTime) 
        {
            
            try
            {
                DirectoryInfo dir = new DirectoryInfo(".");
                foreach (var directory in dir.GetDirectories())
                {
                    foreach (var dInfo in dir.GetFiles())
                    {
                        if (dInfo.CreationTime == dateTime)
                        {
                            Console.WriteLine($"{dInfo.CreationTime}  {dInfo.Length/1024}  {dInfo.Name,-50}");
                        }
                    }
                }
                foreach (var dInfo in dir.GetFiles())
                {
                    if (dInfo.CreationTime == dateTime)
                    {
                        Console.WriteLine($"{dInfo.CreationTime}  {dInfo.Length/1024}  {dInfo.Name,-50}");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Not exist");
            }
        }
        
        
        public static void SearchByModification(string fileName) 
        {
            
            string[] allFoundFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), fileName, SearchOption.AllDirectories);
            int i = 1;
            try
            {
                if (allFoundFiles[0] == null) return;
                Console.WriteLine();
                foreach (var item in allFoundFiles)
                {

                    Console.WriteLine($"{i++} - {item}");
                }

                Console.WriteLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Not exist");
            }
        }

        public void SearchInFiles(string info)
        {
            var files = Directory.EnumerateFiles(".", "*txt", SearchOption.AllDirectories)
                .Where(f => File.ReadAllText(f).Contains(info));
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
