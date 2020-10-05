using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            int randNum;
            Random rand = new Random();
            do
            {
                Console.WriteLine("guess a number between 1 and 100");
                randNum = rand.Next(1, 101);
                //test
                Console.WriteLine($"pssst... you should guess {randNum}");
                guess = int.Parse(Console.ReadLine());
                
                if(randNum == guess)
                {
                    Console.WriteLine("You guessed correctly! Nice!");
                } else
                {
                    Console.WriteLine($"Sorry you guessed: {guess} but the number was: {randNum}");
                }
            } while (guess != randNum);
            Console.WriteLine("bye now");
        }
    }
}
