using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
namespace UnitedKingdom
{
    public class London : Program.ICity
    {
        public double Population { get; set; }
        public London() => Population = 8900000;
        public London(double population) => Population = population;
        public double getPopulation()
        {
            return Population;
        }
        
    }
}
