namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string courseName, IList<string> teachers, IList<string> students, string town) :
            base(courseName, teachers, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Town name length must be at least 3 symbols");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.Append("; Town = ");
            result.Append(this.Town);
            result.Append(" }");

            return result.ToString();
        }
    }
}