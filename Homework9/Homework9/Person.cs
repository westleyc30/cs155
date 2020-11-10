/*
 
public class Person
{
    private String name;
    public Person(){...}
    public Person(string theName){...}
    public Person(Person obj){...}
    public string GetName() {...}
    public void SetName(string name) {...}
    public string ToString() {...}
    public bool Equals(Object obj){...}
}
 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9
{
    class Person
    {
        private string _name;

        public Person()
        {

        }

        public Person(string name)
        {
            _name = name;
        }

        public Person(Person obj)
        {

        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        override
        public string ToString()
        {
            return Name;
        }

        override
        public bool Equals(Object other)
        {
            if (other == null || !this.GetType().Equals(other.GetType()))
            {
                return false; 
            }
            else
            {
                Person otherPerson = (Person)other;
                return otherPerson.Name == Name;
            }
            

        }
    }
}
