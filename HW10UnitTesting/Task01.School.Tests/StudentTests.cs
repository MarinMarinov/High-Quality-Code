namespace Task01.School.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestCreatingValidStudentNotToThrow()
        {
            var testStudent = new Student("Pesho", 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInvalidStudentNameShouldThrow()
        {
            var testStudent = new Student(null, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestInvalidStudentMinNumberShouldThrow()
        {
            var testStudent = new Student("Pesho", int.MinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestInvalidStudentMaxNumberShouldThrow()
        {
            var testStudent = new Student("Pesho", int.MaxValue);
        }

        [TestMethod]
        public void TestStudentHasExpectedName()
        {
            string studentName = "Pesho";
            var testStudent = new Student(studentName, 99999);
            Assert.AreEqual(studentName, testStudent.Name, "Names are not equal");
        }

        [TestMethod]
        public void TestStudentHasExpectedNumber()
        {
            int studentNumber = 99999;
            var testStudent = new Student("Pesho", studentNumber);
            Assert.AreEqual(studentNumber, testStudent.StudentNumber, "Student numbers are not equal");
        }      
    }
}
