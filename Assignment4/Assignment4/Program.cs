using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new Arena("Empty Arena", 2);
            Console.WriteLine(arena.GetHealthiestOrNull());
        }
    }
}