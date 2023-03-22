using System;

namespace Lab10
{
    public class RightTriangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }

        double Perimeter;
        double Area;
        double ThirdSide;

        public RightTriangle(uint width, uint height)
        {
            Width = width;
            Height = height;
            Area = Math.Round(width * (double)height / 2, 3);
            ThirdSide = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            Perimeter = width + height + ThirdSide;
        }

        public double GetPerimeter()
        {
            return Perimeter;
        }

        public double GetArea()
        {
            return Area;
        }
    }
}
