using System;
namespace ConsoleApplication1
{
    public class EquilateralTriangle:GeometricFigure, ISimpleNSquare
    {
        private double[] _arr = new double[2];

        public EquilateralTriangle(int side)
        {
            _arr[0] = side;
        }
        public override double ShapeSquare()
        {
            return (Height * Height) / Math.Sqrt(3);
        }

        public override double ShapePerimeter()
        {
            return 3 * _arr[0];
        }

        public double Height => (_arr[0] * Math.Sqrt(3)) / 2;
        public double Base => _arr[0];
        public double BaseAdjacentSide => 60;
        public int NumberOfSides => 3;
        
        public double this[int index]
        {
            get => _arr[index];
            set => _arr[0] = value;
        }
       
    }
}