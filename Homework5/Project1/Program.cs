/// Homework5		Exercise No. 1
/// File Name: Project1
/// @author: Westley Cho
/// Date:  October 5, 2020
/// <summary>
/// Problem Statement: Write code to create a copy of an array.
/// 
/// 
/// Overall Plan:
/// 1) First, start by creating an initial array. (You can use whatever type of data you want.)
/// Let's start with 10 items.
/// 2) Declare an array variable and assign it a new(yes, that means we'll use the new keyword) array with 10 items in it.
/// 3) Now create a second array variable.  Give it a new array with the same length as the first.
///    Instead of using a number for this length, use the Length property to get the size of the original array.
/// 4) Use a loop to read values from the original array and place them in the new array.  Also, print out the contents
///    of both arrays, to be sure everything copied correctly.
/// </summary>
using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] array1 = { "this", "That", "the other", "why", "Hello", "world", "beep", "boop", "boop", "bop" };
            String[] arrayCopy = new string[array1.Length];

            for(int i = 0; i < array1.Length; i++)
            {
                arrayCopy[i] = array1[i];
                Console.WriteLine($"array1[{i}]: {array1[i]} – arrayCopy[{i}]: {arrayCopy[i]}");
            }
        }
    }
}
