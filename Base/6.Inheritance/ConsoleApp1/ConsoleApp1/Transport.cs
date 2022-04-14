using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Transport
    {
        public int Year { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Transport() { }
       
        public Transport(int year, int weight, string color)
        {
            Year = year;
            Weight = weight;
            Color = color;
        }

        public abstract void Info();
    }
}
