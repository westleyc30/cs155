using System;

namespace Week14
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Running(Callback);
        }
        static void Callback(int i)
        {
            Console.WriteLine(i);
        }
    }
    public class MyClass
    {
        public delegate void myDelegate(int i);
        public void Running(myDelegate callback)
        {
            for(int i = 0; i < 10000; i++)
            {
                // does something
                callback(i);
            }
        }
    }
}
