using System;
using hashTables.Classes;

namespace repeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test1 = "A quick brown fox jumped over the lazy dog.";
            Console.WriteLine($"Test string one: {test1}");
            string result1 = RepeatedWord(test1);
            Console.WriteLine($"Result: {result1}");
            string test2 = "There's something strange going on tonight. Here's something going on that's not quite right.";
            Console.WriteLine($"Test string two: {test2}");
            string result2 = RepeatedWord(test2);
            Console.WriteLine($"Result: {result2}");
            Console.ReadLine();
        }
        /// <summary>
        /// Takes in a string with multiple words and returns the first repeated word in the input string.
        /// </summary>
        /// <param name="text">The string containing text to be checked for repeated words</param>
        /// <returns>The first repeated word found in the input text</returns>
        public static string RepeatedWord(string text)
        {
            string result = null;
            string[] words = text.Split(' ');
            HashTable checkTable = new HashTable(1024);
            int i = 0;
            while (i < words.Length && result == null)
            {
                if (checkTable.Contains(words[i].ToLower()))
                {
                    result = words[i].ToLower();
                }
                else
                {
                    checkTable.Add(words[i].ToLower(), words[i].ToLower());
                    i++;
                }
            }
            return result;
        }
    }
}
