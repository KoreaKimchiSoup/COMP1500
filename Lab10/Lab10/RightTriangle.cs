using System;

namespace Lab10
{
    public class RightTriangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }

        public uint perimeter;
        public uint area;
        public uint thirdSide;


        public RightTriangle(uint width, uint height)
        {
            Width = width;
            Height = height;
            thirdSide = width ^ 2 * height ^ 2;
            area = width * height / 2;
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
