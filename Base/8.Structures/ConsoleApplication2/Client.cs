using System;
using System.Linq;

namespace ConsoleApplication2
{
    public struct Client
    {
        private int _clientCode;
        private string _fullName;
        private string _address;
        private int _phoneNumber;
        public int _numberOfOrders;
        //public Request[] _requests;
        
        public Request[] _requests;
        
        public Client(int clientCode, string fullName, string address, int phoneNumber/*, int numberOfOrders*/)
        {
            _clientCode = clientCode;
            _fullName = fullName;
            _address = address;
            _phoneNumber = phoneNumber;
            //_numberOfOrders = numberOfOrders;
            _requests = new Request[]{};
            _numberOfOrders = 0;
        }

        public void DoRequest(params RequestItem[] obj)
        {
            _numberOfOrders = obj.Length;
            _requests = new[] {  new Request(obj, this) };
            
            for (int i = 0; i < _requests.Length; i++)
            {
                _requests[i].PrintRequest();
            }
            /*for (var i = 0; i < obj.Length; i++)
            {
                _requests[i] = new Request(obj[i], this);
                _requests[i].PrintRequest();
            }*/
        }
        
        public int NumberOfOrders
        {
            get => _numberOfOrders;
        }
        public int CodeClient
        {
            set => _clientCode = value;
        }
        public string FullName
        {
            set => _fullName = value;
        }
        public int PhoneNumber
        {
            set => _phoneNumber = value;
        }
        public string Adress
        {
            set => _address = value;
        }

    }
}