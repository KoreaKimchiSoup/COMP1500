using System;

namespace Lab10
{
    public class RightTriangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }

        double perimeter;
        double area;
        double thirdSide;

        public RightTriangle(uint width, uint height)
        {
            Width = width;
            Height = height;
            area = width * height / 2;
            thirdSide = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            thirdSide = Math.Round(thirdSide, 3);
            perimeter = width + height + thirdSide;
        }

        public double GetPerimeter()
        {
            return perimeter;
        }

        public double GetArea()
        {
            return area;
        }
    }
}
