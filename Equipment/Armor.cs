﻿using WarriorGame.Enum;

namespace WarriorGame.Equipment
{
    class Armor
    {
        private int goodGuyArmor;
        private int badGuyArmor;

        private int armorPoints;

        public int ArmorPoints { get; }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = goodGuyArmor;
                    break;
                case Faction.BadGuy:
                    armorPoints = badGuyArmor;
                    break;
                default:
                    break;
            }

        }
    }
}