using System;


namespace Lab13
{
    class rectangle
    {
        static void Main(string[] args)
        {
            rectangle rect = new rectangle();
            mydelegate rectdele = new mydelegate(rect.area);
            // alternative
            // mydelegate rectdele = rect.area;
            rectdele += new mydelegate(rect.perimeter);

            rectdele.Invoke(6.0, 4.5);
            Console.WriteLine();
            rectdele.Invoke(15.3, 4.5);
        }
        public delegate void mydelegate(double height, double width);
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: " + height * width);
        }
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: " + ((2 * height) + (2 * width)));
        }
    }
}
