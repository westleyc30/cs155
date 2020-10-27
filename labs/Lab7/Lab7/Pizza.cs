using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
/// <summary>
/// Create a class named Pizza that stores information about a single pizza. It should contain the following:
/// - Private instance variables to store the size of the pizza (either small, medium, or large), the number of cheese toppings, the number of pepperoni toppings and the number of ham toppings.
/// - Constructors that set all instance variables.
/// - Public methods to do get and set the instance variables.
/// - A public method named CalculateCost() that returns a double that is the cost of the pizza.
/// - Pizza cost is $10 for small, $12 for medium, $14 for large and $2 per topping.
/// - Override the ToString method that returns the pizza size, quantity of each topping and the pizza cost as calculated by the calcCost method.
/// - Write a program (in the main) to test all the methods in your class definition.
/// </summary>

namespace Lab7
{
    class Pizza
    {
        private string _size;
        private int _cheese;
        private int _pepperoni;
        private int _ham;

        public string Size
        {
            get { return _size; }
            set
            {
                if (value == "small" || value == "medium" || value == "large")
                {
                    _size = value;
                }
                else
                {
                    _size = "";
                }
            }
        }

    }
}
