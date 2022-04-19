using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_NetFrwk_Scope
{
    internal class Program
    {
        // the i is at class level
        // the Scope of i is in Global for all static methods of the class
        static int i;
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Scope");
            i = 100;
            Console.WriteLine($"In Main method i = {i}");
            i++; // increment 101
            increment(); // 102
            //decrement(); // 101
            Console.ReadLine();
        }

        static void increment()
        {
            // Local declaration of i and j, but they are global to all programming blocks of the incfrement() method
            // Accessible only in the declaring method
            int i = 10;
            int j = 90;
            
            i++; // 11

            // the for..loop block
            // k is only for for..loop block
            for (int k = 0; k < 5; k++)
            {
                i++; // increment i in the loop,because i is global to loop
            }
            // now k is inaccessible
            int f = 100;
            decrement();
           


            Console.WriteLine($"In Increment i = {i}"); // i will be 16
        }

        static void decrement()
        {
            int i = 200;
            // Accessing i of the global class level declaration
            i--; // 101
            Console.WriteLine($"In Increment i = {i}");
            int j = i * i;
            Console.WriteLine($"In Increment j = {j}");
            int l = i++ + j * 10;
            Console.WriteLine($"In Increment l = {l}");
            int p = l * 4 + j;
            Console.WriteLine($"In Increment p = {p}");
        }
    }
}
