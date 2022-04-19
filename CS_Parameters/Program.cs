using System;

namespace CS_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xchange");
            int a = 10, b = 20;
            Console.WriteLine($"Befor XChange call a = {a}, b = {b}");
            XChange(a, b);
            Console.WriteLine($"After XChange call a = {a}, b = {b}");
            Console.WriteLine("Using ref");
            Console.WriteLine($"Befor XChangeRef call a = {a}, b = {b}");
            XChangeRef(ref a, ref b);
            Console.WriteLine($"After XChangeRef call a = {a}, b = {b}");
            Console.WriteLine("Using out");
            int p, q;
            ProcessOut(out p, out q);
            Console.WriteLine($"After ProcessOut call p = {p} , q = {q}");
            string str = "James Bond is Golden Agent of MI-16";
           // bool isExist;
           // inline declaration of an out parameter to a method is also allowed from C# 5.0+  
            CheckIfContainsCharacter(str, 'G', out bool isExist);
            Console.WriteLine($"{str} contains 'G' = {isExist}");

            Console.WriteLine($"2 parameters {FlexiAdd(1,2)}");
            Console.WriteLine($"2 parameters {FlexiAdd(1, 2,3)}");
            Console.WriteLine($"3 parameters {FlexiAdd(1, 2,3,4)}");
            Console.WriteLine($"5 parameters {FlexiAdd(1, 2,3,4,5)}");
            Console.WriteLine($"6 parameters {FlexiAdd(1, 2,3,4,5,6)}");

        }

        /// <summary>
        /// x and y are pass by value
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void XChange(int x, int y)
        {
            Console.WriteLine($" In Method Before XChange x = {x}, y = {y}");
            int z = x;
            x = y;
            y = z;
            Console.WriteLine($" In Method After XChange x = {x}, y = {y}");
        }

        /// <summary>
        /// Passed by reference
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void XChangeRef(ref int x, ref int y)
        {
            Console.WriteLine($" In Method Before XChangeRef x = {x}, y = {y}");
            int z = x;
            x = y;
            y = z;
            Console.WriteLine($" In Method After XChangeRef x = {x}, y = {y}");
        }

        /// <summary>
        /// x and y will be processed (or initialized) inside the method
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void ProcessOut(out int x, out int y)
        {
            x = 100;
            y = 200;
            Console.WriteLine($" In Method After XChangeRef x = {x}, y = {y}");
        }

        /// <summary>
        /// a method that will check is 'str' contains character 'c'
        /// if yes then exist will be 'true' else 'false'
        /// </summary>
        /// <param name="c"></param>
        /// <param name=""></param>
        /// <param name=""></param>
        static void CheckIfContainsCharacter(string str, char c, out bool exist)
        {
            exist = str.Contains(c);
        }

        /// <summary>
        ///  x will be an array 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int FlexiAdd(params int [] x)
        {
            int sum = 0;
            foreach (int n in x)
            {
                sum += n;
            }    
            return sum;
        }
    }
}
