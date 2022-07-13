using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class SmartDiagnostician
    {
        public delegate void AnalyseDataHandler(int type);
        public event AnalyseDataHandler AnalyseDataEvent;
        static double[] doubles = {};

        public static void ReadData()
        {
            var  lines = new ReverseLineReader(Data.ArrayOfObjects[6] + ".txt");
            var last = lines.Take(1);
            foreach (var s in last)
            {
                doubles = Regex.Matches(s, "\\d+(\\,\\d+)?")
                    .Cast<Match>()
                    .Select(x => double.Parse(x.Value))
                    .ToArray();
            }
            
        }
        protected virtual void AnalyseData(string goal)
        {
            
            if (doubles[2] > 41 && goal == "Running")
                //Console.WriteLine("Attention! Your Pulse is bad. Possible Heart attack ");
                AnalyseDataEvent?.Invoke(1);
            if (doubles[3] > 19.9 && goal == "Walk")
                //Console.WriteLine("Attention! Get some rest");
                AnalyseDataEvent?.Invoke(2);
            if (doubles[4] > -30 && goal == "Swimming")
               // Console.WriteLine("Attention! Just go");
                AnalyseDataEvent?.Invoke(3);
        
        }
    }
}