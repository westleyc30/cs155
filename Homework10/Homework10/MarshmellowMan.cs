using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10
{
    class MarshmellowMan : Alien
    {
        public MarshmellowMan(int health, string name)
        {
            this.health = health;
            this.name = name;
        }

        public int GetDamage()
        {
            return 1;
        }
    }
}
