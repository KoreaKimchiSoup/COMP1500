namespace Assignment4
{
    public class Monster
    {
        public string Name { get; private set; }
        public EElementType EelementType { get; private set; }
        public int Health { get; private set; }
        public int AttackStat { get; private set; }
        public int DefenseStat { get; private set; }

        public Monster(string name, EElementType elementType, int health, int attack, int defense)
        {
            Name = name;
            EelementType = elementType;
            Health = health;
            AttackStat = attack;
            DefenseStat = defense;
        }

    }
}
