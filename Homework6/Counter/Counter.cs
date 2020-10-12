using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    
    class Counter
    {
        public int count { set; get; }
        //Constructors
        public Counter()
        {
            this.setCount();
        }
        // Setters
        public void setCount()
        {
            this.count = 0;
        }
        // Getters
        public int getCount()
        {
            return this.count;
        }
        // Other Methods
        public void increment()
        {
            this.count++;
        }
        public void decrement()
        {
            if(this.count > 0)
            {
                this.count--;
            }
            else
            {
                Console.WriteLine("can not decrement below 0");
            }
        }
        public void resetCounter()
        {
            this.count = 0;
        }
        public void printToScreen()
        {
            Console.WriteLine(this.toString());
        }
        ///<summary>
        /// String representation of object
        /// </summary>
     
        public String toString()
        {
            return $"The current count is: {count}";
        }
        public bool equals(object other)
        {
            
            Counter otherCounter = (Counter)other;
            return otherCounter.getCount() == this.getCount();
        }
    }
}
