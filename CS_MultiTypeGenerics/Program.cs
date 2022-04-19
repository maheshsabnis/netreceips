using System;
using System.Collections.Generic;
namespace CS_MultiTypeGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> movies = new Dictionary<int,string>();

            movies.Add(1, "Dr.No");
            movies.Add(2, "Thunbderball");
            movies.Add(3, "From Russia With Love");
            movies.Add(4, "Specre");
            movies.Add(5, "Anajm");
            movies.Add(6, "Movie 001");
            movies.Add(7, "Movie 002");
            movies.Add(8, "Movie 003");
            movies.Add(9, "Movie 004");
            movies.Add(10, "Movie 005");


            Console.WriteLine($"{movies.TryGetValue(4, out string movieName)}");
            Console.WriteLine(movieName);

            PrintValues(ref movies) ;

            // Defining Complex Dictionary

            Dictionary<int, List<string>> complexDict = new Dictionary<int, List<string>>();
            complexDict.Add(1, new List<string>() {"James Bond", "Jason Bourn", "Indiana Jones", "Ethan Hunt", "Jack Reacher" });
            complexDict.Add(2, new List<string>() { "M", "Q", "C" });
            complexDict.Add(1, new List<string>() {"A", "B", "C" }); // Repeat the Key (Exception)

            Console.WriteLine($"Value for Key 1 is = {complexDict.TryGetValue(1, out List<string> lst)}");

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

          


            Console.ReadLine();
        }


        static void PrintValues(ref Dictionary<int, string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"key = {item.Key} and value = {item.Value}");
            }
        }


    }
}
