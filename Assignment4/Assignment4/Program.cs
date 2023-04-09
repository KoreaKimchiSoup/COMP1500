using System;
using System.Diagnostics;


namespace Assignment4
{
    class Program
    {
        static int arenaTurns = 0;
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\n\n{"┌",6}");
            Console.WriteLine($"{"Monster Battle Royal",28}");
            Console.WriteLine($"{"┘",30}");
            Console.WriteLine($"{"v 1.2",19}\n\n\n\n");
            Console.WriteLine($"{"From POCU",22}\n");
            Console.WriteLine($"{"Tested By Junseok",26}\n\n\n\n\n\n\n\n");
            Console.Write($"{"Continue Press Key",26}");
            Console.ReadKey();
            Console.Clear();


            Arena arena = new Arena("POCU ARENA", 8);
            arena.LoadMonsters("monsters.txt");
            Debug.Assert(arena.MonsterCount == 6);


            PrintRound();
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Earth",8}{"100",5}{"20",5}{"10",5} |");
            Console.WriteLine($"{"②"} |{"MyMonster2",11}{"Water",8}{"40",5}{"2",5}{"1",5} |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"44",5}{"15",5}{"10",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"50",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} |{"MyMonster5",11}{"Fire",8}{"100",5}{"10",5}{"10",5} |");
            Console.WriteLine($"{"⑥"} |{"MyMonster6",11}{"Wind",8}{"51",5}{"3",5}{"3",5} |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 6);
            Debug.Assert(arena.Turn == 1);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 99);


            PrintRound();
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Earth",8}{"99",5}{"20",5}{"10",5} |");
            Console.WriteLine($"{"②"} |{"MyMonster2",11}{"Water",8}{"21",5}{"2",5}{"1",5} |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"43",5}{"15",5}{"10",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"48",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} |{"MyMonster5",11}{"Fire",8}{"60",5}{"10",5}{"10",5} |");
            Console.WriteLine($"{"⑥"} |{"MyMonster6",11}{"Wind",8}{"41",5}{"3",5}{"3",5} |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 6);
            Debug.Assert(arena.Turn == 2);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 98);


            PrintRound();
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Earth",8}{"98",5}{"20",5}{"10",5} |");
            Console.WriteLine($"{"②"} |{"MyMonster2",11}{"Water",8}{"2",5}{"2",5}{"1",5} |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"42",5}{"15",5}{"10",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"46",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} |{"MyMonster5",11}{"Fire",8}{"20",5}{"10",5}{"10",5} |");
            Console.WriteLine($"{"⑥"} |{"MyMonster6",11}{"Wind",8}{"31",5}{"3",5}{"3",5} |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 4);
            Debug.Assert(arena.Turn == 3);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 97);


            PrintRound();
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Earth",8}{"97",5}{"20",5}{"10",5} |");
            Console.WriteLine($"{"②"} | --------------out---------------- |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"42",5}{"15",5}{"10",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"44",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} | --------------out---------------- |");
            Console.WriteLine($"{"⑥"} |{"MyMonster6",11}{"Wind",8}{"31",5}{"3",5}{"3",5} |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 3);
            Debug.Assert(arena.Turn == 4);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 97);


            PrintRound();
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Earth",8}{"97",5}{"20",5}{"10",5} |");
            Console.WriteLine($"{"②"} | --------------out---------------- |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"37",5}{"15",5}{"10",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"42",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} | --------------out---------------- |");
            Console.WriteLine($"{"⑥"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 3);
            Debug.Assert(arena.Turn == 5);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 77);


            PrintRound();
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Earth",8}{"77",5}{"20",5}{"10",5} |");
            Console.WriteLine($"{"②"} | --------------out---------------- |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"32",5}{"15",5}{"10",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"40",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} | --------------out---------------- |");
            Console.WriteLine($"{"⑥"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 3);
            Debug.Assert(arena.Turn == 6);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 57);


            PrintRound();
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Earth",8}{"57",5}{"20",5}{"10",5} |");
            Console.WriteLine($"{"②"} | --------------out---------------- |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"17",5}{"15",5}{"10",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"38",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} | --------------out---------------- |");
            Console.WriteLine($"{"⑥"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 3);
            Debug.Assert(arena.Turn == 7);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster1");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 37);


            PrintRound();
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Earth",8}{"37",5}{"20",5}{"10",5} |");
            Console.WriteLine($"{"②"} | --------------out---------------- |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"12",5}{"15",5}{"10",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"36",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} | --------------out---------------- |");
            Console.WriteLine($"{"⑥"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 3);
            Debug.Assert(arena.Turn == 8);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster4");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 34);


            PrintRound();
            Console.WriteLine($"{"①"} |{"MyMonster1",11}{"Earth",8}{"17",5}{"20",5}{"10",5} |");
            Console.WriteLine($"{"②"} | --------------out---------------- |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"7",5}{"15",5}{"10",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"34",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} | --------------out---------------- |");
            Console.WriteLine($"{"⑥"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 2);
            Debug.Assert(arena.Turn == 9);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster4");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 32);


            PrintRound();
            Console.WriteLine($"{"①"} | --------------out---------------- |");
            Console.WriteLine($"{"②"} | --------------out---------------- |");
            Console.WriteLine($"{"③"} |{"MyMonster3",11}{"Wind",8}{"7",5}{"15",5}{"10",5} |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"32",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} | --------------out---------------- |");
            Console.WriteLine($"{"⑥"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 1);
            Debug.Assert(arena.Turn == 10);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster4");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 30);


            PrintRound();
            Console.WriteLine($"{"①"} | --------------out---------------- |");
            Console.WriteLine($"{"②"} | --------------out---------------- |");
            Console.WriteLine($"{"③"} | --------------out---------------- |");
            Console.WriteLine($"{"④"} |{"MyMonster4",11}{"Fire",8}{"30",5}{"50",5}{"10",5} |");
            Console.WriteLine($"{"⑤"} | --------------out---------------- |");
            Console.WriteLine($"{"⑥"} | --------------out---------------- |");
            Console.WriteLine($"{"-".PadRight(40, '-')}\n\n\n\n");
            Console.ReadKey();
            Console.Clear();


            arena.GoToNextTurn();
            Debug.Assert(arena.MonsterCount == 1);
            Debug.Assert(arena.Turn == 10);
            Debug.Assert(arena.GetHealthiestOrNull().Name == "MyMonster4");
            Debug.Assert(arena.GetHealthiestOrNull().Health == 30);


            Console.WriteLine($"\n\n\n\n\n{"The Final Monster",28}\n\n\n");
            Console.WriteLine($"{"Congratulations",27}\n\n");
            Console.WriteLine($"{"┌",11}");
            Console.WriteLine($"{"MyMonster4",24}");
            Console.WriteLine($"{"┘",26}");
            Console.WriteLine($"\n\n\n{"The Game End",25}\n\n\n\n\n");
            Console.ReadKey();
            Console.Clear();
        }


        static void PrintRound()
        {
            const char DASH = '-';
            Console.WriteLine($"\n\n\n{"POCU ARENA",25}\n\n");
            Console.WriteLine($"{"[Round",21} {arenaTurns++}]\n\n");
            Console.WriteLine($"{"Name",12}{"Type",11}{"HP",5}{"ATK",5}{"DEF",6}");
            Console.WriteLine($"{"".PadRight(40, DASH)}");
        }
    }
}
