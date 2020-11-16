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
                if (a is Snake)
                {
                    Snake snake = a as Snake;
                    Console.WriteLine(snake.GetDamage());
                    damage += snake.GetDamage();
                }
                else if (a is Ogre)
                {
                    Ogre ogre = a as Ogre;
                    Console.WriteLine(ogre.GetDamage());
                    damage += ogre.GetDamage();
                }
                else if (a is MarshmellowMan)
                {
                    MarshmellowMan marshmellowMan = a as MarshmellowMan;
                    Console.WriteLine(marshmellowMan.GetDamage());
                    damage += marshmellowMan.GetDamage();
                }
            }
            return damage;
        }
    }
}
