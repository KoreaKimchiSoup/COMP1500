using System.Collections.Generic;
using System.IO;

namespace Assignment4
{
    public class Arena
    {
        public uint Capacity { get; private set; }
        public string ArenaName { get; private set; }
        public uint Turn { get; private set; }
        public uint MonsterCount { get; private set; }

        private List<Monster> monsters = new List<Monster>();

        public Arena(string arenaName, uint capacity)
        {
            ArenaName = arenaName;
            Capacity = capacity;
            Turn = 0;
        }

        public void LoadMonsters(string filePath)
        {
            
        }

        public void GoToNextTurn()
        {
            List<Monster> aliveMonsters = new List<Monster>();

            foreach (Monster monster in monsters)
            {
                if (monster.Health > 0)
                {
                    aliveMonsters.Add(monster);
                }
            }
        }

        public string GetHealthiestOrNull()
        {
            return null;
        }
    }
}
