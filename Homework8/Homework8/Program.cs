using System;
using System.Linq;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            Duelist aaron = new Duelist("Aaron", 1, 3);
            Duelist bob = new Duelist("Bob", 1, 2);
            Duelist charlie = new Duelist("Charlie", 995, 1000);

            Duelist[] duelists = { aaron, bob, charlie };

            int aaronWins = 0;
            int bobWins = 0;
            int charlieWins = 0;

            
            aaron.determineGreatestThreat(duelists);

            for (int i = 0; i < 10; i++)
            {
                String winner = duelRound(duelists);
                if (winner == "Aaron")
                {
                    aaronWins++;
                } else if (winner == "Bob")
                {
                    bobWins++;
                } else
                {
                    charlieWins++;
                }
               
            }
            Console.WriteLine($"Aaron wins: {aaronWins}");
            Console.WriteLine($"Bob wins: {bobWins}");
            Console.WriteLine($"Charlie wins: {charlieWins}");
        }

        public static String duelRound(Duelist[] duelistArray)
        {
            int numAlive = 0;
            String winner = null;
            for (int i = 0; i < duelistArray.Length; i++)
            {
                if (duelistArray[i].alive)
                {
                    numAlive++;
                }
            }

            do
            {
                for (int i = 0; i < duelistArray.Length; i++)
                {
                    //////// TODO ///////////////
                    Duelist target = duelistArray[i].determineGreatestThreat(duelistArray);
                    if (duelistArray[i].alive)
                    {
                        duelistArray[i].shoot(target);
                    }
                    if (target.alive == false) {
                        Console.WriteLine(target.name + " died");
                        numAlive--; 
                    }
                }
            } while (numAlive > 1);
            
            //Console.WriteLine(winner);
            return winner;
        }
    }
}
