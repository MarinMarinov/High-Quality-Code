namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;

    public class Exceptions_Homework
    {
        public static void Main()
        {
            var substr = Subsequence.GetSubsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Subsequence.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Subsequence.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(StringExtractor.ExtractEnding("I love C#", 2));
            Console.WriteLine(StringExtractor.ExtractEnding("Nakov", 4));
            Console.WriteLine(StringExtractor.ExtractEnding("beer", 4));
            Console.WriteLine(StringExtractor.ExtractEnding("Hi", 100));

            try
            {
                PrimeChecker.CheckPrime(23);
                Console.WriteLine("23 is prime.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("23 is not prime", ex);
            }

            try
            {
                PrimeChecker.CheckPrime(33);
                Console.WriteLine("33 is prime.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("33 is not prime", ex);
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0)
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalculateAverageExamResultInPercents();
            Console.WriteLine("Average results of Peter Petrov= {0:p0}", peterAverageResult);

            List<Exam> ivanExams = new List<Exam>() { }; // test with empty list
            Student ivan = new Student("Ivan", "Ivanov", ivanExams);
            double ivanAverageResult = ivan.CalculateAverageExamResultInPercents(); // logs "The student has no exams!" - this the right behavior
            Console.WriteLine("Average results of Ivan Ivanov = {0:p0}", ivanAverageResult); // logs "Average results of Ivan Ivanov = 0%" - this the right behavior
        }
    }
}