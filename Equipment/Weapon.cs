using WarriorGame.Enum;

namespace WarriorGame.Equipment
{
    class Weapon
    {
        private int goodGuyDamage;
        private int badGuyDamage;

        private int damage;

        public int Damage { get; }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = goodGuyDamage;
                    break;
                case Faction.BadGuy:
                    damage = badGuyDamage;
                    break;
                default:
                    break;
            }
        }
    }
}