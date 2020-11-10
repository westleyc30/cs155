using System;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person kyle = new Person("Kyle");
            Person Jane = new Person("Jane");
            Person kyle2 = new Person("Kyle");
            Truck chevy = new Truck(kyle, Manufacturer.Chevrolet, 8, 2000, 10000);
            Truck chevy2 = new Truck(kyle2, Manufacturer.Chevrolet, 8, 2000, 10000);
            Truck ford = new Truck(Jane, Manufacturer.Ford, 10, 3000, 12000);
            Console.WriteLine(chevy.ToString());
            Console.WriteLine($"Does truck 1 = truck 2: {chevy.Equals(chevy2)}");
            Console.WriteLine($"Does truck 1 = truck 3: {chevy.Equals(ford)}");
        }
    }
}
