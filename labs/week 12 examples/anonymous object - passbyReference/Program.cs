using System;

namespace anonymous_object___passbyReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            addOne(ref x);
            Console.WriteLine($"the value of x is {x}");
            Person p = new Person("Jeffery", 111);
            Console.WriteLine(p.ToString());
            celebrateBirthday(p);
        }
        public static void addOne(int x)
        {
            x++;
        }
        public static void celebrateBirthday(Person person)
        {
            person.setPersonAge(person.getPersonAge() + 1);
        }

    }

    class Person
    {
        private string personName;
        private int personAge;

        public Person(string personName, int personAge)
        {
            this.personName = personName;
            this.personAge = personAge; 
        }

        public void setPersonName (string name)
        {
            personName = name;
        }
        public string getPersonName()
        {
            return personName;
        }
        public void setPersonAge(int age)
        {
            personAge = age;
        }
        public int getPersonAge()
        {
            return personAge;
        }

        public bool isequal(Person o)
        {
            return (this.getPersonName().Equals(o.getPersonName()) && this.getPersonAge() == o.getPersonAge());
        }

        public string ToString()
        {
            return $"name: {this.getPersonName()}\nAge: {this.getPersonAge()}";
        }
    }
}
