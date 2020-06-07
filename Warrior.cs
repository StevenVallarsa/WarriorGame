using System;
namespace WarriorGame
{
    class Warrior
    {

        private int goodGuyStartingHealth;
        private int badGuyStartingHealth;

        private Faction faction;

        private int Health;
        private string Name;
        private bool isAlive;

        public bool IsAlive { get; }

        private Weapon weapon;
        private Armor armor;
    }
}
