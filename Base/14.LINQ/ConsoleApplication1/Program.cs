using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Func(int[]arr)
        {

            string result = string.Join("", arr);
            var intList = result.Select(digit => int.Parse(digit.ToString()));
            Console.WriteLine(result);
            
            var res = from i in intList
                select i;
            foreach (var item in res)
            {
                Console.Write($"{item} ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {123, 65, 213, 7};
            Func(arr);
        }
    }
}