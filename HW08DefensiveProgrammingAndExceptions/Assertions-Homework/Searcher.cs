namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public class Searcher
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr.Length != 0 || arr != null, "Array cannot be null or empty!");
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) where T : IComparable<T>
        {
            Debug.Assert(startIndex < endIndex, "Start index cannot be bigger than end index!");
            Debug.Assert(startIndex >= 0, "Start index must be positive number or zero!");
            Debug.Assert(endIndex > 0, "End index must be positive number!");
            Debug.Assert(endIndex <= arr.Length, "End index cannot be biger than or equal to array length!");
            Debug.Assert(typeof(T) == typeof(Int32), "Parameter type must be integer number");
            Debug.Assert(value != null, "Parameter value cannot be null");

            while (startIndex <= endIndex)
            {
                int middleIndex = (startIndex + endIndex) / 2;

                if (arr[middleIndex].Equals(value))
                {
                    return middleIndex;
                }

                if (arr[middleIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = middleIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = middleIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
