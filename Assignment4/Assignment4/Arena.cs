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

        private List<Monster> mMonsters = new List<Monster>();

        public Arena(string arenaName, uint capacity)
        {
            ArenaName = arenaName;
            Capacity = capacity;
            Turn = 0;
        }

        public void LoadMonsters(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (mMonsters.Count >= Capacity)
                    {
                        break;
                    }


                    string[] monsterData = line.Split(',');
                    string name = monsterData[0];
                    EElementType elementType = (EElementType)EElementType.Parse(typeof(EElementType), monsterData[1]);
                    int health = int.Parse(monsterData[2]);
                    int attack = int.Parse(monsterData[3]);
                    int defense = int.Parse(monsterData[4]);

                    Monster monster = new Monster(name, elementType, health, attack, defense);
                    mMonsters.Add(monster);
                }
            }
        }

        public void GoToNextTurn()
        {
            List<Monster> aliveMonsters = new List<Monster>();

            foreach (Monster monster in mMonsters)
            {
                if (monster.Health > 0)
                {
                    aliveMonsters.Add(monster);
                }
            }

            if (mMonsters.Count == 1)
            {
                return;
            }

            if (mMonsters.Count == 0)
            {
                return;
            }

            for (int i = 0; i < aliveMonsters.Count; ++i)
            {
                Monster attackMonster = aliveMonsters[i];
                Monster targetMonster = aliveMonsters[(i + 1) % aliveMonsters.Count];
                attackMonster.Attack(targetMonster);
            }

            List<Monster> deadMonsters = new List<Monster>();
            foreach (Monster monster in mMonsters)
            {
                if (monster.Health <= 0)
                {
                    deadMonsters.Add(monster);
                }
            }

            foreach (Monster deadMonster in deadMonsters)
            {
                mMonsters.Remove(deadMonster);
                MonsterCount--;
            }

            Turn++;
        }

        public Monster GetHealthiestOrNull()
        {
            if (mMonsters.Count == 0)
            {
                return null;
            }

            Monster getHealthiestMonster = mMonsters[0];
            for (int i = 0; i < mMonsters.Count; ++i)
            {
                if (mMonsters[i].Health > getHealthiestMonster.Health)
                {
                    getHealthiestMonster = mMonsters[i];
                }
            }

            // GetHealthiestOrNull() 함수는 경기장에서 체력이 가장 높은 몬스터를 반환합니다.
            // 이 함수는 인자를 받지 않습니다.
            // 경기장에 몬스터가 없을 경우 null을 반환해야 합니다.
            return getHealthiestMonster;
        }
    }
}
