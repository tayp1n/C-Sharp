using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new Payment(100.5 , 50.7, 20.9, 10.0, true);
            Console.WriteLine(payment);
            
            var bf = new BinaryFormatter();
            using (var fs = File.Create("Person.bin"))
            {
                bf.Serialize(fs, payment);
            }
            try
            {
                Payment copy = null;
                using (var fs = File.OpenRead("Person.bin"))
                {
                    copy = (Payment)bf.Deserialize(fs);
                }

                Console.WriteLine(copy);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                
            }
        }
        
    }
}