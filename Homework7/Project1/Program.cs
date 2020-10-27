///Define a class called Odometer that will be used to track fuel usage and
///miles per gallon.  Create two constructors, 1 constructor should be the
///no-argument constructor the other will set the two instance variables. The
///class should have instance variables for mileage driven and fuel used.
///Include a reset method that sets the mileage drive and the fuel used to zero.
///Include an add method which takes two parameters that add to the fuel
///consumed and the miles driven.  Finally create a method that returns the
///miles per gallon and an appropriate ToString method.
///
/// Write a driver program that tests all the methods and constructors.  
///

using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer trip1 = new Odometer();
            Odometer trip2 = new Odometer(100, 4.5);

            Console.WriteLine(trip1.FuelUsed);
            Console.WriteLine(trip1.MilesDriven);
            trip1.calculateMPG();

            Console.WriteLine("\n");

            Console.WriteLine(trip2.FuelUsed);
            Console.WriteLine(trip2.MilesDriven);
            Console.WriteLine(trip2.calculateMPG());
            Console.WriteLine("\n");

            Console.WriteLine(trip1.ToString());

            Console.WriteLine("\n");

            Console.WriteLine(trip2.ToString());
            Console.WriteLine("\n");
            trip2.Reset();
            Console.WriteLine(trip2.ToString());
        }
    }
}
