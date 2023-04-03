using System.IO;

namespace Assignment4
{
    public  class Arena
    {
        public uint Capacity { get; private set; }
        public string ArenaName { get; private set; }
        public uint Turn { get; private set; }
        public uint MonsterCount { get; private set; }

        public Arena(string arenaName, uint capacity)
        {
            ArenaName = arenaName;
            Capacity = capacity;
        }

        public void LoadMonsters(string filePath)
        {
            string text = File.ReadAllText(filePath);

            System.Console.WriteLine(text);
        }

        public void GoToNextTurn()
        {

        }

        public string GetHealthiestOrNull()
        {
            return null;
        }
    }
}
