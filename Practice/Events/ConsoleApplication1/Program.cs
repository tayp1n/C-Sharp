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
            Author sample = new Author();
            sample.PropertyChanged += new PropertyChangedEventHandler(sample.sample_PropertyChanged_FN);
            sample.PropertyChanged += new PropertyChangedEventHandler(sample.sample_PropertyChanged_SN);
            sample.AuthorEvent();

        }
    }

}