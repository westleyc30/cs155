using System;
using System.Collections.Generic;
using System.Text;

namespace week_12_examples
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string _name, double _salary)
        {
            Name = _name;
            Salary = _salary;
        }

        public int CompareTo(Employee other)
        {
            if (this.Salary > other.Salary)
            {
                return 1;
            } else if (this.Salary < other.Salary)
            {
                return -1;
            } else
            {
                return 0;
            }
        }
    }
}
