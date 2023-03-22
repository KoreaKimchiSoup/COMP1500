using System;

namespace Assignment4
{
    public class Monster
    {
        public string Name { get; private set; }
        public EElementType ElementType { get; private set; }

        private int mHealth;
        public int Health
        {
            get
            {
                return mHealth;
            }
            private set
            {
                if (mHealth > 0) // 체력이 0 이하면안됌
                {
                    mHealth = value;
                }
            }
        }

        private int mAttackStat;
        public int AttackStat
        {
            get
            {
                return mAttackStat;
            }
            private set
            {
                mAttackStat = value;

                if (mAttackStat > 0) // 체력이 0 이하면안됌
                {
                    mAttackStat = value;
                }
            }
        }

        private int mDefenseStat;
        public int DefenseStat
        {
            get
            {
                return mDefenseStat;
            }
            private set
            {
                mDefenseStat = value;

                if (mDefenseStat > 0) // 체력이 0 이하면안됌
                {
                    mDefenseStat = value;
                }
            }
        }

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
            if (amount < 0)
            {
                return;
            }

            Health -= amount;
        }

        public void Attack(Monster otherMonster)
        {
            int defaultDamage = AttackStat - otherMonster.DefenseStat;
            double finalDamage = 1.0;

            // 속성 우열 가리기
            switch (ElementType)
            {
                case EElementType.Fire:
                    if (otherMonster.ElementType == EElementType.Wind)
                    {
                        finalDamage = defaultDamage * 1.5;
                    }
                    else if (otherMonster.ElementType == EElementType.Water || otherMonster.ElementType == EElementType.Ground)
                    {
                        finalDamage = defaultDamage * 0.5;
                    }
                    else
                    {
                        finalDamage = defaultDamage;
                    }
                    break;

                case EElementType.Water:
                    if (otherMonster.ElementType == EElementType.Fire)
                    {
                        finalDamage = defaultDamage * 1.5;
                    }
                    else if (otherMonster.ElementType == EElementType.Wind)
                    {
                        finalDamage = defaultDamage * 0.5;
                    }
                    else
                    {
                        finalDamage = defaultDamage;
                    }
                    break;

                case EElementType.Wind:
                    if (otherMonster.ElementType == EElementType.Ground || otherMonster.ElementType == EElementType.Water)
                    {
                        finalDamage = defaultDamage * 1.5;
                    }
                    else if (otherMonster.ElementType == EElementType.Fire)
                    {
                        finalDamage = defaultDamage * 0.5;
                    }
                    else
                    {
                        finalDamage = defaultDamage;
                    }
                    break;

                case EElementType.Ground:
                    if (otherMonster.ElementType == EElementType.Fire)
                    {
                        finalDamage = defaultDamage * 1.5;
                    }
                    else if (otherMonster.ElementType == EElementType.Wind)
                    {
                        finalDamage = defaultDamage * 0.5;
                    }
                    else
                    {
                        finalDamage = defaultDamage;
                    }
                    break;
            }

            if (finalDamage < 1)
            {
                return;
            }

            otherMonster.Health -= (int)finalDamage;
        }
    }
}
