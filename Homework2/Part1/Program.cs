/// Homework2
/// File Name: Part1 
/// @author: Westley Cho
/// Date:  September 14, 2020
///
/// Problem Statement: Write a program that start with the string variable
/// first set to your first name and the string variable last set to your
/// last name. Both names should be all lowercase. Your program should then
/// create a new string that contains your full name in pig latin with the
/// first letter capitalized for the first and last name.  Use only the pig
/// latin rule of moving the first letter to the end of the word and adding
/// “ay”. Output the pig latin name to the screen. Use Substring and
/// ToUpper methods to construct the new name.
/// 
/// 
/// Overall Plan:
/// 1) Prompt user for first name
/// 2) Prompt user for last name
/// 3) Convert name to pig latin
/// 4) Print name in pig latin to screen
/// 

using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Today we're going to pig latinify your name");
            Console.WriteLine("What's your first name? ");
            Console.WriteLine("What's your last name? ");
            Console.WriteLine("In pig latin your name would be ");
        }
    }
}
