namespace MethodPrintStatistics
{
    using System;
    using System.Linq;

    public class Print
    {
        public static void Main(string[] args)
        {
            double[] numbers = new double[] { 1.2, 2.4, 3.6, 4.5, 5.6 };

            PrintStatistics(numbers);
        }

        public static void PrintStatistics(double[] numbers)
        {
            Console.WriteLine(MessageTemplates.MaximumNumberMessage, FindMaxNumber(numbers));
            Console.WriteLine(MessageTemplates.MinimumNumberMessage, FindMinNumber(numbers));
            Console.WriteLine(MessageTemplates.AverageNumberMessage, FindAverageNumber(numbers));
        }

        private static double FindMaxNumber(double[] numbers)
        {
            double maxNumber = numbers.Max();

            return maxNumber;
        }

        private static double FindMinNumber(double[] numbers)
        {
            double minNumber = numbers.Min();

            return minNumber;
        }

        private static double FindAverageNumber(double[] numbers)
        {
            double averageNumber = numbers.Average();

            return averageNumber;
        }
    }
}
