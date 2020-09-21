/// Lab No. 1 Part 2
/// File Name: Part2
/// 
/// @author: Westley Cho
/// Date:  September 7, 2020
///
/// Problem Statement: The video game machine at your local arcade output
/// coupons according to how well you play the game.
/// You can redeem 10 coupons for a candy bar or 3 coupons for a gumball.
/// You prefer candy bars to gumballs.
/// Write a program that defines a variable initially assigned to the number of coupons you win.
/// Next, the program should output how many candy bars and gumballs you can get
/// if you spend all of your coupons on candy bars first, and any remaining coupons on gumballs.
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for three integers
/// 3) Calculate the sum of the integers
/// 4) Print the sum of the integers to the screen
///

using System;

namespace Part2
{
    static class Constants
    {
        public const int CANDY_BAR_COST = 10;
        public const int GUMBALL_COST = 3;
    }
    class Part2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there, welcome to the arcade");
            Console.WriteLine("How many tickets do you have?");

            int totalTickets, remainder, totalCandyBars, totalGumballs;

            totalTickets = Int32.Parse(Console.ReadLine());
            totalCandyBars = totalTickets / Constants.CANDY_BAR_COST;
            totalTickets = totalTickets % Constants.CANDY_BAR_COST;
            totalGumballs = totalTickets / Constants.GUMBALL_COST;
            remainder = totalTickets % Constants.GUMBALL_COST;

            Console.WriteLine("You can get:");
            Console.WriteLine("Candy Bars:          " + totalCandyBars);
            Console.WriteLine("Gumballs:            " + totalGumballs);
            Console.WriteLine("Leftover Tickets:    " + remainder);

        }
    }
}
