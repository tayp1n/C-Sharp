using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Phone
    {
        public string Model;
        public string Password;
        public bool BluetoothOn;
        public Phone(string model, string password)
        {
            Model = model;
            Password = password;
        }
    } 
}
