/// Lab No. 1 Part 1
/// File Name: Part1
/// 
/// @author: Westley Cho
/// Date:  September 7, 2020
///
/// Problem Statement: Ask the user to enter three numbers, calculate the sum of
/// these three numbers, and display the sum to the screen
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for three integers
/// 3) Calculate the sum of the integers
/// 4) Print the sum of the integers to the screen
///

using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter, enter third number and press enter:");

            // declare two integer variables
            int n1, n2, n3, sum;
            //n1 = Int32.Parse(userInput);
            n1 = Int32.Parse(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            sum = n1 + n2 + n3;

            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of those three numbers is");
            Console.WriteLine(sum);

            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}
