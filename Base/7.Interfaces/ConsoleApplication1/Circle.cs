using System;
namespace ConsoleApplication1
{
    public class Circle:GeometricFigure, ISimpleNSquare
    {
        private double[] _arr = new double[1];

        public Circle(int radius)
        {
            _arr[0] = radius;
        }
        public override double ShapeSquare()
        {
            return 3.14 * (_arr[0] * _arr[0]);
        }

        public override double ShapePerimeter()
        {
            return 2 * (3.14 * _arr[0]);
        }

        public double Height => ShapeSquare() / _arr[0];
        public double Base => double.NaN;
        public double BaseAdjacentSide => double.NaN;
        public int NumberOfSides => 0;
        
        public double this[int index]
        {
            get => _arr[index];
            set => _arr[0] = value;
        }
    }
}