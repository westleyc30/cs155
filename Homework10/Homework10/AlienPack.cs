using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10
{
    class AlienPack
    {
        private Alien[] aliens;
        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }
        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }
        public Alien[] GetAliens()
        {
            return aliens;
        }
        public int CalculateDamage()
        {
            int damage = 0;
            foreach (Alien a in aliens)
            {
                if (a.type == Alien.SNAKE_ALIEN)
                {
                    damage += 10;
                }
                else if (a.type == Alien.OGRE_ALIEN)
                {
                    damage += 6;
                }
                else if (a.type == Alien.MARSHALLOW_MAN_ALIEN)
                {
                    damage += 1;
                }
            }
            return damage;
        }
    }
}
