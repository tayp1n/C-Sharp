using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
namespace USA
{
    public class Washington : Program.ICity
    {
        public double Population { get; set; }
        public Washington() => Population = 7600000;
        public Washington(int population) => Population = population;
        public double getPopulation()
        {
            return Population;
        }
    }
}
