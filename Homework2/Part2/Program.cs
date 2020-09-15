/// Homework 2
/// File Name: Part2
/// @author: Westley Cho
/// Date:  September 14, 2020
///
/// Problem Statement: Write a program that converts degrees Fahrenheit to Celsius
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for a temperature in F
/// 3) Using equation calculate the temperature in C
/// 4) Print to screen
/// 

using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("please enter a temperature in Farenheit");
            string temperatureAsString = Console.ReadLine();
            double fahrenheit = Convert.ToDouble(temperatureAsString);
            double toCelcius = (5 * (fahrenheit - 32) / 9);
            double celciusRounded = Math.Round(toCelcius, 1);
            Console.WriteLine(temperatureAsString + "F converts to: " + celciusRounded + "C");
        }
    }
}
