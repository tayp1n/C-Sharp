using System;
namespace ConsoleApplication1
{
    public class Square:GeometricFigure, ISimpleNSquare
    {
        
        private double[] _arr = new double[4];

        public Square(int value)
        {
            _arr[0] = _arr[1] = _arr[2] = _arr[3] = value;
        }
        public override double ShapeSquare()
        {
            return _arr[0] * _arr[1];
        }

        public override double ShapePerimeter()
        {
            return Math.Pow(_arr[0], 4);
        }

        public double Height => _arr[1];
        public double Base => _arr[0];
        public double BaseAdjacentSide => 90;
        public int NumberOfSides => 4;
        
        public double this[int index]
        {
            get => _arr[index];
            set => _arr[0] = _arr[1] = _arr[2] = _arr[3] = value;
        }
    }
}