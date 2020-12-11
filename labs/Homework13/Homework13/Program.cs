using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class Program
    {
        static void Main(string[] args)
        {
            //writing into sql database
            //Console.WriteLine("Enter employee first name");
            //string fname = Console.ReadLine();
            //Console.WriteLine("Enter employee last name");
            //string lname = Console.ReadLine();
            //Console.WriteLine("Enter employee gender");
            //string gender = Console.ReadLine();
            //Console.WriteLine("Enter employee Salary");
            //int salary = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter employee ID name");
            //int departmentId = Int32.Parse(Console.ReadLine());

            //using (var context = new CS155Entities())
            //{
            //    var employee = new Employee()
            //    {
            //        FirstName = "Red",
            //        LastName = "Foreman",
            //        Gender = "Male",
            //        Salary = 5000,
            //        DepartmentId = 2
            //    };
            //    context.Employees.Add(employee);
            //    context.SaveChanges();
            //}


            // reading a sql database
            using (var context = new CS155Entities())
            {
                foreach(var emp in context.Employees)
                {
                    Console.WriteLine($"{emp.FirstName}     {emp.LastName}     {emp.Gender}      {emp.Salary}      {emp.DepartmentId}");
                }
            }
        }
    }
}
