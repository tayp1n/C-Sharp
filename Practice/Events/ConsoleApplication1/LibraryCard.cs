using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;
namespace ConsoleApplication1
{
    public class LibraryCard:INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler PropertyChanged;
        private int _numberCard = 0;
        
        public int NumberCard
        {
            get { return _numberCard; }
            set
            {

                _numberCard = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("NumberCard"));

            }
        }
        public void sample_PropertyChanged_FN(object sender, PropertyChangedEventArgs e)
        {
            LibraryCard sample = (LibraryCard) sender;
            Console.WriteLine("\nNumber of card of property {0} was changed! New value is {1}", e.PropertyName,
                sample._numberCard);
        }
        public void AuthorEvent()
        {
            Console.WriteLine("1: Rename Card number\n");
            while (true)
            {
                string i = Console.ReadLine();
                
                switch (i)
                {
                    case "1":
                        Console.Clear();
                        int str1 = Convert.ToInt32(Console.ReadLine());
                        NumberCard = str1;
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