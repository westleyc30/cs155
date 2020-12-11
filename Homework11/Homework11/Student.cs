using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class Student : IComparable
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int grade { get; set; }

        public Student(string _fName, string _lName, int _grade)
        {
            fName = _fName;
            lName = _lName;
            grade = _grade;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Student otherStudent = obj as Student;
            if (otherStudent != null)
                return this.grade.CompareTo(otherStudent.grade);
            else
                throw new ArgumentException("Object is not a Student");
        }
    }
}
