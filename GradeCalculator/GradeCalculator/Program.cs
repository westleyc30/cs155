using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //StudentRecord A = new StudentRecord(9, 10, 10, 90, 100);
            //StudentRecord A2 = new StudentRecord(9, 10, 10, 90, 100);
            //StudentRecord B = new StudentRecord(8, 8, 8, 80, 80);
            //StudentRecord C = new StudentRecord(7, 8, 6, 83, 82);

            //Console.WriteLine("#################");
            //Console.WriteLine("");
            //Console.WriteLine(A.ToString());
            //Console.WriteLine("");
            //Console.WriteLine("#################\n");

            //Console.WriteLine($"Is student A equal to student A2? {A.Equals(A2)}\n");

            //Console.WriteLine("#################");
            //Console.WriteLine("");
            //Console.WriteLine(C.ToString());
            //Console.WriteLine("");
            //Console.WriteLine("#################\n");

            //Console.WriteLine($"Is student A equal to student C? {A.Equals(C)}\n");

            StudentRecordProps student1 = new StudentRecordProps(7, 9, 8, 100, 100);
            StudentRecordProps student1Copy = new StudentRecordProps(7, 9, 8, 100, 100);
            StudentRecordProps C = new StudentRecordProps(7, 6, 6, 77, 80);

            Console.WriteLine("#################");
            Console.WriteLine("");
            Console.WriteLine(C.ToString());
            Console.WriteLine("");
            Console.WriteLine("#################\n");

            Console.WriteLine($"Is student1 equal to student1Copy? {student1.Equals(student1Copy)}\n");
        }
    }
}
