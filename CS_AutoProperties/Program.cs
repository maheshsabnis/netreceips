using System;

namespace CS_AutoProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            // Calling Setter to write the data
            Console.WriteLine("Accept Person Id");
            person.PersonId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Accept Person Name");
            person.PersonName = Console.ReadLine();
         //   person.Address = "ddd"; // error

            // Calling Getter to read data
            Console.WriteLine($"Person = {person.PersonId} {person.PersonName}");
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Class with Auto-Implemented Properties
    /// </summary>
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string Address { get; private set; } // Read-Only property
        public int Income { get; } // Read-Only property
    }
}
