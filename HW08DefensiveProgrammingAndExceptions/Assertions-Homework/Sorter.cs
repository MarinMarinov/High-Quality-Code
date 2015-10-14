namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public class Sorter
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr.Length != 0, "Array cannot be empty!");
            Debug.Assert(arr != null, "Array cannot be null!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) where T : IComparable<T>
        {
            Debug.Assert(startIndex < endIndex, "Start index cannot be bigger than end index!");
            Debug.Assert(startIndex >= 0, "Start index must be positive number or zero!");
            Debug.Assert(endIndex > 0, "End index must be positive number!");
            Debug.Assert(endIndex <= arr.Length, "End index cannot be biger than or equal to array length!");

            int minElementIndex = startIndex;

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
