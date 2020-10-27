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
    public class Pizza
    {
        // INSTANCE VARIABLES
        private String size;
        private int cheese;
        private int pepperoni;
        private int ham;

        

        //CONSTRUCTORS
        public Pizza()
        {
            setSize("medium");
            setCheese(1);
            setHam(0);
            setPepperoni(0);
        }
        public Pizza(String size, int cheese, int ham, int pepperoni)
        {
            setSize(size);
            setCheese(cheese);
            setHam(ham);
            setPepperoni(pepperoni);
        }

        // SETTERS
        public bool setSize(String size)
        {
            bool isValid = size == "small" || size == "medium" || size == "large";
            if (isValid)
            {
                this.size = size;
            }
            return isValid;
        }
        public bool setCheese(int cheese)
        {
            bool isValid = cheese >= 0;
            if (isValid)
                this.cheese = cheese;
            return isValid;
        }
        public bool setPepperoni(int pepperoni)
        {
            bool isValid = pepperoni >= 0;
            if (isValid)
                this.pepperoni = pepperoni;
            return isValid;
        }
        public bool setHam(int ham)
        {
            bool isValid = ham >= 0;
            if (isValid)
                this.ham = ham;
            return isValid;
        }

        // GETTERS
        public String getSize()
        {
            return size;
        }
        public int getCheese()
        {
            return cheese;
        }
        public int getPepperoni()
        {
            return pepperoni;
        }
        public int getHam()
        {
            return ham;
        }

        // OTHER METHODS
        override
        public String ToString()
        {
            return $"size: {size}\ncheese: {cheese}\nham: {ham}\npepperoni: {pepperoni}\ncost: {CalculateCost()}\n";
        }
        public double CalculateCost()
        {
            double cost = 0;
            if (size == "small")
                cost += 10.00f;
            else if (size == "medium")
                cost += 12.00f;
            else if (size == "large")
                cost += 14.00f;

            cost += (ham * 2.00f) + (cheese * 2.00f) + (pepperoni * 2.00f);
            return cost;
        }
    }
}
