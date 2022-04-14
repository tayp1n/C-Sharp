using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;

namespace ConsoleApplication1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Phonebook phonebook = new Phonebook(12134, "Vasya",
                "Nikityok", "st.246", 09888324);
            Phonebook phonebook2 = new Phonebook(12135, "Vasya",
                "Nikityok", "st.246", 09888324);
            Phonebook phonebook3 = new Phonebook(12136, "Vasya",
                "Nikityok", "st.246", 09888324);
            Phonebook phonebook4 = new Phonebook(12137, "Vasya",
                "Nikityok", "st.246", 09888324);

            Methods methods = new Methods();
            
            methods.Add(phonebook);
            methods.Add(phonebook2);
            methods.Add(phonebook3);
            methods.Add(phonebook4);
            
            methods.Remove(phonebook3);
            methods.Edit(phonebook4);
           
            
            methods.Print();
            methods.Save();


        }
    }

}