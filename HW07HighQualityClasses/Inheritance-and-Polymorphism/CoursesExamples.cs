namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class CoursesExamples
    {
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases", new List<string>{"Svetlin Nakov"}, new List<string> { "Gosho, Toshka" }, "12");
            Console.WriteLine(localCourse);

            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            localCourse.Teachers.Add("Bill Gates");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", new List<string> { "Mario Peshev" }, new List<string>() { "Thomas", "Ani", "Steve" }, "Smyadovo");
            Console.WriteLine(offsiteCourse);
        }
    }
}
