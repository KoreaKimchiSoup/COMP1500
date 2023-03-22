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
            set
            {
                mHealth = value;

                if (mHealth < 0) // 체력이 0 이하면안됌
                {
                    mHealth = 0;
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
            set
            {
                mAttackStat = value;

                if (mAttackStat < 0) // 공격력이 0 이하면안됌
                {
                    mAttackStat = 0;
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
            set
            {
                mDefenseStat = value;

                if (mDefenseStat < 0) // 방어력이 0 이하면안됌
                {
                    mDefenseStat = 0;
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
            int finalDamage = 1;
            bool bElementalFlag = false;

            /* 속성 우열 가리기
            if (EElementType.Fire < EElementType.Wind)
            {
                bElementalFlag = true;
            }

            if (EElementType.Water > EElementType.Fire)
            {
                bElementalFlag = true;
            }

            if ()
            */
            if (bElementalFlag)
            {
                finalDamage = (int)(defaultDamage * 1.5);
            }

            else if (bElementalFlag)
            {
                finalDamage = (int)(defaultDamage * 0.5);
            }

            else
            {
                finalDamage = defaultDamage;
            }

            if (finalDamage < 1)
            {
                return;
            }

            otherMonster.Health -= finalDamage; 
        }
    }
}
