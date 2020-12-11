/*
 For this project you will be combining several concepts.  
Create a Student class and have the Student Class implement the IComparable interface.  
This interface will compare the Student’s score.  The Student class with also have first and last name fields.  
Create the appropriate constructors as well as getters and setters for the Student class.

 Create a Student information file.  The file is organized the same way as the Student class.  An example is shown below:

Philip Rivers 91

Tom Brady 49

Sam Darnold 92

Pete Carroll 87

Deion Sanders 77

Joe Montana 99

Read in this file and populate a List of Students.  
After the list of students is created you will need to compute the average and median of student scores.  
You will write this information out to a file called StudentStats.txt. 
As a reminder the median calculation will vary whether there is an odd or even number of elements in the list.

Hint:  
To make this assignment more object oriented you may want to wrap the student 
class inside another class that allows you to compute all the various aspects that you need.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            string[] gradeInformation = new string[2];

            try
            {
                string line;
                StreamReader sr = new System.IO.StreamReader("./Students.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    string[] student = line.Split(' ');

                    listOfStudents.Add(new Student(student[0], student[1], int.Parse(student[2])));


                    line = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: ${e.Message}");
                throw;
            }
            listOfStudents.Sort();
            foreach (var student in listOfStudents)
            {
                Console.WriteLine(student.grade);
            }
            gradeInformation[0] = $"The average grade is {averageGrade(listOfStudents)}";
            gradeInformation[1] = $"The median grade is {medianGrade(listOfStudents)}";
            File.WriteAllLines("./StudentStats.txt", gradeInformation);
        }
        public static double averageGrade(List<Student> list)
        {
            double gradesTotal = 0;
            foreach (var student in list)
            {
                gradesTotal += student.grade;
            }
            return gradesTotal / list.Count();
        }
        public static double medianGrade(List<Student> list)
        {
            int index = list.Count() / 2;
            if (list.Count() % 2 == 0) 
            {
                //Console.WriteLine(list[index].grade);
                return (((double)list[index].grade + (double)list[index - 1].grade) / 2);
            } else 
            {
                return list[index].grade;
            }
        }
    }
}
