using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster monster = new Monster("Monster1", EElementType.Fire, 80, 5, 0);
            monster.TakeDamage(20); // monster.Health가 60이 됨
            Console.WriteLine(monster.Health);
            monster.TakeDamage(30); // monster.Health가 30이 됨
            Console.WriteLine(monster.Health);
            Console.WriteLine(monster.ElementType);
            Console.WriteLine(monster.AttackStat);
            Console.WriteLine(monster.DefenseStat);
        }
    }
}
