using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    public class List<T>//: IEnumerable<T>
    {
        private ListNode<T> _head;
        private ListNode<T> _tail;
        private int _count;
       

        public void Add(T data)
        {
            
            var node = new ListNode<T>(data);
            if (_head == null)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;
                node.Previous = _tail;
            }

            _tail = node;
            _count++;
            
        }

        public void AddFirst(T data)
        {
            
            var node = new ListNode<T>(data);
            if (_count == 0)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                node.Next = _head;
                _head.Previous = node;
                _head = node;
            }
            
            _count++;

        }

        public void AddLast(T data)
        {
            var node = new ListNode<T>(data);
            
            if (_count == 0)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                node.Previous = _tail;
                _tail = node;
            }
            _count++;
        }
        
        public void AddD(ListNode<T>[] arr, int pos)
        {
            var temp = _head;
            int length = arr.Length;

            try
            {
                for (int i = 0; i < length - 1; i++)
                {
                    arr[i].Next = arr[i + 1];
                }
            }
            catch
            {
                // ignored
            }

            try
            {
                for (int i = length - 1; i >= 0; i--)
                {
                    arr[i].Previous = arr[i - 1];
                }
            }
            catch
            {
                // ignored
            }
            
            if (_count == 0)
            {
                _head = arr[0];
                _tail = arr[length - 1];
                _count += length;
                return;
            }

            if (pos == 1 && temp.Previous == null)
            {
                arr[length].Next = _head;
                _head = arr[0];
                _count += length;
                return;
            }
            
            if (pos >= _count)
            {
                arr[0].Previous = _tail;
                _tail.Next = arr[0];
                _tail = arr[length - 1];
                _count += length;
                return;
            }

            try
            {
                for (int i = 0; i < pos - 1; i++)
                    temp = temp.Next;
            }
            catch
            {
                // ignored
            }
            
            arr[0].Previous = temp;
            arr[length - 1].Next = temp.Next;
            temp.Next.Previous = arr[length - 1];
            temp.Next = arr[0];
            _count += length;

        }

        public void RemoveArray(int count, int pos)
        {
            if (_count == 0)
            {
                Console.WriteLine("Count == 0");
            }

            
            if (_count - count == 1)
            {
                var temp = _head;
                temp.Next = null;
                _tail = temp;
                _count = 1;
                return;
            }

            if (count >= _count)
            {
                var temp2 = _head;
                for (int i = 0; i < pos - 1; i++)
                {
                    temp2 = temp2.Next;
                }

                temp2.Next = null;
                _count -= (_count - pos);
                return;
            }
            var t = _head;
            for (int i = 0; i < pos - 1; i++)
            {
                t = t.Next;

            }
            var t2 = _head;
            for (int i = 0; i < pos + count; i++)
            {
                t2 = t2.Next;
            }

            try
            {
                t.Next = t2;
                _count = (_count - count);
                t2.Previous = t;
            }
            catch
            {
                t.Next = null;
            }
            
        }
        
            public void AddPos(T data, int pos)
        {
            var node = new ListNode<T>(data);
            var temp = _head;
            if (_count == 0)
            {
                _head = node;
                _tail = node;
                _count++;
                return;
            }

            if (pos == 1 && temp.Previous == null)
            {
                node.Next = _head;
                _head = node;
                _count++;
                return;
            }

            try
            {
                for (int i = 0; i < pos - 1; i++)
                    temp = temp.Next;
            }
            catch
            {
                node.Previous = _tail;
                _tail.Next = node;
                _tail = node;
                _count++;
                return;
            }

            if (pos >= _count)
            {
                node.Previous = _tail;
                _tail.Next = node;
                _tail = node;
                _count++;
                return;
            }

            if (pos - 1 == _count)
            {
                temp.Previous.Next = node;
                node.Next = temp.Next;
                node.Previous = temp.Previous;
                _count++;
                return;
            }
            
            temp.Previous.Next = node;
            temp.Next.Previous = node;
            node.Next = temp;
            node.Previous = temp.Previous;
            _count++;
            
        }
        
        public void Remove(int pos)
        {
            if (_count == 0)
            {
                return;
            }
            
            if(pos == 1 && _head == _tail)
            {
                _head.Next = null;
                _head = null;
                _count = 0;
                return;
            }
            
            if (pos == 1 && _head.Next != null)
            {
                var tempPos1Else = _head;
                _head = _head.Next;
                _head.Previous = null;
                _count--;
                return;
            }
            
            if (pos == _count)
            {
                var tempPosLast = _tail;
                _tail = _tail.Previous;
                _tail.Next = null;
                _count--;
                return;
            }
            
            
            var tempMiddle = _head;
            ListNode<T> tempMiddle2;
            for (int i = 0; i < pos - 1; i++)
            {
                tempMiddle = tempMiddle.Next;
            }

            tempMiddle2 = tempMiddle;
            tempMiddle2.Previous.Next = tempMiddle.Next;
            tempMiddle2.Next.Previous = tempMiddle.Previous;
            _count--;
        }

        public void RemoveFirst()
        {
            if (_count == 0)
            {
                Console.WriteLine("Count = 0");
            }

            if (_count == 1)
            {
                _head.Next = null;
                _head = null;
                _count = 0;
                return;
            }

            if (_head.Next != null)
            {
                var tempPos1Else = _head;
                _head = _head.Next;
                _head.Previous = null;
                _count--;
            }
            
        }

        public void RemoveLast()
        {
            if (_count == 0)
            {
                Console.WriteLine("Count == 0");
            }

            if (_count == 1)
            {
                _head.Next = null;
                _head = null;
                _count = 0;
                return;
            }

            if (_tail.Next == null)
            {
                _tail = _tail.Previous;
                _tail.Next = null;
                _count--;
                return;
            }
            
        }
        
        public void Print()
        {
            var temp = _head;
            while (temp != null)
            {
                Console.WriteLine(temp.Obj);
                temp = temp.Next;
            }
        }
        
        /*public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }*/
    }
}