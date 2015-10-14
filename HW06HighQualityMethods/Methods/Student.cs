namespace Methods
{
    using System;
    
    public class Student
    {
        private const int DateLength = 10;

        public Student(string firstName, string lastName, string otherInfo, string birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
            this.BirthDate = DateTime.Parse(birthDate);
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime firstDate = this.BirthDate;
            DateTime secondDate = otherStudent.BirthDate;

            bool isOlder = firstDate < secondDate;

            return isOlder;
        }
    }
}
