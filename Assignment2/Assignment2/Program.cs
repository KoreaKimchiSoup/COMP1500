using System;
using System.Diagnostics;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] canvas = new char[0, 0];

            Canvas.IsShape(canvas, EShape.Circle); //false
            Canvas.IsShape(canvas, EShape.Rectangle); //false
            Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle); //false
            Canvas.IsShape(canvas, EShape.IsoscelesTriangle); //false

            canvas = Canvas.Draw(7, 7, EShape.Circle);

            Canvas.IsShape(canvas, EShape.Circle); //true
            Canvas.IsShape(canvas, EShape.Rectangle); //false
            Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle); //false
            Canvas.IsShape(canvas, EShape.IsoscelesTriangle); //false
        }
    }
}