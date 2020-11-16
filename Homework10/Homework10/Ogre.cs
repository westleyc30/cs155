using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10
{
    class Ogre : Alien
    {
        public const int damage = 6;
        public Ogre(int health, string name)
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
