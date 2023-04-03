using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            monsters.csv
            MyMonster1,Earth,100,20,10
            MyMonster2,Water,40,2,1
            MyMonster3,Wind,44,15,10
            MyMonster4,Fire,250,50,10
            MyMonster5,Fire,200,10,10
            MyMonster6,Wind,51,3,3
            */

            Arena arena = new Arena("5 Free For All", 5);
            arena.LoadMonsters("C://Some/Path/To/CSV/monsters.csv");

            // MyMonster1 - MyMonster5가 경기장에 추가됨
        }
    }
}
