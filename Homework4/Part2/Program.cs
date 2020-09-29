/**
 * Homework 4
 * Part 2
 * @author: Westley Cho
 * 
 * Problem Statement: Write a program that will print out the statistics for eight coin tosses.
 * User will input results. results will be displayed in console
 * 
 * Overall Plan:
 * 1. create variables for total and percent of heads and tails
 * 2. Run for loop to have user input heads or tails 8 times
 * 3. calculate results
 * 4. print results to console.
 * 
 * 
 */
using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalHeads, totalTails;
            double percentHeads, percentTails;
            totalHeads = 0;
            totalTails = 0;
            for (int i = 0; i < 8; i++)
            {
                String choice;
                Console.WriteLine("Please flip coin and input results.");
                Console.WriteLine("h for heads, t for tails");
                choice = Console.ReadLine();
                if (choice == "h")
                {
                    totalHeads++;
                }
                if (choice == "t")
                {
                    totalTails++;
                }
            }
            percentHeads = Math.Round((totalHeads / 8 * 100), 2);
            percentTails = Math.Round((totalTails / 8 * 100), 2);

            Console.WriteLine($"Number of Heads: {totalHeads}");
            Console.WriteLine($"Number of tails: {totalTails}");
            Console.WriteLine($"percent Heads: {percentHeads}");
            Console.WriteLine($"percent tails: {percentTails}");
        }
    }
}
