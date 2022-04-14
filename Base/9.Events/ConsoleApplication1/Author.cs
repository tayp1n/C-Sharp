
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConsoleApplication1
{
    public class Author : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _firstName = "Unknown";
        private string _surName = "Unknown";

        public string FirstName
        {
            get { return _firstName; }
            set
            {

                _firstName = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));

            }
        }

        public string SurName
        {
            get { return _surName; }
            set
            {

                _surName = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SurName"));

            }
        }

        public void sample_PropertyChanged_FN(object sender, PropertyChangedEventArgs e)
        {
            Author sample = (Author) sender;
            Console.WriteLine("\nFirst name of property {0} was changed! New value is {1}", e.PropertyName,
                sample._firstName);
        }

        public void sample_PropertyChanged_SN(object sender, PropertyChangedEventArgs e)
        {
            Author sample = (Author) sender;
            Console.WriteLine("Surname of property {0} was changed! New value is {1}", e.PropertyName, sample._surName);
        }

        public void AuthorEvent()
        {
            Console.WriteLine("1: Rename FirstName");
            Console.WriteLine("2: Rename SurName\n");
            while (true)
            {
                string i = Console.ReadLine();
                
                    switch (i)
                        {
                            case "1":
                                Console.Clear();
                                string str1 = Console.ReadLine();
                                FirstName = str1;
                                Console.Write("\n");
                                break;
                            case "2":
                                Console.Clear();
                                string str2 = Console.ReadLine();
                                SurName = str2;
                                Console.Write("\n");
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Error!");
                                break;
                        }
                
                
            }

        }
    }
}