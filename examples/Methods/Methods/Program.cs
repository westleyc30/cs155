using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            myMethod();
            Console.WriteLine(sumMethod(2, 3));
            Console.WriteLine(sumMethod(2.3, 5.2));
        }

        // method examples
        static void myMethod(String country = "Norway")
        {
            Console.WriteLine(country);
        }
        // method overloading
        static int sumMethod(int x, int y)
        {
            return x + y;
        }
        static double sumMethod(double x, double y)
        {
            return x + y;
        }
    }
}
