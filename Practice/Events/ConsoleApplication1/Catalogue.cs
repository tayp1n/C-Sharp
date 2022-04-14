using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;
namespace ConsoleApplication1
{
    public class Catalogue:INotifyPropertyChanged
    {
        public string _title = "Unknown";

        public event PropertyChangedEventHandler PropertyChanged;
        public string Title
        {
            get { return _title; }
            set
            {

                _title = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Title"));

            }
        }
        public void sample_PropertyChanged_FN(object sender, PropertyChangedEventArgs e)
        {
            Catalogue sample = (Catalogue) sender;
            Console.WriteLine("\nTitle of card of property {0} was changed! New value is {1}", e.PropertyName,
                sample._title);
        }
        public void AuthorEvent()
        {
            Console.WriteLine("1: Rename Title\n");
            while (true)
            {
                string i = Console.ReadLine();
                
                switch (i)
                {
                    case "1":
                        Console.Clear();
                        string str1 = Console.ReadLine();
                        Title = str1;
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