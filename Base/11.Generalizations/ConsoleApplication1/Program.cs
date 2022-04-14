using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using static System.Console;

namespace ConsoleApplication1
{
    internal static class Program
    {

        static void Main(string[] args)
        {

            ListNode<string>[] arr = new ListNode<string>[]
            {
                new ListNode<string>("1"),
                new ListNode<string>("2"),
                new ListNode<string>("3")
            };
            var list = new List<string>();
            list.Add("Hello");
            list.Add("Hello2");
            list.Add("Hello3");
            list.Add("Hello4");
            list.RemoveArray(1,3);
            list.Print();
        }

    }

}