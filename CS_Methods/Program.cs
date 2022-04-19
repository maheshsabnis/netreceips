using System;

namespace CS_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a, b, c;
            Console.WriteLine("Enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToInt32(Console.ReadLine());
            // passing a and b to Add() method
            // a and b are known as 'Actual Parameters'
            c = Add(a, b);
            Console.WriteLine("Result c = " + c);
        }

        /// <summary>
        /// Method with return type as 'int'
        /// </summary>
        /// <returns></returns>
        static int Add(int x,int y)
        {
            // the 'z' is local variable to a method
            int z = 0;
            z =  x + y;
            return z;
        }
    }
}
