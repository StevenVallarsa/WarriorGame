using System;
using WarriorGame.Enum;
using WarriorGame.Equipment;

namespace WarriorGame
{
    class Warrior
    {

        private int goodGuyStartingHealth;
        private int badGuyStartingHealth;

        private int health;

        private string name;
        private Faction faction;
        private bool isAlive;

        public bool IsAlive { get; }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            this.faction = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = goodGuyStartingHealth;

                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = badGuyStartingHealth;
                    break;
                default:
                    break;
            }

        }
    }
}
