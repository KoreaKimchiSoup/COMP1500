using System;

namespace Assignment4
{
    public class Arena
    {
        public string ArenaName { get; private set; }
        public uint Capacity { get; private set; }
        public uint Turn { get; private set; }
        public uint MonsterCount { get; private set; }

        public Arena(string arenaName, uint capacity)
        {
            ArenaName = arenaName;
            Capacity = capacity;
        }

        public void LoadMonsters(string filePath)
        {

        }

        public string GoToNextTurn()
        {
            return null;
        }
    }
}
