using System;
namespace GradeCalculator
{
    public class StudentRecordProps
    {
        private int _quiz1;
        private int _quiz2;
        private int _quiz3;
        private int _midterm;
        private int _final;

        public int quiz1
        {
            get { return _quiz1; }
            set
            {
                if (value > 10 || value < 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be within the range of 0 to 10");
                _quiz1 = value;
            }
        }
        public int quiz2
        {
            get { return _quiz2; }
            set
            {
                if (value > 10 || value < 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be within 0-10");
                _quiz2 = value;
            }
        }
        public int quiz3
        {
            get { return _quiz3; }
            set
            {
                if (value > 10 || value < 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be within 0-10");
                _quiz3 = value;
            }
        }
        public int midterm
        {
            get { return _midterm; }
            set
            {
                if (value > 100 || value < 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be within 0-100");
                _midterm = value;
            }
        }
        public int final
        {
            get { return _final; }
            set
            {
                if (value > 100 || value < 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be within 0-100");
                _final = value;
            }
        }
        public double quizPercent
        {
            get { return ((double)quiz1 + (double)quiz2 + (double)quiz3) / 30 * 25; }
        }
        public double midtermPercent
        {
            get { return (double)midterm / 100 * 35; }
        }
        public double finalPercent
        {
            get { return (double)final / 100 * 40; }
        }
        public double totalGrade
        {
            get { return Math.Round((quizPercent + midtermPercent + finalPercent), 2); }
        }
        public char letterGrade
        {
            get
            {
                if (totalGrade >= 90)
                    return 'A';
                else if (totalGrade <= 89 && totalGrade >= 80)
                    return 'B';
                else if (totalGrade <= 79 && totalGrade >= 70)
                    return 'C';
                else if (totalGrade <= 69 && totalGrade >= 60)
                    return 'D';
                else
                    return 'F';
            }
        }
        public StudentRecordProps(int quiz1, int quiz2, int quiz3, int midterm, int final)
        {
            this.quiz1 = quiz1;
            this.quiz2 = quiz2;
            this.quiz3 = quiz3;
            this.midterm = midterm;
            this.final = final;
        }

        override
        public String ToString()
        {
            return $"Quiz 1: {quiz1}\nQuiz 2: {quiz2}\nQuiz 3: {quiz3}\nMidterm: {midterm}\nFinal: {final}\nPercent Grade: {totalGrade}\nLetter Grade: {letterGrade}";
        }

        override
        public bool Equals(Object other)
        {
            if (other == null || !this.GetType().Equals(other.GetType()))
            {
                return false;
            }
            else
            {
                StudentRecordProps otherObject = (StudentRecordProps)other;
                return quiz1 == otherObject.quiz1 && quiz2 == otherObject.quiz2 && quiz3 == otherObject.quiz3 && midterm == otherObject.midterm && final == otherObject.final;
            }
        }
    }
}