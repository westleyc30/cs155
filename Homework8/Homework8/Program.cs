using System;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            Duelist aaron = new Duelist("Aaron", 1, 3);
            Duelist bob = new Duelist("Bob", 1, 2);
            Duelist charlie = new Duelist("Charlie", 995, 1000);

            aaron.shoot(bob);
            Console.WriteLine(bob.alive);
        }
    }
}
