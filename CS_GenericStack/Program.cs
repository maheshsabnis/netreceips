using System;
using System.Collections.Generic;
namespace CS_GenericStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Danial Craig");
            stack.Push("Pierce Brosnon");
            stack.Push("Trimothy Dalton");
            stack.Push("Roger Moore");
            stack.Push("George Luznaby");
            stack.Push("Sean Connary");

            Console.WriteLine($"Length of Stack is = {stack.Count}");

           PrintData(ref stack);

            Console.WriteLine($"{stack.Pop()}"); // remove record on the top

            PrintData(ref stack);

            Console.WriteLine($"Record = {stack.Peek()}"); // Show the Top Record

            Console.ReadLine();
        }

        static void PrintData(ref Stack<string> stk)
        {
            foreach (var item in stk)
            {
                Console.WriteLine($"Entry in the Stack is  = {item}");
            }
        }
    }
}
