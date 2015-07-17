namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public abstract class Course
    {
        private string courseName;
        private string teacherName;
        private IList<string> students = new List<string>();

        protected Course(string courseName, string teacherName, IList<string> students)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
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

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Teacher name length must be at least 3 characters");
                }

                this.teacherName = value;
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
            result.Append("; Teacher = ");
            result.Append(this.TeacherName);
            result.Append("; Teacher name = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            return "{ " + string.Join(", ", this.Students) + " }";
        }
    }
}
