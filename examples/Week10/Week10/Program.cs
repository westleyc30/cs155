using System;

namespace Week10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TimeClass time = new TimeClass();
            TimeStruct time = new TimeStruct();
            time.Sec = 10;
            Console.WriteLine($"The value of sec is {time.Sec}");
            UpdateTime(time);
            Console.WriteLine($"The value of sec is {time.Sec}");



        }
        public static void UpdateTime(TimeClass time)
        {
            time.Sec++;
        }
        public static void UpdateTime(TimeStruct time)
        {
            time.Sec++;
        }
    }
    
    class TimeClass
    {
        private int sec;

        public int Sec
        {
            get { return sec; }
            set { sec = value; }
        }

        public int CalcMin()
        {
            return Sec / 60;
        }
    }

    struct TimeStruct
    {
        private int sec;

        public int Sec
        {
            get { return sec; }
            set { sec = value; }
        }

        public int CalcMin()
        {
            return Sec / 60;
        }
    }
}
