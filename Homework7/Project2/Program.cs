///
/// Write a Temperature class that has two instance variables: a temperature
/// value (a floating-point number) and a character for the scale, either C for
/// Celsius of F for Fahrenheit.  The class should have 4 constructor methods:
/// one for each instance variable (assume zero degress if no value is specified
/// and Celsius if no scale is specified), one with two parameters for the two
/// instance variables, and a no-argument constructor (set to zero degrees
/// Celsius).  Include the following:

///Two getter methods to return the temperature, 1 of them to return the
///temperature in Celsius, the other to return the temperature in Fahrenheit.
///Return the value rounded to the nearest tenth of a degree.
///
///Three setter methods, one to set the temperature, one to set the scale and
///one to set both instance variables.
///
///A suitable ToString method.
///
///An Equals method that compares two temperatures. Hint call the same
///getTemperature method and compare that.
///
///A driver program that tests each of the constructors, each of the getters,
///each of the setter, the ToString method and the equals method, make sure
///that the Equals can return both true and false.
///


using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureScale first = new TemperatureScale();
            TemperatureScale second = new TemperatureScale();
            TemperatureScale setTempOnly = new TemperatureScale(100);
            TemperatureScale setScaleOnly = new TemperatureScale('C');


            first.SetScale('C');
            first.SetTemperature(80);
            second.SetAll(80, 'C');

            Console.WriteLine(first.GetTemperature());
            Console.WriteLine(second.GetTemperature());

            Console.WriteLine(first.GetScale());
            Console.WriteLine(second.GetScale());

            


            string value = first.ToString();
            Console.WriteLine("Test tostring");
            Console.WriteLine(value);
            Console.WriteLine("Testing equals true");
            Console.WriteLine(first.Equals(second));
            Console.WriteLine("testing equals false");
            Console.WriteLine(first.Equals(setScaleOnly));


            Console.WriteLine("Only temp should return 100C");
            Console.WriteLine(setTempOnly.ToString());

            Console.WriteLine("Only scale should return 0C");
            Console.WriteLine(setScaleOnly.ToString());
            Console.WriteLine($"in farenheit: {setScaleOnly.GetTempF()}");
        }
    }
}
