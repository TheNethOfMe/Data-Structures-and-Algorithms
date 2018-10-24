using System;
using stacks_and_queues.Classes;

namespace multi_bracket_validator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test1 = "The parenthesis do (not) matter.";
            Console.WriteLine(test1);
            Console.WriteLine(MultiBracketValidator(test1));
            string test2 = "That wasn't really it [I'm not dead. (Tee Hee)]";
            Console.WriteLine(test2);
            Console.WriteLine(MultiBracketValidator(test2));
            string test3 = "This )Will not work.";
            Console.WriteLine(test3);
            Console.WriteLine(MultiBracketValidator(test3));
            string test4 = "Neither will this(.";
            Console.WriteLine(test4);
            Console.WriteLine(MultiBracketValidator(test4));
            Console.ReadKey();
        }

        public static bool MultiBracketValidator(string stringToValidate)
        {
            Stack bracketStack = new Stack(new Node("Remove"));
            bracketStack.Pop();
            bool result = true;
            int i = 0;
            while (i < stringToValidate.Length && result)
            {
                switch (stringToValidate[i])
                {
                    case '(':
                        bracketStack.Push(new Node(')'));
                        break;
                    case '{':
                        bracketStack.Push(new Node('}'));
                        break;
                    case '[':
                        bracketStack.Push(new Node(']'));
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (bracketStack.Peek() == null || Convert.ToChar(bracketStack.Peek().Value) != stringToValidate[i])
                        {
                            result = false;
                        } else
                        {
                            bracketStack.Pop();
                        }
                        break;      
                }
                i++;   
            }
            if (bracketStack.Peek() != null)
            {
                result = false;
            }
            return result;
        }
    }
}
