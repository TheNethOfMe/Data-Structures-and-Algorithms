using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! We're using quick sort on the following array...");
            int[] myArray = { 666, 238, 5, 90, 420, 50, 70, 42, 99 };
            PrintArr(myArray);
            QuickSort(myArray);
            Console.WriteLine("After Sorting...");
            PrintArr(myArray);
            Console.WriteLine("Thank you for coming to my Ted Talk. Press Enter to Exit.");
            Console.ReadLine();
        }

        static void QuickSort(int[] arrToSort)
        {
            QuickSortAction(arrToSort, 0, arrToSort.Length - 1);
        }

        static void QuickSortAction(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);
                QuickSortAction(arr, left, position - 1);
                QuickSortAction(arr, position + 1, right);
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;
            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }

        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

        static void PrintArr(int[] arrToPrint)
        {
            Console.Write("( ");
            foreach (int x in arrToPrint)
            {
                Console.Write($"{x} ");
            }
            Console.Write(")\n");
        }
    }
}
