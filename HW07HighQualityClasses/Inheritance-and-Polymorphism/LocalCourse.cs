namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string courseName, IList<string> teachers, IList<string> students, string lab) :
            base(courseName, teachers, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Lab is a string with at least 2 symbols");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.Append("; Lab = ");
            result.Append(this.Lab);
            result.Append(" }");

            return result.ToString();
        }
    }
}