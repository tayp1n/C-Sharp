using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Truck : Car
    {
        public double BodyLength { get; set; }
        public Truck(int year, int weight, string color, double speed, double bodyLength) : base(year, weight, color, speed)
        {
            BodyLength = bodyLength;
        }

        public override void Info()
        {
            Console.WriteLine("Truck");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Weight: {Weight}\n" +
                              $"Color: {Color}\n" +
                              $"Speed: {Speed:0.00}");
            Console.WriteLine($"BodyLength: {BodyLength:0.00}\n");
        }
    }
}
