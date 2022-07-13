using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SmartTShirt: ITShirtFunctional
    {
        private Person[] _people = new Person[4];
        private int _choose;
        private readonly Bluetooth _bluetooth;
        private readonly Software _software;
        private readonly Sensors _sensors;
        private static Battery _battery;
        private SmartDiagnostician _smartDiagnostician;
        
        public SmartTShirt()
        {
            _bluetooth = new Bluetooth();
            _software = new Software();
            _sensors = new Sensors();
            _battery = new Battery();
            _smartDiagnostician = new SmartDiagnostician();
        }
        public void Start(Person [] people) // початок програми
        {
            _people = people;
            Console.WriteLine("Hello! I'm smart T-Shirt. To start use me you need to connect your phone with bluetooth \n");
            Software.ReadFromFile();
            _choose = Software.SelectUser();
            
            Console.Clear();
            
            while (_bluetooth.Connect(_people[_choose].Phone) == false)
            {
                _bluetooth.Connect(_people[_choose].Phone);
            }
            
            Console.Clear();
            
            Console.WriteLine($"Success: Phone model {_bluetooth.ConnectedWith}, speed {_bluetooth.Speed}");
            
            _people[_choose].Move();
        }

        void ITShirtFunctional.Generate() // запис всіх людей до файлу
        {
            Software.GeneratePersonsInFile(_people);
        }
        void ITShirtFunctional.Read() // читання людей з файлу
        {
            Software.ReadFromFile();
        }
        void ITShirtFunctional.GenerateInfoInFile() //генерація даних людини до файлу (прізвище, вік т.д)
        {
            Software.GenerateInfoAboutUserInFile(_people[_choose]);
        }

        public void WriteDataToFileAboutPerson() // запис характеристик до "хмари"
        {
            _people[_choose].SetGoal();
            _people[_choose].GetDataAboutPerson();
            Sensors.WriteDataToFile();
        }

        public void AnalyseData() //аналіз даних з текстового файлу(емуляція хмари)
        {
            //SmartDiagnostician.AnalyseData(_people[_choose].Goal._goal);
            _smartDiagnostician.AnalyseDataEvent += Notify.NotifyAboutIll;
        }

        public static async Task InfoAboutBattery() // заряд батереї 
        {
            await Task.Run(() =>
            {
                for (var i = 0; i < 100; i++)
                {
                    Console.WriteLine(_battery.Charge--);
                    Task.Delay(5000).Wait();
                }
                Console.Clear();
                Console.WriteLine("Attention! Discharged!");
            });
        }
    }
}
