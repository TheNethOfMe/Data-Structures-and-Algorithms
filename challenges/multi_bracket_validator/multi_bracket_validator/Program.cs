using System;
using stacks_and_queues.Classes;

namespace multi_bracket_validator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The following is a test of the MultiBracketValidator method.");
            Console.WriteLine("If the parenthesis or brackets don't match, the output will be false.\n");
            string test1 = "The parenthesis do (not) matter.";
            Console.WriteLine($"INPUT: {test1}");
            Console.WriteLine($"OUTPUT: {MultiBracketValidator(test1)}\n");
            string test2 = "That wasn't really it [I'm not dead. (Tee Hee)]";
            Console.WriteLine($"INPUT: {test2}");
            Console.WriteLine($"OUTPUT: {MultiBracketValidator(test2)}\n");
            string test3 = "This )Will not work.";
            Console.WriteLine($"INPUT: {test3}");
            Console.WriteLine($"OUTPUT: {MultiBracketValidator(test3)}\n");
            string test4 = "Neither will this(.";
            Console.WriteLine($"INPUT: {test4}");
            Console.WriteLine($"OUTPUT: {MultiBracketValidator(test4)}\n");
            string test5 = "This has the right (matching but [in the wrong order)].";
            Console.WriteLine($"INPUT: {test5}");
            Console.WriteLine($"OUTPUT: {MultiBracketValidator(test4)}\n");
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
                    default:
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
