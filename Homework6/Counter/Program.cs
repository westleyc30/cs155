using System;
/// <summary>
/// Define a class called Counter whose objects count things.  An object of this class records a 
/// count that is a nonnegative integer.  Include methods to set the counter to 0, to increase the 
/// count by 1, and to decrease the count by 1.  Be sure that no method allows the value of the counter 
/// to become negative.  Include a getter method that returns the current count value and a 
/// method that outputs the count to the screen.  There should be no input method or other setter methods.  
/// The only method that can set the counter is the one that sets it to 0.  Include a ToString methods 
/// and a Equals method.  Write a driver program that include a menu to interactively test each method in 
/// your program.  For example, the menu should have an option that test each method and operates on 1 
/// object for example you should be able to select the increment method which would increment your Counter. 
/// </summary>

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Counter test = new Counter();
            Counter other = new Counter();
            other.increment();
            other.increment();
            other.increment();
            other.increment();
            other.increment();
            Console.WriteLine("Choose an option to test the Counter class methods");
            do
            {
                Console.WriteLine("1) increment");
                Console.WriteLine("2) decrement");
                Console.WriteLine("3) reset Counter");
                Console.WriteLine("4) get current count");
                Console.WriteLine("5) test if equal another Counter object incremented to 5");
                Console.WriteLine("0) exits test");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case (1):
                        test.increment();
                        Console.WriteLine("Incremented Counter");
                        Console.WriteLine($"Current count: {test.getCount()}");
                        break;
                    case (2):
                        test.decrement();
                        Console.WriteLine("Decremented Counter");
                        Console.WriteLine($"Current count: {test.getCount()}");
                        break;
                    case (3):
                        test.setCount();
                        Console.WriteLine("resetting counter");
                        Console.WriteLine($"Current count: {test.getCount()}");
                        break;
                    case (4):
                        test.printToScreen();
                        break;
                    case (5):
                        Console.WriteLine($"test counter: {test.getCount()}");
                        Console.WriteLine($"OtherCounter: {other.getCount()}");
                        Console.WriteLine(test.equals(other));
                        break;
                    default:
                        choice = 0;
                        break;
                }
            } while (choice != 0) ;
        }
       
    }

}
