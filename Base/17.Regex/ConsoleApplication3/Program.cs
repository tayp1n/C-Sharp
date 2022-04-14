using System;

namespace ConsoleApplication3
{
    public static class Program
    {
        public static void Main()
        {
            WorkingFiles workingFiles = new WorkingFiles();
            workingFiles.Start();
            workingFiles.SearchInFiles("hello");
        }
    }
}