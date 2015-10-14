namespace Task02CompareSimpleMathOperations
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class Tester
    {
        private const long Loops = 10000000;
        private const int Iterations = 6;
        private const int Increment = 1;

        private static Stopwatch watch = new Stopwatch();
        private static List<int> results = new List<int>();

        internal static void OperateInteger(int number, Operation operation)
        {
            results.Clear();

            for (int iteration = 0; iteration < Iterations; iteration++)
            {
                watch.Reset();
                watch.Start();

                for (int loop = 0; loop < Loops; loop++)
                {
                    switch (operation)
                    {
                        case Operation.Add: number += Increment;
                            break;
                        case Operation.Divide: number /= Increment;
                            break;
                        case Operation.Increment: number++;
                            break;
                        case Operation.Multiply: number *= Increment;
                            break;
                        case Operation.Subtract: number -= Increment;
                            break;
                        default: throw new InvalidOperationException("Invalid mathematical operation");
                    }
                }

                watch.Stop();

                results.Add(watch.Elapsed.Milliseconds);
            }

            double averageResult = results.Average();

            Console.WriteLine("The average result from Operation {0} if integers is {1:0.00} milliseconds", operation, averageResult);
        }

        internal static void OperateLong(long number, Operation operation)
        {
            results.Clear();

            for (int iteration = 0; iteration < Iterations; iteration++)
            {
                watch.Reset();
                watch.Start();

                for (int loop = 0; loop < Loops; loop++)
                {
                    switch (operation)
                    {
                        case Operation.Add: number += Increment;
                            break;
                        case Operation.Divide: number /= Increment;
                            break;
                        case Operation.Increment: number++;
                            break;
                        case Operation.Multiply: number *= Increment;
                            break;
                        case Operation.Subtract: number -= Increment;
                            break;
                        default: throw new InvalidOperationException("Invalid mathematical operation");
                    }
                }

                watch.Stop();

                results.Add(watch.Elapsed.Milliseconds);
            }

            double averageResult = results.Average();

            Console.WriteLine("The average result from Operation {0} of longs is {1:0.00} milliseconds", operation, averageResult);
        }

        internal static void OperateFloat(float number, Operation operation)
        {
            results.Clear();

            for (int iteration = 0; iteration < Iterations; iteration++)
            {
                watch.Reset();
                watch.Start();

                for (int loop = 0; loop < Loops; loop++)
                {
                    switch (operation)
                    {
                        case Operation.Add: number += Increment;
                            break;
                        case Operation.Divide: number /= Increment;
                            break;
                        case Operation.Increment: number++;
                            break;
                        case Operation.Multiply: number *= Increment;
                            break;
                        case Operation.Subtract: number -= Increment;
                            break;
                        default: throw new InvalidOperationException("Invalid mathematical operation");
                    }
                }

                watch.Stop();

                results.Add(watch.Elapsed.Milliseconds);
            }

            double averageResult = results.Average();

            Console.WriteLine("The average result from Operation {0} of floats is {1:0.00} milliseconds", operation, averageResult);
        }

        internal static void OperateDouble(double number, Operation operation)
        {
            results.Clear();

            for (int iteration = 0; iteration < Iterations; iteration++)
            {
                watch.Reset();
                watch.Start();

                for (int loop = 0; loop < Loops; loop++)
                {
                    switch (operation)
                    {
                        case Operation.Add: number += Increment;
                            break;
                        case Operation.Divide: number /= Increment;
                            break;
                        case Operation.Increment: number++;
                            break;
                        case Operation.Multiply: number *= Increment;
                            break;
                        case Operation.Subtract: number -= Increment;
                            break;
                        default: throw new InvalidOperationException("Invalid mathematical operation");
                    }
                }

                watch.Stop();

                results.Add(watch.Elapsed.Milliseconds);
            }

            double averageResult = results.Average();

            Console.WriteLine("The average result from Operation {0} of doubles is {1:0.00} milliseconds", operation, averageResult);
        }

        internal static void OperateDecimal(decimal number, Operation operation)
        {
            results.Clear();

            for (int iteration = 0; iteration < Iterations; iteration++)
            {
                watch.Reset();
                watch.Start();

                for (int loop = 0; loop < Loops; loop++)
                {
                    switch (operation)
                    {
                        case Operation.Add: number += Increment;
                            break;
                        case Operation.Divide: number /= Increment;
                            break;
                        case Operation.Increment: number++;
                            break;
                        case Operation.Multiply: number *= Increment;
                            break;
                        case Operation.Subtract: number -= Increment;
                            break;
                        default: throw new InvalidOperationException("Invalid mathematical operation");
                    }
                }

                watch.Stop();

                results.Add(watch.Elapsed.Milliseconds);
            }

            double averageResult = results.Average();

            Console.WriteLine("The average result from Operation {0} of decimals is {1:0.00} milliseconds", operation, averageResult);
        }
    }
}