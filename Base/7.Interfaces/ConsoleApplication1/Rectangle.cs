using System;
namespace ConsoleApplication1
{
    public class Rectangle:GeometricFigure, ISimpleNSquare
    {
        private double[] _arr = new double[2];

        public Rectangle(int a, int b)
        {
            _arr[0] = a;
            _arr[1] = b;
        }
        public override double ShapeSquare()
        {
            return _arr[0] * _arr[1];
        }

        public override double ShapePerimeter()
        {
            return 2 * (_arr[0] + _arr[1]);
        }

        public double Height => ShapeSquare() / _arr[0];
        public double Base => _arr[0];
        public double BaseAdjacentSide => 90;
        public int NumberOfSides => 4;
        
        public double this[int index]
        {
            get => _arr[index];
            set => _arr[0] = _arr[1] = value;
        }
    }
}