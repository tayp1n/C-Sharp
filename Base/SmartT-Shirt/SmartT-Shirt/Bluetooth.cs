using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bluetooth
    {
        private Random _random = new Random();
        private bool _sconnection;
        private int _success;
        
        public bool Connect(Phone phone)
        {
            Console.WriteLine("Connection in process.....");
            phone.BluetoothOn = true;
            
            _success = _random.Next(0, 2);
            if (_success == 1)
            {
                ConnectedWith = phone.Model;
                Speed = _random.NextDouble() * (50 - 20) + 20;
                return _sconnection = true;
            }
            Console.WriteLine("Connection failed");
            System.Threading.Thread.Sleep(2000);
            return _sconnection;
        }
        public string ConnectedWith { get; private set; }

        public double Speed { get; private set; }
    }
}
