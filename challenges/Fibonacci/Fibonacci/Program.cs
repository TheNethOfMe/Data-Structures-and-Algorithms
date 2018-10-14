using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LoopProgram();
            Console.WriteLine("\nGoodbye.\nPress any key to exit...");
            Console.ReadKey();
        }

        static int GetFibonacciSequenceAtIndex(int index)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < index; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void LoopProgram()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nWhich index in the Fibonacci Sequence would you like?");
                    int num = int.Parse(Console.ReadLine());
                    int result = GetFibonacciSequenceAtIndex(num);
                    Console.WriteLine($"\nThe answer is {result}");
                    Console.WriteLine("Do you want to get another Fibonacci index?");
                    if (Console.ReadKey().KeyChar != 'y')
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You need to enter a number.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, something went wrong.");
                }
            }
        }
    }
}
