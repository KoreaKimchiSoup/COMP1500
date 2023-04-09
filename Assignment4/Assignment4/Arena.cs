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
            List<Monster> AliveMonsters = new List<Monster>();

            foreach (Monster monster in monsters)
            {
                if (monster.Health > 0)
                {
                    AliveMonsters.Add(monster);
                }
            }

            if (AliveMonsters.Count < 2)
            {
                return;
            }

            for (int i = 0; i < AliveMonsters.Count; ++i)
            {
                Monster attackMonster = AliveMonsters[i];
                Monster targetMonster = AliveMonsters[(i + 1) % AliveMonsters.Count];
                attackMonster.Attack(targetMonster);
            }

            List<Monster> DeadMonsters = new List<Monster>();
            foreach (Monster monster in monsters)
            {
                if (monster.Health <= 0)
                {
                    DeadMonsters.Add(monster);
                }
            }

            foreach (Monster deadMonster in DeadMonsters)
            {
                monsters.Remove(deadMonster);
                MonsterCount--;
            }

            Turn++;
        }

        public string GetHealthiestOrNull()
        {
            return null;
        }
    }
}
