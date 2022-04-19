 using System;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// Entry Point of the Application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // lets add three integers
            int x = 0;
            int y = 0;
            int z = 0 ;

            // lets acept data for x and y from the end-user
            Console.WriteLine("Enter x");
            // whatever value read by the ReadLine() method, convert it into int
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            y = Convert.ToInt32(Console.ReadLine());

            z = x + y;

            // Print the Result
            // Concatinate the "z = " string with 'z' integer result
            // The WriteLine() method will auto-convert the integer into string while string
            // concatination
            Console.WriteLine("Add Result z = " + z);

            z =  x - y;
            Console.WriteLine("Substraction Result z = " + z);

            z = x * y;
            Console.WriteLine("Multiplication Result z = " + z);


            z = x / y;
            Console.WriteLine("Divistion Result z = " + z);

            Console.ReadLine();
        }
    }
}
