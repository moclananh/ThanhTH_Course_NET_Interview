using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string containing parentheses, brackets, and curly braces:");
        string input = Console.ReadLine();

        bool result = IsBalanced(input);
        Console.WriteLine(result);
    }
    //using Stack
    static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
    //using list
    /* static bool IsBalanced(string input)
     {
         List<char> stack = new List<char>(); ;
         int item = 0;
         foreach (char c in input)
         {
             if (c == '(' || c == '[' || c == '{')
             {
                 stack.Add(c);
             }
             else if (c == ')' || c == ']' || c == '}')
             {
                 if (stack.Count == 0) return false;
                 for (; item < stack.Count; item++) {
                     if ((c == ')' && stack[item] != '(') ||
                         (c == ']' && stack[item] != '[') ||
                         (c == '}' && stack[item] != '{'))
                     {
                         return false;
                     }
                 }
             }
         }
         return true;
     }*/
}
