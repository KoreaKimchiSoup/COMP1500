namespace Assignment4
{
    public class Monster
    {
        public string Name { get; private set; }
        public EElementType ElementType { get; private set; }
        public int Health { get; private set; }
        public int AttackStat { get; private set; }
        public int DefenseStat { get; private set; }

        public Monster(string name, EElementType elementType, int health, int attack, int defense)
        {
            Name = name;
            ElementType = elementType;
            Health = health;
            AttackStat = attack;
            DefenseStat = defense;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void Attack(Monster otherMonster)
        {
            int baseDamage = AttackStat - otherMonster.DefenseStat;
            int finalDamage = 0;

            switch (ElementType)
            {
                /*
                    불은 바람에게 강하나 물과 땅에는 약함
                    물은 불에게 강하나 바람에게는 약함
                    땅은 불에게 강하나 바람에게는 약함
                    바람은 땅과 물에 강하나 불에게는 약함
                 */
                case EElementType.Fire:
                    if (otherMonster.ElementType == EElementType.Wind)
                    {
                        finalDamage = (int)(baseDamage * 1.5);
                    }
                    else if (otherMonster.ElementType == EElementType.Water || 
                                otherMonster.ElementType == EElementType.Earth)
                    {
                        finalDamage = (int)(baseDamage * 0.5);
                    }
                    else
                    {
                        finalDamage = baseDamage;
                    }
                    break;

                case EElementType.Water:
                    if (otherMonster.ElementType == EElementType.Fire)
                    {
                        finalDamage = (int)(baseDamage * 1.5);
                    }
                    else if (otherMonster.ElementType == EElementType.Wind)
                    {
                        finalDamage = (int)(baseDamage * 0.5);
                    }
                    else
                    {
                        finalDamage = baseDamage;
                    }
                    break;

                case EElementType.Earth:
                    if (otherMonster.ElementType == EElementType.Fire)
                    {
                        finalDamage = (int)(baseDamage * 1.5);
                    }
                    else if (otherMonster.ElementType == EElementType.Wind)
                    {
                        finalDamage = (int)(baseDamage * 0.5);
                    }
                    else
                    {
                        finalDamage = baseDamage;
                    }
                    break;

                case EElementType.Wind:
                    if (otherMonster.ElementType == EElementType.Earth ||
                        otherMonster.ElementType == EElementType.Water)
                    {
                        finalDamage = (int)(baseDamage * 1.5);
                    }
                    else if (otherMonster.ElementType == EElementType.Fire)
                    {
                        finalDamage = (int)(baseDamage * 0.5);
                    }
                    else
                    {
                        finalDamage = baseDamage;
                    }
                    break;
            }

            if (finalDamage < 0)
            {
                finalDamage = 1;
            }

            otherMonster.Health -= finalDamage;
        }
    }
}
