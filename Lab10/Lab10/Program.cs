using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 2);
            Console.WriteLine(rectangle.Width);
            Console.WriteLine(rectangle.Height);
            Console.WriteLine(rectangle.GetPerimeter());
            Console.WriteLine(rectangle.GetArea());

            Console.WriteLine("-------------------------");

            RightTriangle triangle = new RightTriangle(3, 2);
            Console.WriteLine(triangle.Width);
            Console.WriteLine(triangle.Height);
            Console.WriteLine(triangle.GetPerimeter()); // 8.606
            Console.WriteLine(triangle.GetArea());      // 3
        }
    }
}
