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
        public bool alive;

        public Fighter(string name)
        {
            Random randomInt = new Random();
            this.name = name;
            this.strength = randomInt.Next(1, 11);
            this.damage = randomInt.Next(1, 6);
            this.health = randomInt.Next(10, 16);
            this.alive = true;
        }

        public Fighter()
        {
            Random randomInt = new Random();
            this.name = "Bosse";
            this.strength = randomInt.Next(1, 11);
            this.damage = randomInt.Next(1, 6);
            this.health = randomInt.Next(5, 11);
            this.alive = true;
        }

        public override string ToString()
        {
            return health > 0 ? $"Name: {name}\nStrength: {strength}\nDamage: {damage}\nHealth: {health}" : $"Name: {name}\nStrength: {strength}\nDamage: {damage}\nHealth: Dead";
        }
    }
}
