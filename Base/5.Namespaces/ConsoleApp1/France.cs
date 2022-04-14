using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
namespace France
{
    public class Paris : Program.ICity
    {
        public double Population { get; set; }
        public Paris() => Population = 2161000;
        public Paris(int population) => Population = population;
        public double getPopulation()
        {
            return Population;
        }

    }
}
