using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int CheckArrayForValue(int[] arr, int val)
        {
            int mid;
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (arr[mid] == val)
                {
                    return mid;
                }
                else if (arr[mid] < val)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
