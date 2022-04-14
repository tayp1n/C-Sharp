using System;
namespace ConsoleApplication1
{
    public class CompoundFigure
    {
        private double result = 0;
        private GeometricFigure[] geoFigures { get; set; }
        public CompoundFigure(params GeometricFigure[] geoFigures)
        {
            this.geoFigures = geoFigures;
            PrintShow();
        }
        
        private double Area()
        {
            
            for (int i = 0; i < geoFigures.Length; i++)
            {
                result += geoFigures[i].ShapeSquare();
            }
            return result;

        }
        private void PrintShow()
        {
            Console.WriteLine($"Площадь составной фигуры {Area()} см2\n ");

        }
    }
}