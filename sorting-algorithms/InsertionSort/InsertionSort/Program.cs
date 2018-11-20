using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] unsortedArr = new int[] { 4, 2, 99, 7, 12, 1 };
            Console.WriteLine("Unsorted Array");
            PrintArr(unsortedArr);
            Console.WriteLine("Array Sorted by Insertion Sort");
            int[] sortedArr = InsertionSort(unsortedArr);
            PrintArr(sortedArr);
            Console.ReadLine();
        }
        /// <summary>
        /// Algorithm that sorts an array of integers in place using the Insertion Sort pattern
        /// </summary>
        /// <param name="arrToSort">An array of integers, presumably unsorted</param>
        /// <returns>The same array, but with all the values sorted from smallest to largest</returns>
        public static int[] InsertionSort(int[] arrToSort)
        {
            for (int i = 1; i < arrToSort.Length; i++)
            {
                int temp = arrToSort[i];
                int j = i - 1;
                while (j >= 0 && temp < arrToSort[j])
                {
                    arrToSort[j + 1] = arrToSort[j];
                    j--;
                }
                arrToSort[j + 1] = temp;
            }
            return arrToSort;
        }
        /// <summary>
        /// Utility method to quickly print all integers in an array to the screen
        /// </summary>
        /// <param name="arr">An array of integers to be printed</param>
        static void PrintArr(int[] arr)
        {
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}
