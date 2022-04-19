using System;

namespace CS_If_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a, b, c;
            Console.WriteLine("Enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToInt32(Console.ReadLine());
            // passing a and b to Add() method
            // a and b are known as 'Actual Parameters'
            c = AddWithIfElseOneReturn(a, b);
            Console.WriteLine("Result c = " + c);
            DoNoReturn(a, b);
        }

        /// <summary>
        /// Method with return type as 'int'
        /// </summary>
        /// <returns></returns>
        static int Add(int x, int y)
        {
            if (x == 0) 
            {
                // directly return from the method
                return 0;
            } 
            // if the 'if' condition is true, then following statements will not be executed
            int z = 0;
            z = x + y;
            return z;
        }

        static int AddWithIfElse(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }
            else
            {
                int z = 0;
                z = x + y;
                return z;
            }
        }
        /// <summary>
        ///  If the if..else... block is processng data based on condition (if/else) then out of the if..else.. block return the data with return statement. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int AddWithIfElseOneReturn(int x, int y)
        {
            int z = 0;
            if (x == 0 || y == 0)
            {
                z = 0;
            }
            else
            {
                z = x + y;
            }
            // Single Return Statement
            return z;
        }

        static void DoNoReturn(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Add = " + z);
        }
    }
}
