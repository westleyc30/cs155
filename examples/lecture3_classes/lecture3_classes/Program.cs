using System;

namespace lecture3_classes
{
    public class Dog
    {
        // instance variables // making all private variables is called INCAPSULATION
        private String name;
        private String breed;
        private int age;
        private String color;


        //constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public Dog()
        {

        }
        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="breed"></param>
        /// <param name="age"></param>
        /// <param name="color"></param>
        public Dog(String name, String breed, int age, String color)
        {
            this.name = name;
            this.breed = name;
            this.age = age;
            this.color = color;
        }
        // methods
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }

        public String toString() {
            return ""
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog tuffy = new Dog();

            tuffy.setName("tuffy");
            Console.WriteLine(tuffy.getName());
        }
    }
}
