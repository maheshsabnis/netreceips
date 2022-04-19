using System;
using System.Collections;
namespace CS_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10); // integers
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add(40);
            arrayList.Add(50);
            arrayList.Add('A'); // characters
            arrayList.Add('B');
            arrayList.Add('C');
            arrayList.Add(10.5); // Floating
            arrayList.Add(20.1);
            arrayList.Add(30.2);
            arrayList.Add(40.3);
            arrayList.Add(50.4);
            arrayList.Add("Tejas"); // Strings
            arrayList.Add("Mahesh");
            arrayList.Add("Ramesh");
            arrayList.Add("Ram");
            arrayList.Add("Sabnis");

            // Read data from the collection
            foreach (object item in arrayList)
            {
                Console.WriteLine($"Value of item = {item} and type of item = {item.GetType()}");
            }

            Console.WriteLine("Read only Strings");
            foreach (object item in arrayList)
            {
                if (item.GetType() == typeof(string))
                {
                    Console.WriteLine($"Value = {item}");
                }
            }

            ArrayList arrayList2 = new ArrayList()
            { 
              100,200,99,98,300,201,204,203
            };
            arrayList2.Sort();
            foreach (object item in arrayList2)
            {
                Console.WriteLine($"Value of item = {item} and type of item = {item.GetType()}");
            }


            arrayList2.Reverse();
            foreach (object item in arrayList2)
            {
                Console.WriteLine($"Value of item = {item} and type of item = {item.GetType()}");
            }

            // Aarry of integer
            // By default this will be an instance of Array class
            // This if of the type 'ICollection'

            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            
            
            // .AddRange() accecept ICollection so we can pass array
            arrayList2.AddRange(arr);
            foreach (object item in arrayList2)
            {
                Console.WriteLine($"Value of item = {item} and type of item = {item.GetType()}");
            }

            arrayList2.Insert(0, 900);
            foreach (object item in arrayList2)
            {
                Console.WriteLine($"Value of item = {item} and type of item = {item.GetType()}");
            }

            arrayList2.InsertRange(0, arr);
            foreach (object item in arrayList2)
            {
                Console.WriteLine($"Value of item = {item} and type of item = {item.GetType()}");
            }

            // adding data at the end
            arrayList2.Insert(arrayList2.Count, 800);
            foreach (object item in arrayList2)
            {
                Console.WriteLine($"Value of item = {item} and type of item = {item.GetType()}");
            }
            Console.ReadLine();
        }
    }
}
