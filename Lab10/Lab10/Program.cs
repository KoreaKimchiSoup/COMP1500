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
            Console.WriteLine(triangle1.GetPerimeter());
            Console.WriteLine(triangle1.GetArea());

            //Debug.Assert(triangle1.GetPerimeter() == 19.062);
            //Debug.Assert(triangle1.GetArea() == 14.000);
        }
    }
}
