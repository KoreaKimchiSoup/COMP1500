using System;
using System.Diagnostics;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            RightTriangle triangle1 = new RightTriangle(4, 7);

            Debug.Assert(triangle1.Width == 4);
            Debug.Assert(triangle1.Height == 7);

            Debug.Assert(triangle1.GetPerimeter() == 19.062);
            Debug.Assert(triangle1.GetArea() == 14.000);
            Console.WriteLine(triangle1.GetArea());

            RightTriangle triangle2 = new RightTriangle(7, 2);

            Debug.Assert(triangle2.Width == 7);
            Debug.Assert(triangle2.Height == 2);

            Debug.Assert(triangle2.GetPerimeter() == 16.280);
            Debug.Assert(triangle2.GetArea() == 7.000);
            Console.WriteLine(triangle2.GetArea());

            RightTriangle triangle3 = new RightTriangle(4, 7);
            Console.WriteLine(triangle3.GetArea());
        }
    }
}