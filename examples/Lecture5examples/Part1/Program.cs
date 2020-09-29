using System;

namespace Part1
{
    class Program
    {
        enum CardSuit { Club, Diamond, Spades, Hearts }
        enum month
        {
            jan,
            feb,
            mar, 
            apr,
            may,
            jun,
            jul,
            aug,
            sep,
            oct,
            nov,
            dec
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number of hours and I will tell you how many minutes");
            //int hours = int.Parse(Console.ReadLine());
            //int numberOfMinutes = 0;
            //int x;
            //for (x = 0; x < hours; x++)
            //{
            //    for (int y = 0; y < 60; y++)
            //    {
            //        numberOfMinutes++;
            //    }
            //}

            //Console.WriteLine($"Number of minutes in {hours} hours: {numberOfMinutes}");
            //double[] a = new double[10];
            //for( int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            // array lab
            //int headCount = 0;
            //int tailCount = 0;
            //double headPercent;
            //double tailPercent;

            //Random flip = new Random();

            //Console.WriteLine("This Program will flip a coin 8 times ");
            //for(int i = 1; i <= 8; i++)
            //{
            //    int coinFlip = flip.Next(2);
            //    if (coinFlip == 0)
            //    {
            //        headCount++;
            //        Console.WriteLine("heads");
            //    } else
            //    {
            //        tailCount++;
            //        Console.WriteLine("tails");
            //    }
            //    //Console.WriteLine(coinFlip);
            //}
            //Console.WriteLine($"The coin flips gave us {headCount} heads and {tailCount} tails.");
            //headPercent = Convert.ToDouble(headCount) / 8 * 100;
            //tailPercent = Convert.ToDouble(tailCount) / 8 * 100;
            //Console.WriteLine($"The 8 times we got {headPercent}% heads and {tailPercent}% tails");

            // Enumerations
            CardSuit C = CardSuit.Club;
            Console.WriteLine(C);

            Console.WriteLine($"The value of Jan in month enum is {(int)month.jan}");
            Console.WriteLine($"The value of Feb in month enum is {(int)month.feb}");
            Console.WriteLine($"The value of Mar in month enum is {(int)month.mar}");
            Console.WriteLine($"The value of Apr in month enum is {(int)month.apr}");
            Console.WriteLine($"The value of May in month enum is {(int)month.may}");
        }
    }
}
