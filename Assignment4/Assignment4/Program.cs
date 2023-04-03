using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new Arena("5 Free For All", 5);
            arena.LoadMonsters(@"C:\Programming\POCU_academy\filePath");
        }
    }
}