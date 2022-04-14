using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using static System.Console;
using System.Collections.Specialized;

namespace ConsoleApplication1
{
    internal static class Program
    {

        static void Main(string[] args)
        {
            StringDictionary stringDictionary = new StringDictionary();
            bool stop = false;
            int choose = 0;
            
            stringDictionary.Add("Dog", "Собака");
            stringDictionary.Add("Cat", "Кошка");
           
            stringDictionary.Add("Собака", "Dog");
            stringDictionary.Add("Кошка", "Cat");

            while (stop != true)
            {
                choose = Convert.ToInt32(Console.ReadLine());
                
                switch (choose)
                {
                    case 1:
                        WriteLine("Input word for translate: ");
                        string wordEng = ReadLine();
                        if (stringDictionary.ContainsKey(wordEng ?? throw new InvalidOperationException()))
                            Console.WriteLine(stringDictionary[wordEng]);
                        else
                            Console.WriteLine( "The collection does not contain the key" );
                        Console.WriteLine();
                        
                        break;
                    case 2:
                        WriteLine("Введите слово для перевода: ");
                        string wordRus = ReadLine();
                        if (stringDictionary.ContainsKey(wordRus ?? throw new InvalidOperationException()))
                            Console.WriteLine(stringDictionary[wordRus]);
                        else
                            Console.WriteLine( "The collection does not contain the key" );
                        Console.WriteLine();
                        
                        break;
                    default:
                        stop = true;
                        break;
                }
            }
            
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            WriteLine("Input sentence: ");
            
            string sentence = ReadLine();
            string[] strings = sentence?.Split(' ');

            if (strings != null)
                foreach (var t in strings)
                {
                    if (!dictionary.ContainsKey(t))
                    {
                        dictionary.Add(t, 1);
                    }
                    else
                    {
                        dictionary[t]++;
                    }
                }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            
        }

        
    }

}