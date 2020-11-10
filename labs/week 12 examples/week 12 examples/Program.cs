using System;
using System.Collections.Generic;

namespace week_12_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee("Dave", 100000.00));
            emplist.Add(new Employee("Jill", 140000.00));
            emplist.Add(new Employee("Maurice", 120000.00));
            emplist.Add(new Employee("Sylvia", 188000.00));

            emplist.Sort();
            foreach (Employee employee in emplist)
            {
                Console.WriteLine($"{employee.Name} makes {employee.Salary} a year");
            }

            //List<int> numbers = new List<int>();
            //numbers.Add(12);
            //numbers.Add(19);
            //numbers.Add(29);
            //numbers.Add(11);
            //numbers.Add(18);

            //foreach (var number in numbers)
            //{
            //    Console.Write(number + ", ");
            //}
            //numbers.Sort();
            //Console.WriteLine();
            //foreach (var number in numbers)
            //{
            //    Console.Write(number + ", ");
            //}
        }
    }
}
