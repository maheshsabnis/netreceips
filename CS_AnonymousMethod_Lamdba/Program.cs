using System;

namespace CS_AnonymousMethod_Lamdba
{
    public delegate int ProcessHandler(int x, int y);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Anonymous Method");

            ProcessHandler handler = new ProcessHandler(Addition);
            Console.WriteLine($"C# 1.x Delegate Use = {handler(100,200)}");

            Console.WriteLine();
            Console.WriteLine("Using C# 2.0 Anonymous Method");
            // Directly passing method implementation
            handler = delegate (int x, int y) { return x + y; };
            Console.WriteLine($"C# 2.0 Anonymous Method call is = {handler(100,200)}");


            Console.WriteLine("Usign a Method that is accepting Delegate as Input parameter");
            // Currently Execute an Anonymous Method
            Process(handler);
            Console.WriteLine("C# 2.0 Passsing an Implementation Directly to Proecss() method");
            // Complex Syntax
            Process(delegate (int a,int b) { return a * b; });

            Console.WriteLine("C# 3.0 using Lambda Expression");
            Process((int x,int y) => { return x * x * y * y; });



            Console.ReadLine(); 
        }


        static int Addition(int x, int y)
        { 
            return x + y;
        }

        /// <summary>
        /// A method that accepts a delegate
        /// </summary>
        /// <param name="handler"></param>
        static void Process(ProcessHandler handler)
        {
            Console.WriteLine($"In Method Handler = {handler(40,90)}");
        }
    }
}
