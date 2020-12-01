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
                    Snake snake = a as Snake; //10
                    Console.WriteLine(snake.GetDamage());
                    damage += snake.GetDamage(); //9
                }
                else if (a is Ogre)
                {
                    Ogre ogre = a as Ogre; //10
                    Console.WriteLine(ogre.GetDamage());
                    damage += ogre.GetDamage(); //6
                }
                else if (a is MarshmellowMan)
                {
                    MarshmellowMan marshmellowMan = a as MarshmellowMan; //10
                    Console.WriteLine(marshmellowMan.GetDamage());
                    damage += marshmellowMan.GetDamage(); //1
                }
            }
            return damage;
        }
    }
}
