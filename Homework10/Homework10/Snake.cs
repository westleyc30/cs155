using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10
{
    class Snake : Alien
    {
        public const int damage = 10;
        public Snake(int health, string name)
        {
            this.health = health;
            this.name = name;
        }

        
        public int GetDamage()
        {
            return damage;
        }
    }
}
