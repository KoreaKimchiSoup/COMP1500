using System;

namespace Lab10
{
    public class Rectangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }

        uint Perimeter;
        uint Area;

        public Rectangle(uint width, uint height)
        {
            Width = width;
            Height = height;
            Area = width * height;
            Perimeter = 2 * (width + height);
        }

        public uint GetPerimeter()
        {
            return Perimeter;
        }
        public uint GetArea()
        {
            return Area;
        }
    }
}
