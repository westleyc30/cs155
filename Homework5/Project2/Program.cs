using System;
/// Homework5		Exercise No. 2
/// File Name: Project2
/// @author: Westley Cho
/// Date:  October 5, 2020
/// <summary>
/// Problem Statement: Reversing an Array. Let's make a program that uses methods to accomplish a task.  Let's take an array and reverse the contents of it
/// <example>
/// if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would become 10, 9, 8 , 7 ,6, 5, 4, 3, 2, 1.
/// </example>
/// </summary>
namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We shall reverse an array of numbers");
            int[] numbers = GenerateNumbers();
            Console.WriteLine("numbers:");
            PrintNumbers(numbers);
            Reverse(numbers);
            Console.WriteLine("numbers reversed:");
            PrintNumbers(numbers);
        }
        /// <summary>
        /// Creates an array of numbers from 1 to 10
        /// </summary>
        /// <returns>Array</returns>
        static int[] GenerateNumbers()
        {
            int[] newArray = new int[10];
            for (int i = 0; i< newArray.Length; i++)
            {
                newArray[i] = i + 1;
            }
            return newArray;
        }
        static int[] Reverse(int[] numbers)
        {
            int[] reversedArray = new int[numbers.Length];
            int a, b, temp;
            for(int i = 0; i < numbers.Length / 2; i++)
            {
                a = numbers[i];
                b = numbers[numbers.Length - i - 1];
                temp = a;
                numbers[i] = b;
                numbers[numbers.Length - i - 1] = temp;
            }
            return numbers;
        }
        /// <summary>
        /// prints each individual number in int[] numbers
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintNumbers(int[] numbers)
        {
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
