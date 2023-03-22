using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Console.WriteLine(circle.Radius);
            Console.WriteLine(circle.Diameter);
            Console.WriteLine(circle.GetCircumference());
            Console.WriteLine(circle.GetArea());
        }
    }
}
