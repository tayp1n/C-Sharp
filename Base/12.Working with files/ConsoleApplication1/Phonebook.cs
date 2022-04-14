using System.IO;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;

namespace ConsoleApplication1
{
    public class Phonebook
    {
        private int _id;
        private string _name;
        private  string _surname;
        private  string _adress;
        private  int _phone;

        public Phonebook(int id, string name, string surname, string adress, int phone)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _adress = adress;
            _phone = phone;
        }

        protected Phonebook()
        {
            _id = 0;
            _name = null;
            _surname = null;
            _adress = null;
            _phone = 0;
        }

        public override string ToString()
        {
            return $"Id - {_id}\nName - {Name}\nSurname - {_surname}\nAdress - {_adress}\n" +
                   $"Phone - {_phone}\n";
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public string Adress
        {
            get => _adress;
            set => _adress = value;
        }

        public int Phone
        {
            get => _phone;
            set => _phone = value;
        }
    }
}