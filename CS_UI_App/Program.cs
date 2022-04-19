using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_DataStore;
namespace CS_UI_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person INforation System");
            Console.ReadLine();
            DataStore obj = new DataStore();
            var people = obj.GetPersons();
            foreach (var person in people)
            {
                Console.WriteLine($"{person.PersonId} {person.PersonName}");
            }

            Console.ReadLine(); 
        }
    }
}
