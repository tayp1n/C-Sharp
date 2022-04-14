using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

using Wonders;
using USA;
using UnitedKingdom;
using France;

namespace ConsoleApp1
{
    class Program
    {
        
        public interface ICity
        {
            double getPopulation();
        }
        static void Main(string[] args)
        {

            Wonders.HangingGardensOfBabylon.ShowWonder();
            Wonders.GreatPyramidOfGiza.ShowWonder();
            Wonders.StatueOfZeus.ShowWonder();
            Wonders.TempleOfArtemisAtEphesus.ShowWonder();
            Wonders.MausoleumAtHalicarnassus.ShowWonder();
            Wonders.ColossusOfRhodes.ShowWonder();
            Wonders.LighthouseOfAlexandria.ShowWonder();
            //2

            London l = new London();
            Washington w = new Washington();
            Paris p = new Paris();

            var arr = new ICity[3] { w, l, p };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].getPopulation() < arr[j].getPopulation())
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            WriteLine($"First: {arr[0].getPopulation()}, Second: {arr[1].getPopulation()}, Third: {arr[2].getPopulation()}");
        }

    }
}
