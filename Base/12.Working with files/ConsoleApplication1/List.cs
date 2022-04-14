using System;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApplication1
{
    public class DoublyLinkedList<T>
    {
        private Node _first;
        private Node _current;
        private Node _last;
        private uint _size;

        public DoublyLinkedList()
        {
            _size = 0;
            _first = _current = _last = null;
        }

        private bool IsEmpty //проверка на пустоту
        {
            get
            {
                return _size == 0;
            }
        }

        public void Insert_Index(Phonebook newElement, uint index) //вставить по индекусу
        {
            if (index < 1 || index > _size) //вброс ошибки, если неправильный индекс
            {
                throw new InvalidOperationException();
            }
            else if (index == 1) //если начало
            {
                Push_Front(newElement);
            }
            else if (index == _size) //если конец
            {
                Push_Back(newElement);
            }
            else //иначе ищем элемент с таким индексом
            {
                uint count = 1;
                _current = _first;
                while (_current != null && count != index)
                {
                    _current = _current.Next;
                    count++;
                }
                Node newNode = new Node(newElement); //создаем объект
                if (_current == null) return;
                _current.Prev.Next = newNode;
                newNode.Prev = _current.Prev;
                _current.Prev = newNode;
                newNode.Next = _current;
            }
        }

        private void Push_Front(Phonebook newElement)
        {
            Node newNode=new Node(newElement);

            if (_first == null)
            {
                _first = _last = newNode;
            }
            else
            {
                newNode.Next = _first; 
                _first = newNode; //First и newNode указывают на один и тот же объект
                newNode.Next.Prev = _first;
            }
            Count++;
        }

        private Node Pop_Front()
        {
            if (_first == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Node temp = _first;
                if (_first.Next != null)
                {
                    _first.Next.Prev = null;
                }
                _first = _first.Next;
                Count--;
                return temp;
            }
        }

        public void Push_Back(Phonebook newElement)
        {
            Node newNode = new Node(newElement);

            if (_first == null)
            {
                _first = _last = newNode;
            }
            else
            {
                _last.Next = newNode;
                newNode.Prev = _last;
                _last = newNode;
            }
            Count++;
        }
        
        public void ClearList() //полностью очистить список
        {
            while (!IsEmpty)
            {
                Pop_Front();
            }
        }

        public uint Count //свойство для size
        {
            get { return _size; }
            set { _size = value; }
        }
        
        public void DeleteElement(Phonebook obj)
        {
            var temp = _first;
            if (_size == 1)
            {
                temp.Next = null;
                temp.Prev = null;
                _first = null;
                _last = null;
                _size = 0;
            }
            while (temp != null)
            {
                if (temp.Next == null)
                {
                    temp.Prev = null;
                    _last = temp.Prev;
                    _size--;
                    return;
                }
                if (temp.Obj.ToString() == obj.ToString())
                {
                    if (temp.Prev != null)
                    {
                        temp.Prev.Next = temp.Next;
                        temp.Next.Prev = temp.Prev;
                    }
                    return;
                }
              
                temp = temp.Next;
            }
            _size--;
        }

        public void Edit(Phonebook obj)
        {
            var temp = _first;   
            
            while (temp != null)
            {
                if (temp.Obj.ToString() == obj.ToString())
                {
                    Console.WriteLine("Input ID");
                    int id = Convert.ToInt32(Console.ReadLine());
                    temp.Id = id;
                    Console.WriteLine("Input Name");
                    string name = Console.ReadLine();
                    temp.Name = name;
                    Console.WriteLine("Input SurName");
                    string surname = Console.ReadLine();
                    temp.Surname = surname;
                    Console.WriteLine("Input Adress");
                    string adress = Console.ReadLine();
                    temp.Adress = adress;
                    Console.WriteLine("Input Phone");
                    int phone = Convert.ToInt32(Console.ReadLine());
                    temp.Phone = phone;
                }

                temp = temp.Next;

            }
        }
        
        public void Save(StreamWriter streamWriter)
        {
            var temp = _first;
            while (temp != null)
            {
                streamWriter.WriteLine(temp.Obj);
                temp = temp.Next;
            }
        }
        
        public void Print()
        {
            Console.Clear();
            var temp = _first;
            while (temp != null)
            {
                Console.WriteLine(temp.Obj);
                temp = temp.Next;
            }
        }

    }
}