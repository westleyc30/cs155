using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    
    class Duelist
    {
        private String _name;
        private int _accuracyNum;
        private int _accuracyDenom;
        private bool _alive = true;

        public Duelist()
        {
            name = "Defaulty";
            accuracyNum = 1;
            accuracyDenom = 2;
        }
        public Duelist(String name, int accuracyNum, int accuracyDenom)
        {
            this.name = name;
            this.accuracyNum = accuracyNum;
            this.accuracyDenom = accuracyDenom;
        }

        // GETTERS/SETTERS
        public String name { get { return _name; } set { _name = value; } }

        public int accuracyNum
        {
            get { return _accuracyNum; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("accuracyNum", "Must be greater than 0");
                }
                _accuracyNum = value;
            }
        }

        public int accuracyDenom
        {
            get { return _accuracyDenom; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("accuracyDenom", "Must be greater than 0");
                }
                _accuracyDenom = value;
            }
        }
        public bool alive { get { return _alive; } set { _alive = value; } }

        // OTHER METHODS

        public bool shoot(Duelist target)
        {
            bool hit = false;
            var rand = new Random();
            int roll = rand.Next(1, accuracyDenom + 1);
            if (roll <= accuracyNum)
            {
                hit = true;
                target.alive = false;
                Console.WriteLine($"{name} targets {target.name} rolls a {roll} and hits.");
            } else
            {
                Console.WriteLine($"{name} targets {target.name} rolls a {roll} and misses.");
            }
            return hit;
        }        

    }
}
