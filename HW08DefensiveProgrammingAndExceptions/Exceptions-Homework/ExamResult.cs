namespace Exceptions_Homework
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Grade cannot be negative number!");
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Minimum grade cannot be negative number!");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Maximum grade cannot be negative number!");
                }

                if (value < this.minGrade)
                {
                    throw new ArgumentOutOfRangeException("Maximum grade cannot be less tan minimum grade!");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Comments cannot be null or empty string!");
                }

                this.comments = value;
            }
        }
    }
}