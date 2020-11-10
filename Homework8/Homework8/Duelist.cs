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
            this.threat = (double)accuracyNum / (double)accuracyDenom;
        }

        // GETTERS/SETTERS
        public double threat { get; }
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

        public bool Equals(Object o)
        {
            if (o == null)
            {
                return false;
            }
            Duelist otherDuelist = (Duelist)o;
            return this.name == otherDuelist.name && this.accuracyNum == otherDuelist.accuracyNum && this.accuracyDenom == otherDuelist.accuracyDenom && this.alive == otherDuelist.alive;
        }

        public bool shoot(Duelist target)
        { 
            bool hit = false;
            var rand = new Random();
            int roll = rand.Next(1, accuracyDenom + 1);
            if (roll <= accuracyNum)
            {
                hit = true;
                target.alive = false;
            } 
            return hit;
        }
        public Duelist determineGreatestThreat(Duelist[] duelistArray)
        {
            Duelist greatestThreat = duelistArray[0]; 
            for (int i = 0; i < duelistArray.Length; i++)
            {
                if (duelistArray[i].alive && duelistArray[i].threat > this.threat || duelistArray[i].alive && greatestThreat.threat < duelistArray[i].threat)
                {
                    greatestThreat = (Duelist)duelistArray[i];
                }
            }
            return greatestThreat;
        }

    }
}
