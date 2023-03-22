using System;

namespace Lab10
{
    public class Rectangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }

        uint perimeter;
        uint area;

        public Rectangle(uint width, uint height)
        {
            Width = width;
            Height = height;
            area = width * height;
            perimeter = 2 * (width + height);
        }

        public uint GetPerimeter()
        {
            return perimeter;
        }
        public uint GetArea()
        {
            return area;
        }
    }
}
