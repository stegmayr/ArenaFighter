using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter
{
    class Fighter
    {
        public string name;
        public int strength;
        public int damage;
        public int health;

        public Fighter(string name)
        {
            Random randomInt = new Random();
            this.name = name;
            this.strength = randomInt.Next(1, 11);
            this.damage = randomInt.Next(1, 6);
            this.health = randomInt.Next(1, 16);
        }
    }
}
