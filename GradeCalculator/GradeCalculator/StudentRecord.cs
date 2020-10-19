using System;
namespace GradeCalculator
{
    public class StudentRecord
    {
        /// Instance Variables
        private int quiz1;
        private int quiz2;
        private int quiz3;
        private int midterm;
        private int final;
        private double grade;
        private char letterGrade;

        /// constructors
        public StudentRecord(int quiz1, int quiz2, int quiz3, int midterm, int final)
        {
            SetAll(quiz1, quiz2, quiz3, midterm, final);
        }

        /// SETTERS
        public bool SetQuiz1(int quiz1) {
            bool isValid = quiz1 >= 0 && quiz1 <= 10;
            if (isValid)
            {
                this.quiz1 = quiz1;
            }
            return isValid;
        }
        public bool SetQuiz2(int quiz2)
        {
            bool isValid = quiz2 >= 0 && quiz2 <= 10;
            if (isValid)
            {
                this.quiz2 = quiz2;
            }
            return isValid;
        }
        public bool SetQuiz3(int quiz3)
        {
            bool isValid = quiz3 >= 0 && quiz3 <= 10;
            if (isValid)
            {
                this.quiz3 = quiz3;
            }
            return isValid;
        }
        public bool SetMidterm(int midterm)
        {
            bool isValid = midterm >= 0 && midterm <= 100;
            if (isValid)
            {
                this.midterm = midterm;
            }
            return isValid;
        }
        public bool SetFinal(int final)
        {
            bool isValid = final >= 0 && final <= 100;
            if (isValid)
            {
                this.final = final;
            }
            return isValid;
        }
        public void SetGrade()
        {
            grade = CalculateQuiz(quiz1, quiz2, quiz3) + CaclulateMidterm(midterm) + CalculateFinal(final);
            grade = Math.Round(grade, 2);
        }
        public void SetLetterGrade()
        {
            if(grade >= 90)
            {
                letterGrade = 'A';
            } else if(grade < 90 && grade >= 80)
            {
                letterGrade = 'B';
            } else if(grade < 80 && grade >= 70)
            {
                letterGrade = 'C';
            } else if(grade < 70 && grade >= 60)
            {
                letterGrade = 'D';
            } else
            {
                letterGrade = 'F';
            }
        }
        public bool SetAll(int quiz1, int quiz2, int quiz3, int midterm, int final)
        {
            bool isValid = SetQuiz1(quiz1) && SetQuiz2(quiz2) && SetQuiz3(quiz3) && SetMidterm(midterm) && SetFinal(final);
            if (isValid)
            {
                SetGrade();
                SetLetterGrade();
            }

            return isValid;
        }


        /// GETTERS
        public int GetQuiz1()
        {
            return quiz1;
        }
        public int GetQuiz2()
        {
            return quiz2;
        }
        public int GetQuiz3()
        {
            return quiz3;
        }
        public int GetMidterm()
        {
            return midterm;
        }
        public int GetFinal()
        {
            return final;
        }
        public double GetGrade()
        {
            return grade;
        }
        public char GetLetterGrade()
        {
            return letterGrade;
        }
        /// REQUIRED METHODS
        ///
        override
        public String ToString()
        {
            return $"Quiz 1: {quiz1}\nQuiz 2: {quiz2}\nQuiz 3: {quiz3}\nMidterm: {midterm}\nFinal: {final}\nPercent Grade: {grade}\nLetter Grade: {letterGrade}";
        }

        override
        public bool Equals(Object other)
        {
            if(other == null || ! this.GetType().Equals(other.GetType()))
            {
                return false;
            } else
            {
                StudentRecord otherObject = (StudentRecord) other;
                return quiz1 == otherObject.GetQuiz1() && quiz2 == otherObject.GetQuiz2() && quiz3 == otherObject.GetQuiz3() && midterm == otherObject.GetMidterm() && final == otherObject.GetFinal();
            }
        }

        /// HELPERS
        public double CalculateQuiz(double quiz1, double quiz2, double quiz3)
        {
            Console.WriteLine((quiz1 + quiz2 + quiz3) / 30 * 25);
            return ((quiz1 + quiz2 + quiz3) / 30) * 25;
        }
        public double CaclulateMidterm(double midterm)
        {
            Console.WriteLine((midterm / 100) * 35);
            return (midterm / 100) * 35;
        }
        public double CalculateFinal(double final)
        {
            Console.WriteLine((final / 100) * 40);
            return (final / 100) * 40;
        }
    }
}
