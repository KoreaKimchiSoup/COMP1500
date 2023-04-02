using System;

namespace Lab10
{
    public class Rectangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }

        public uint perimeter;
        public uint area;

        public Rectangle(uint width, uint height)
        {
            Width = width;
            Height = height;
            perimeter = 2 * (width + height);
            area = width * height;
        }

        public uint GetPerimeter() // 둘레반환
        {
            return perimeter;
        }

        public uint GetArea() // 면적 반환
        {
            return area;
        }
    }
}
