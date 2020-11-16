using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10
{
    class Alien
    {
        public const int SNAKE_ALIEN = 0;
        public const int OGRE_ALIEN = 1;
        public const int MARSHALLOW_MAN_ALIEN = 2;

        public int type;
        public int health; //0 = dead, 100 = full        
        public string name;
        public Alien(int type, int health, string name)
        {
            this.type = type;
            this.health = health;
            this.name = name;
        }
    }
}
