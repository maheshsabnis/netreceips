using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DataStore
{
    public class DataStore
    {
        private List<Person> People;

        public DataStore()
        {
            People = new List<Person>();    
            People.Add(new Person() {PersonId=1,PersonName="P1" });
            People.Add(new Person() { PersonId = 2, PersonName = "P2" });
            People.Add(new Person() { PersonId = 3, PersonName = "P3" });
            People.Add(new Person() { PersonId = 4, PersonName = "P4" });
        }


        public IEnumerable<Person> GetPersons()
        {
            Console.WriteLine("I am Returning the Person Data");
            return People;
        }

        public IEnumerable<Person> AddPerson(Person person)
        {
            People.Add(person);
           
            return People;
        }


        public Person GetPerson(int id)
        {
            return People.Where(p=>p.PersonId == id).FirstOrDefault();
        }
    }


}
