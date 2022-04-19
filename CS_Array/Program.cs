using System;

namespace CS_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array definition and initialization (Implicit max length for arr will be 3)
            int[] arr = {10,20,30 };
            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine($"Length of {arr} is = {arr.Length}");
            //arr[3] = 40; // error
            //Console.WriteLine(arr[3]);

            // defining an array with an explicit size aka upper limit
            int[] arr2 = new int[5]; // restrictions for max size as 5 recodrs
            // initialize values
            arr2[0] = 10;
            arr2[1] = 20;
            arr2[2] = 30;
            arr2[3] = 40;
            arr2[4] = 50;
            foreach (int n in arr2)
            {
                Console.WriteLine(n);
            }
            //arr2[5] = 60; // error
            //Console.WriteLine(arr[5]);
            //arr2[6] = 70; // error
            //Console.WriteLine(arr[6]);

            
             

            Console.ReadLine();
        }
    }
}
