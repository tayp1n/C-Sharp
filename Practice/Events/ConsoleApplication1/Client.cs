using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;
namespace ConsoleApplication1
{
    public class Client:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _id = 0;
        private int _passport = 0;
        
        
        public int Id 
        { 
            get { return _id; }
            set
            {

                _id = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Id"));

            }
        }
        public int Password 
        { 
            get { return _passport; }
            set
            {

                _passport = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Passport"));

            }
        }
        
       
        public void sample_PropertyChanged_FN(object sender, PropertyChangedEventArgs e)
        {
            Client sample = (Client) sender;
            Console.WriteLine("\nId name of property {0} was changed! New value is {1}", e.PropertyName,
                sample._id);
        }

        public void sample_PropertyChanged_SN(object sender, PropertyChangedEventArgs e)
        {
            Client sample = (Client) sender;
            Console.WriteLine("Passport of property {0} was changed! New value is {1}", e.PropertyName, sample._passport);
        }

        public void AuthorEvent()
        {
            Console.WriteLine("1: Rename ID");
            Console.WriteLine("2: Rename Passport\n");
            while (true)
            {
                string i = Console.ReadLine();
                
                switch (i)
                {
                    case "1":
                        Console.Clear();
                        int str1 = Convert.ToInt32(Console.ReadLine());
                        Id = str1;
                        Console.Write("\n");
                        break;
                    case "2":
                        Console.Clear();
                        int str2 = Convert.ToInt32(Console.ReadLine());
                        Password = str2;
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