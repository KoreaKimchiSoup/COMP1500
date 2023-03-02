using System.Diagnostics;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] array = new uint[0];
            bool bPass = Lab7.PlayGame(array);
            System.Console.WriteLine(bPass);

            array = new uint[4] { 2, 2, 1, 0 };
            bPass = Lab7.PlayGame(array);
            System.Console.WriteLine(bPass);

            array = new uint[10] { 6, 1, 5, 2, 4, 3, 2, 1, 4, 0 };
            bPass = Lab7.PlayGame(array);
            System.Console.WriteLine(bPass);

        }
    }
}