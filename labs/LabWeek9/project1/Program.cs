/*
 * Create a class named Pizza that stores information about a single pizza. 
 * It should contain the following:

- Private instance variables to store the size of the pizza (either small, medium,
  or large), the number of cheese toppings, the number of pepperoni toppings and
  the number of ham toppings.
- Constructors that set all instance variables.
- Public methods to do get and set the instance variables.

- A public method named CalculateCost() that returns a double that is the
  cost of the pizza.
- Pizza cost is $10 for small, $12 for medium, $14 for large and $2 per topping.
- Override the ToString method that returns the pizza size, quantity of each
  topping and the pizza cost as calculated by the calcCost method.
  Write a program (in the main) to test all the methods in your class definition.
*/
using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza cheese = new Pizza();
            Pizza ham = new Pizza("medium", 1, 1, 0);
            Pizza choose = new Pizza();

            choose.setSize("large");
            choose.setCheese(5);
            choose.setHam(2);
            choose.setPepperoni(6);

            Console.WriteLine(cheese.ToString());
            Console.WriteLine(ham.ToString());
            Console.WriteLine(choose.ToString());
            Console.WriteLine(choose.getSize());
            Console.WriteLine(choose.getHam());
            Console.WriteLine(choose.getCheese());
            Console.WriteLine(choose.getPepperoni());
            Console.WriteLine(choose.CalculateCost());
        }
    }
}
