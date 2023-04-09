using System;
using System.Diagnostics;


namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster monster1 = new Monster("Riger", EElementType.Fire, 100, 3, 0);


            Debug.Assert(monster1.Name == "Riger");
            Debug.Assert(monster1.ElementType == EElementType.Fire);
            Debug.Assert(monster1.Health == 100);
            Debug.Assert(monster1.AttackStat == 3);
            Debug.Assert(monster1.DefenseStat == 0);


            monster1.TakeDamage(20);
            Debug.Assert(monster1.Health == 80);


            monster1.TakeDamage(999);
            Debug.Assert(monster1.Health == 0);


            monster1 = new Monster("Riger", EElementType.Fire, 100, 3, 0);
            Monster monster2 = new Monster("Dragon", EElementType.Fire, 100, 1, 1);
            Monster monster3 = new Monster("slime", EElementType.Water, 100, 99, 99);


            monster1.Attack(monster2);
            Debug.Assert(monster2.Health == 98);


            monster2.Attack(monster3);
            Debug.Assert(monster3.Health == 99);


            monster3.Attack(monster1);


            Console.WriteLine($"\n\n{"┌",6}");
            Console.WriteLine($"{"Monster Battle Royal",28}");
            Console.WriteLine($"{"┘",30}");
            Console.WriteLine($"{"v 1.1",19}\n\n\n\n");
            Console.WriteLine($"{"From POCU",22}\n");
            Console.WriteLine($"{"By Hamzzi",22}\n\n\n\n\n\n\n\n");
            Console.Write($"{"Continue Press Key",27}");
            Console.ReadKey();
            Console.Clear();


            // 경기장 정원 < 몬스터 수
            Arena arena = new Arena("Colosseum", 2);


            Debug.Assert(arena.ArenaName == "Colosseum");
            Debug.Assert(arena.Capacity == 2);
            Debug.Assert(arena.Turn == 0);
            Debug.Assert(arena.MonsterCount == 0);


            arena.LoadMonsters("monsters.txt");
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");


            PrintMobList(arena.ArenaName);
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Water",8}{"99",5}{"4",5}{"0",5} |");
            Console.WriteLine($"{"②"} |{"MyMonster2",11}{"Fire",8}{"5",5}{"0",5}{"1",5} |");
            Console.WriteLine($"{"-".PadRight(40, '-')}");
            Console.WriteLine($"   |{"MyMonster3",11}{"Wind",8}{"99",5}{"99",5}{"99",5} |");
            Console.WriteLine($"   |{"MyMonster4",11}{"Fire",8}{"100",5}{"10",5}{"10",5} |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n\n");
            Console.Write($"{"Continue Press Key",28}");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.Turn == 1);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");


            PrintMobList(arena.ArenaName);
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Water",8}{"98",5}{"4",5}{"0",5} |");
            Console.WriteLine($"{"②"} |{"MyMonster2",11}{"Fire",8}{"1",5}{"0",5}{"1",5} |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n\n\n\n\n");
            Console.Write($"{"Continue Press Key",28}");
            Console.ReadKey();
            Console.Clear();


            // 경기장에 몬스터가 두 마리 남았을 때
            arena.GoToNextTurn();
            Debug.Assert(arena.Turn == 2);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");


            PrintMobList(arena.ArenaName);
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Water",8}{"98",5}{"4",5}{"0",5} |");
            Console.WriteLine($"{"②"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n\n\n\n\n");
            Console.Write($"{"Continue Press Key",28}");
            Console.ReadKey();
            Console.Clear();


            // 경기장에 몬스터가 한 마리 남았을 때
            arena.GoToNextTurn();
            Debug.Assert(arena.Turn == 2);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");


            Console.WriteLine($"\n\n\n\n\n{"The Final List",26}\n\n\n");
            Console.WriteLine($"{"┌",11}");
            Console.WriteLine($"{"MyMonster1",24}");
            Console.WriteLine($"{"┘",26}");
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n{"Continue Press Key",28}");
            Console.ReadKey();
            Console.Clear();




            // 경기장 정원 > 몬스터 수
            arena = new Arena("Colosseum", 5);


            Debug.Assert(arena.ArenaName == "Colosseum");
            Debug.Assert(arena.Capacity == 5);
            Debug.Assert(arena.Turn == 0);
            Debug.Assert(arena.MonsterCount == 0);


            arena.LoadMonsters("monsters.txt");


            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster4");


            PrintMobList(arena.ArenaName);
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Water",8}{"99",5}{"4",5}{"0",5} |");
            Console.WriteLine($"{"②"} |{"MyMonster2",11}{"Fire",8}{"5",5}{"0",5}{"1",5} |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"99",5}{"99",5}{"99",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"100",5}{"10",5}{"10",5} |");
            Console.WriteLine($"{"-".PadRight(40, '-')}");
            Console.WriteLine($"{"⑤"} |                                   |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");


            Console.Write($"{"Continue Press Key",28}");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.Turn == 1);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster3");


            PrintMobList(arena.ArenaName);
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Water",8}{"94",5}{"4",5}{"0",5} |");
            Console.WriteLine($"{"②"} |{"MyMonster2",11}{"Fire",8}{"1",5}{"0",5}{"1",5} |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"98",5}{"99",5}{"99",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"56",5}{"10",5}{"10",5} |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n\n\n");
            Console.Write($"{"Continue Press Key",28}");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.Turn == 2);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster3");


            PrintMobList(arena.ArenaName);
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Water",8}{"89",5}{"4",5}{"0",5} |");
            Console.WriteLine($"{"②"} |{"MyMonster3",11}{"Wind",8}{"98",5}{"99",5}{"99",5} |");
            Console.WriteLine($"{"③"} |{"MyMonster4",11}{"Fire",8}{"12",5}{"10",5}{"10",5} |");
            Console.WriteLine($"{"④"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n\n\n");
            Console.Write($"{"Continue Press Key",28}");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.Turn == 3);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster3");


            PrintMobList(arena.ArenaName);
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Water",8}{"89",5}{"4",5}{"0",5} |");
            Console.WriteLine($"{"②"} |{"MyMonster3",11}{"Wind",8}{"97",5}{"99",5}{"99",5} |");
            Console.WriteLine($"{"③"} | --------------out---------------- |");
            Console.WriteLine($"{"④"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n\n\n");
            Console.Write($"{"Continue Press Key",28}");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.Turn == 4);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster3");


            // 경기장에 몬스터가 두 마리 남았을 때
            PrintMobList(arena.ArenaName);
            Console.WriteLine($"{"①"} |{"MyMonster3",11}{"Wind",8}{"97",5}{"99",5}{"99",5} |");
            Console.WriteLine($"{"②"} | --------------out---------------- |");
            Console.WriteLine($"{"③"} | --------------out---------------- |");
            Console.WriteLine($"{"④"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n\n\n");
            Console.Write($"{"Continue Press Key",28}");
            Console.ReadKey();
            Console.Clear();


            // 경기장에 몬스터가 한 마리 남았을 때
            arena.GoToNextTurn();
            Debug.Assert(arena.Turn == 4);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster3");


            Console.WriteLine($"\n\n\n\n\n{"The Final List",26}\n\n\n");
            Console.WriteLine($"{"┌",11}");
            Console.WriteLine($"{"MyMonster3",24}");
            Console.WriteLine($"{"┘",26}");
            Console.WriteLine($"\n\n\n{"The Game End",25}\n\n\n\n\n");
        }


        public static void PrintMobList(string name)
        {
            Console.WriteLine($"\n\n\n{"Arena",21}");
            Console.WriteLine($"\n{$"[ {name} ]",25}\n\n");
            Console.WriteLine($"{"Name",12}{"Type",11}{"HP",5}{"ATK",5}{"DEF",6}");
            Console.WriteLine($"{"-".PadRight(40, '-')}");
        }
    }
}


