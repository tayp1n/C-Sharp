using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class AcademicMobility
    {
        public partial class InterProgram
        {
            public void Contest()
            {
                studentss.Sort(delegate (Student c1, Student c2) { return c1.Rating.CompareTo(c2.Rating); });
                foreach (var item in studentss)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
