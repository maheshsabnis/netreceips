using System;
using System.Collections.Generic;
namespace CS_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 200, 300, 400, 500, 600,1 };
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.AddRange(arr);


            //foreach (int item in intList)
            //{
            //    Console.WriteLine(item);
            //}

            intList.Sort();
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            intList.RemoveAt(3); // remove rcord at 4th position
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            intList.RemoveRange(1,3); // From first index total 3 records are removed
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }

            List<string> strList = new List<string>();
            strList.Add("Tejas");




            Console.ReadLine();
        }
    }
}
