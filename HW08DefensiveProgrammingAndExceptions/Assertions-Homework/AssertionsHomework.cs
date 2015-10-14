namespace Assertions_Homework
{
    using System;

    public class AssertionsHomework
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            
            Sorter.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            // Sorter.SelectionSort(new int[0]); // Test sorting empty array - Assertion activated
            Sorter.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(Searcher.BinarySearch(arr, -1000));
            Console.WriteLine(Searcher.BinarySearch(arr, 0));
            Console.WriteLine(Searcher.BinarySearch(arr, 17));
            Console.WriteLine(Searcher.BinarySearch(arr, 10));
            Console.WriteLine(Searcher.BinarySearch(arr, 1000));
        }
    }
}
