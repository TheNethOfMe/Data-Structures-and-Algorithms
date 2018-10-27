using System;
using System.Collections.Generic;

namespace diminishing_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> optionList = GenerateList();
            PrintList(optionList);
            string result = Diminish(optionList, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static string Diminish(List<string> strList, int num)
        {
            Console.WriteLine("Diminishing");
            int pointer = num - 1;
            while (strList.Count > 1)
            {
                strList.RemoveAt(pointer);
                pointer = pointer + num;
                if (pointer >= strList.Count)
                {
                    pointer = pointer - strList.Count;
                }
                Console.WriteLine("++++++++");
                PrintList(strList);
            }
            return strList[0];
        }

        static List<string> GenerateList()
        {
            List<string> result = new List<string>
            {
                "test one",
                "test two",
                "test three",
                "test four",
                "test five",
                "test six"
            };
            return result;
        }

        static void PrintList(List<string> strList)
        {
            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
