using System;

namespace Lab10
{
    public class Circle
    {
        public uint Radius { get; private set; }
        public uint Diameter { get; private set; }

        double Area;
        double Circumference;

        public Circle(uint radius)
        {
            Radius = radius;
            Diameter = radius * 2;
            Area = Math.Round(Math.Pow(radius, 2) * Math.PI, 3);
            Circumference = Math.Round(Diameter * Math.PI, 3);
        }

        public double GetCircumference()
        {
            return Circumference;
        }

        public double GetArea()
        {
            return Area;
        }
    }
}
