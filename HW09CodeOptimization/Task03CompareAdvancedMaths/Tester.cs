namespace Task03CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public class Tester
    {
        private const long Calculations = 10000000;

        private static Stopwatch watch = new Stopwatch();
        private static dynamic result;

        internal static void OperateFloat(float number, Operation operation)
        {
            watch.Reset();
            watch.Start();

            for (int loop = 0; loop < Calculations; loop++)
            {
                switch (operation)
                {
                    case Operation.NaturalLogarithm: result = Math.Log(number);
                        break;
                    case Operation.Sinus: result = Math.Sin(number);
                        break;
                    case Operation.SquareRoot: result = Math.Sqrt(number);
                        break;
                    default: throw new InvalidOperationException("Invalid mathematical operation");
                }
            }

            watch.Stop();

            Console.WriteLine("The estimated time for {0} calculations with function {1} of float is {2} milliseconds", Calculations, operation, watch.Elapsed.TotalMilliseconds);
        }

        internal static void OperateDouble(double number, Operation operation)
        {
            watch.Reset();
            watch.Start();

            for (int loop = 0; loop < Calculations; loop++)
            {
                switch (operation)
                {
                    case Operation.NaturalLogarithm: result = Math.Log(number);
                        break;
                    case Operation.Sinus: result = Math.Sin(number);
                        break;
                    case Operation.SquareRoot: result = Math.Sqrt(number);
                        break;
                    default: throw new InvalidOperationException("Invalid mathematical operation");
                }
            }

            watch.Stop();

            Console.WriteLine("The estimated time for {0} calculations with function {1} of double is {2} milliseconds", Calculations, operation, watch.Elapsed.TotalMilliseconds);
        }

        internal static void OperateDecimal(decimal number, Operation operation)
        {
            watch.Reset();
            watch.Start();

            for (int loop = 0; loop < Calculations; loop++)
            {
                switch (operation)
                {
                    case Operation.NaturalLogarithm: result = Math.Log((double)number);
                        break;
                    case Operation.Sinus: result = Math.Sin((double)number);
                        break;
                    case Operation.SquareRoot: result = Math.Sqrt((double)number);
                        break;
                    default: throw new InvalidOperationException("Invalid mathematical operation");
                }
            }

            watch.Stop();

            Console.WriteLine("The estimated time for {0} calculations with function {1} of decimal is {2} milliseconds", Calculations, operation, watch.Elapsed.TotalMilliseconds);
        }
    }
}