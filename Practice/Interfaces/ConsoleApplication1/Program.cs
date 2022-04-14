using System;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleApplication1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            GeometricFigure[] arr = new GeometricFigure[2];
            arr[0] = new Square(4);
            arr[1] = new Circle(3);
            Console.WriteLine(arr[0].ShapeSquare());
            CompoundFigure figure = new CompoundFigure(arr);
           
            
        }
    }
}