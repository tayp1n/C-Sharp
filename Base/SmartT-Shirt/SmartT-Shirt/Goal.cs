using System;

namespace ConsoleApp1
{
    public class Goal
    {
        private readonly bool[] _goals;
        private readonly string[] _goalsNames;
        private const int Size = 3;
        public string _goal { get; private set; }
        

        public Goal()
        {
            const bool swimming = false;
            const bool walk = false;
            const bool running = false;
            _goals = new bool[Size]{swimming,walk,running};
            _goalsNames = new string[Size] {"Swimming", "Walk", "Running"};
        }

        public void SelectGoal()
        {
            bool flag = true;
            foreach (var item in _goalsNames)
            {
                Console.WriteLine(item);
            }
            var temp = Convert.ToInt32(Console.ReadLine());

            while (flag)
            {
                if (int.TryParse(Console.ReadLine(), out temp) && temp >= 1 && temp <= 3)
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
            }
            _goals[temp] = true;
            _goal = _goalsNames[temp];
        }
    }
}