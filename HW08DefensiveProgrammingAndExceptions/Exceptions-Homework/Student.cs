namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<Exam> exams;

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("String cannot be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("String cannot be null or empty string!");
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams
        {
            get
            {
                return this.exams;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Student exam list cannot be null!");
                }

                this.exams = value;
            }
        }

        public IList<ExamResult> CheckExams()
        {
            IList<ExamResult> results = new List<ExamResult>();

            if (this.Exams.Count == 0)
            {
                Console.WriteLine("The student has no exams!"); // Yes, the student CAN have no exams in the beginning of his education;
                return null;
            }
            else
            {
                for (int i = 0; i < this.Exams.Count; i++)
                {
                    results.Add(this.Exams[i].Check());
                }

                return results;
            }
        }

        public double CalculateAverageExamResultInPercents()
        {
            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();

            if (this.Exams.Count == 0)
            {
                // No exams --> return 0;
                Console.WriteLine("The student has no exams!");
                return 0;
            }
            else
            {
                for (int i = 0; i < examResults.Count; i++)
                {
                    examScore[i] =
                        ((double)examResults[i].Grade - examResults[i].MinGrade) /
                        (examResults[i].MaxGrade - examResults[i].MinGrade);
                }

                return examScore.Average();
            }
        }
    }
}