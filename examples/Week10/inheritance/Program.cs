using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Teacher
    {
        private String collegeName;
        private String designation;

        public Teacher()
        {
            
        }
        public Teacher(String collegeName, String designation)
        {
            this.collegeName = collegeName;
            this.designation = designation;
        }


        // SETTERS GETTERS
        public void setCollegeName(String collegeName)
        {
            this.collegeName = collegeName;
        }
        public void setDesignation(String designation)
        {
            this.designation = designation;
        }

        public String getCollegeName()
        {
            return collegeName;
        }
        public String getDesignation()
        {
            return designation;
        }
    }
    class ComputerScienceTeacher:Teacher
    {

        private String mainSubject;

        public ComputerScienceTeacher(String collegeName, String designation, String mainSubject)
        {
            setCollegeName(collegeName);
            setDesignation(designation);
            this.mainSubject = mainSubject;
        }
       

    }
}
