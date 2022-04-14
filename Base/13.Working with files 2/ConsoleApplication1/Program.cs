using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    class Program
    {
        static long LengthOfDirectory(DirectoryInfo directoryName) {
            long sum = 0;
            try
            {
                FileInfo[] fi = directoryName.GetFiles();
                sum += fi.Sum(t => t.Length);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Not Found");
               
            }
            catch (UnauthorizedAccessException ) {
                Console.WriteLine("Not Found");
            }
            
            DirectoryInfo[] dim = directoryName.GetDirectories();
            if (dim.Length == 0) return sum;
            sum += dim.Sum(t => LengthOfDirectory(t));
            return sum;
            
        }
        static void Main(string[] args)
        {
            try
            {
                if (args[0] == null) return;
                DirectoryInfo di = new DirectoryInfo(args[0]);
                Console.WriteLine(LengthOfDirectory(di));
            }
            catch (IndexOutOfRangeException)
            {
               
            }
            
        }
        
    }
}