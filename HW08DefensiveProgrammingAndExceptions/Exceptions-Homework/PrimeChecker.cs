namespace Exceptions_Homework
{
    using System;

    public class PrimeChecker
    {
        public static void CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    throw new Exception("The number is not prime!");
                }
            }
        }
    }
}