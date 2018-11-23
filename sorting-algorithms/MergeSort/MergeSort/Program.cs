using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] testArray = { 91, 8, 3, 0, 9, 7, 89, 1, 5, 4, 6, 12, 90, 40 };
            Console.WriteLine("Array before MergeSort.");
            PrintArr(testArray);
            MergeSort(testArray);
            Console.WriteLine("Array after MergeSort.");
            PrintArr(testArray);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        static void MergeSort(int[] arr)
        {
            if (arr.Length > 1)
            {
                int leftLength = arr.Length / 2;
                int[] left = new int[leftLength];
                Array.Copy(arr, 0, left, 0, leftLength);

                int rightLength = arr.Length - leftLength;
                int[] right = new int[rightLength];
                Array.Copy(arr, leftLength, right, 0, rightLength);

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }
        }

        static int[] Merge(int[] leftArr, int[] rightArr, int[] primeArr)
        {
            int l = 0;
            int r = 0;
            int p = 0;

            while (l < leftArr.Length && r < rightArr.Length)
            {
                if (leftArr[l] <= rightArr[r])
                {
                    primeArr[p] = leftArr[l];
                    l++;
                }
                else
                {
                    primeArr[p] = rightArr[r];
                    r++;
                }
                p++;
            }
            if (l == leftArr.Length)
            {
                Array.Copy(rightArr, r, primeArr, p, rightArr.Length - r);
            }
            else
            {
                Array.Copy(leftArr, l, primeArr, p, leftArr.Length - l);
            }
            return primeArr;
        }

        static void PrintArr(int[] arr)
        {
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
