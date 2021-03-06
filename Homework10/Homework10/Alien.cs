﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10
{
    class Alien
    {
        public const int damage = 10;
        public int health { get; protected set; }
        public string name { get; protected set; }
 
        public Alien( int health, string name)
        {
            this.health = health;
            this.name = name;
        }
        public Alien()
        {
            health = 100;
            name = "Alien Bill";
        }

        public int GetDamage()
        {
            return damage;
        }
    }
}
