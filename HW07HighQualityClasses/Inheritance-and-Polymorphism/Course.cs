namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public abstract class Course
    {
        private string courseName;
        private IList<string> teachers = new List<string>();
        private IList<string> students = new List<string>();

        protected Course(string courseName, IList<string> teachers, IList<string> students)
        {
            this.CourseName = courseName;
            this.Teachers = teachers;
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name length must be at least 3 characters");
                }

                this.courseName = value;
            }
        }

        public IList<string> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Teachers list must contain at least one teacher");
                }

                this.teachers = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Students list must contain at least one student");
                }

                this.students = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.GetType().Name);
            result.Append(": { Name = ");
            result.Append(this.CourseName);
            result.Append("; Teachers = ");
            result.Append(this.GetTeachersAsString());
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            return "{ " + string.Join(", ", this.Students) + " }";
        }

        private string GetTeachersAsString()
        {
            return "{ " + string.Join(", ", this.Teachers) + " }";
        }
    }
}
