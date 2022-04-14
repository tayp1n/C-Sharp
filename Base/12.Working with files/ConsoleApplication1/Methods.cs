using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    public class Methods
    {
        DoublyLinkedList<Phonebook> phonebooks = new DoublyLinkedList<Phonebook>();
        private int _i;
        public void Add(Phonebook phonebook)
        {
            phonebooks.Push_Back(phonebook);
        }

        public void Remove(Phonebook phonebook)
        {
           phonebooks.DeleteElement(phonebook);
        }

        public void Save()
        {
            using (StreamWriter streamWriter = new StreamWriter("Phonebook.txt", true, Encoding.Default))
            {
                phonebooks.Save(streamWriter);
            }
        }

        public void Edit(Phonebook phonebook)
        {
            phonebooks.Edit(phonebook);
        }

        public void Print()
        {
            phonebooks.Print();
        }
       
    }
}