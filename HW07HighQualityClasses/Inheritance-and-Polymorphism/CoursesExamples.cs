﻿namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class CoursesExamples
    {
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases", "Svetlin Nakov", new List<string> { "Gosho, Toshka" }, "12");
            Console.WriteLine(localCourse);

            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", "Mario Peshev", new List<string>() { "Thomas", "Ani", "Steve" }, "Smyadovo");
            Console.WriteLine(offsiteCourse);
        }
    }
}
