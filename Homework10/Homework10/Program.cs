﻿/*
 In the attached file you will find some video game code by J. Hacker.  There is an Alien class to represent a monster and an AlienPack class that represents a band of aliens and how much damage they can inflict.

 The code is not very object oriented and does not support information hiding in the Alien class.  Split the code into multiple files.  Rewrite the code so that inheritance is used to represent the different types of aliens instead of the “type” parameter.  This should result in deletion of the “type” parameter.  Also rewrite the Alien class to hide the instance variables and create a GetDamage method for each derived class that returns the amount of damage the alien inflicts.  Finally, rewrite the CalculateDamage method to use GetDamage and write a Main method that tests the code.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework10
{
   
    
    class Program
    {
        static void Main(string[] args)
        {
            AlienPack pack = new AlienPack(3);
            pack.AddAlien(new Ogre(100, "Ugh"), 0);
            pack.AddAlien(new Snake(100, "Sssstethysss"), 1);
            pack.AddAlien(new MarshmellowMan(100, "March"), 2);
            Alien snake1 = new Snake(183, "bill");
            Snake snake2 = new Snake(21, "dd");

            Console.WriteLine(snake1.GetDamage());// 10
            Console.WriteLine(snake2.GetDamage());//9

            Console.WriteLine(pack.CalculateDamage());
        }
    }
}
