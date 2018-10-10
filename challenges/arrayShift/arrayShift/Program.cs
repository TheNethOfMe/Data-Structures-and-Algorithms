using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Shift");
            Console.WriteLine("******************");
            TestEven();
            Console.WriteLine("******************");
            TestOdd();
            Console.WriteLine("******************");
            TestEmpty();
        }

        static int[] ArrayShift(int[] inputArr, int inputVal)
        {
            int[] result = new int[inputArr.Length + 1];
            for (int i = 0; i < result.Length; i++)
            {
                if (i < Math.Ceiling((decimal)(result.Length / 2)))
                {
                    result[i] = inputArr[i];
                }
                else if (i == Math.Ceiling((decimal)(result.Length / 2)))
                {
                    result[i] = inputVal;
                }
                else
                {
                    result[i] = inputArr[i - 1];
                }
            }
            return result;
        }

        static void TestEven()
        {
            Console.WriteLine("INPUT: [1, 2, 4, 5], 3");
            int[] testArr = { 1, 2, 4, 5 };
            int[] evenOutput = ArrayShift(testArr, 3);
            Console.WriteLine("EXPECTED: [1, 2, 3, 4, 5]");
            Console.WriteLine($"OUTPUT: {string.Join(", ", evenOutput)}");
        }

        static void TestOdd()
        {
            Console.WriteLine("INPUT: [1, 2, 4], 3");
            int[] testArr = { 1, 2, 4 };
            int[] evenOutput = ArrayShift(testArr, 3);
            Console.WriteLine("EXPECTED: [1, 2, 3, 4]");
            Console.WriteLine($"OUTPUT: {string.Join(", ", evenOutput)}");
        }

        static void TestEmpty()
        {
            Console.WriteLine("INPUT: [], 3");
            int[] testArr = { };
            int[] evenOutput = ArrayShift(testArr, 3);
            Console.WriteLine("EXPECTED: [3]");
            Console.WriteLine($"OUTPUT: {string.Join(", ", evenOutput)}");
        }
    }
}
