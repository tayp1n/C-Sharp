using System;
using System.IO;


namespace ConsoleApplication1
{
    static class MyConsole
    {
        

        public static void Cls() {
            Console.Clear();
        }

        public static void Dir() {
            DirectoryInfo dir = new DirectoryInfo(".");
            foreach (var directory in dir.GetDirectories())
            {
                Console.WriteLine($"{directory.CreationTime}  {directory.Name,-50} DIR");
            }
            foreach (var dInfo in dir.GetFiles())
            {
                Console.WriteLine($"{dInfo.CreationTime}  {dInfo.Length}  {dInfo.Name,-50}");
            }
        }

        public static void Cd(string path)
        {
            try
            {
                if (path == "..")
                    Directory.SetCurrentDirectory(Directory.GetCurrentDirectory());
                Directory.SetCurrentDirectory(path);
            }
            catch (Exception)
            {
                Console.WriteLine("Not Found directory");
            }

        }


        public static void Copy(FileInfo file) {
            File.Copy(file.Name, File.Create(file.Name).Name);   
        }

        public static void Del(FileInfo file) {
            File.Delete(file.Name);
        }

        public static void Mkdir(string dirName) {
            Directory.CreateDirectory(dirName);
        }
        
        public static void help() {
            Console.WriteLine("cls - clear console");
            Console.WriteLine("dir - display a list of files");
            Console.WriteLine("cd - view or change the path of the directory");
            Console.WriteLine("copy - copy one or more files");
            Console.WriteLine("del - delete one or more files");
            Console.WriteLine("mkdir - create directories");
        }
    }
}
