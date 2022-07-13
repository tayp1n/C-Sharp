using System;

namespace ConsoleApp1
{
    internal class Person
    {
        public string Name {get;}
        private int _age;

        private int _numberOfSteps;
        private int _caloriesBurned;
        private int _pulse;
        private double _respiratoryRate;
        private int _destination;
        private string _exerciseRecommendations;

        public readonly Goal Goal;
        private readonly Random _rand = new Random();

        public void GetDataAboutPerson()
        {
            object[] arrayOfObjects = {_numberOfSteps,_caloriesBurned,_pulse,_respiratoryRate,_destination,_exerciseRecommendations, Name};
            Data.ArrayOfObjects = arrayOfObjects;
            DataStruct.ArrayOfObjects = new[]
            {
                "Number of steps: ",
                "Calories Burned: ",
                "Pulse: ",
                "Respiratory Rate: ",
                "Destination: ",
                "Exercise Recommendations: "
            };

            //Array.Copy(arrayOfObjects, _data.ArrayOfObjects,7);
        }
        public Person(string name, int age, Phone phone)
        {
            Name = name;
            _age = age;
            Phone = phone;
            Goal = new Goal();
           
        }
        
        public Phone Phone { get; }

        public override string ToString()
        {
            return "Name: " + Name + ", " + "Age: " + _age + ", "+ "Phone model: " + Phone.Model;
        }
        public void SetGoal()
        {
            Console.WriteLine("Please select your goal: ");
            Goal.SelectGoal();            
        }

        public void Move()
        {
            Console.CursorVisible = false;
            var flag = true;
            while (flag)
            {
                if (Console.KeyAvailable)
                {
                    var consoleKey = Console.ReadKey(true).Key;
                    switch (consoleKey)
                    {
                        case ConsoleKey.A:
                            Console.Clear();
                            _numberOfSteps--;
                            Console.Write("Steps: " + _numberOfSteps);
                            break;
                        case ConsoleKey.D:
                            Console.Clear();
                            _numberOfSteps++;
                            Console.Write("Steps: " + _numberOfSteps);
                            break;
                        default:
                            flag = false;
                            break;
                    }
                }
            }
            switch (Goal._goal)
            {
                case "Walk":
                    _caloriesBurned = _numberOfSteps / 50;
                    _pulse = _rand.Next(100, 120);
                    _respiratoryRate = _rand.NextDouble() * (30.5 - 40.6) + 30.5;
                    _destination = (_destination - _numberOfSteps);
                    break;
                case "Running":
                    _caloriesBurned = _numberOfSteps / 70;
                    _pulse = _rand.Next(120, 150);
                    _respiratoryRate = _rand.NextDouble() * (40.5 - 50.6) + 20.5;
                    _destination = (_destination - _numberOfSteps);
                    break;
                default:
                    _caloriesBurned = _numberOfSteps / 70;
                    _pulse = _rand.Next(110, 150);
                    _respiratoryRate = _rand.NextDouble() * (50.5 - 60.6) + 20.5;
                    _destination = (_destination - _numberOfSteps);
                    break;
            }
        }
    }
}
