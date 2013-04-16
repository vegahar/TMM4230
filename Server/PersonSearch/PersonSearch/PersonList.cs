using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonSearch
{
    public class PersonList
    {
        
        private List<Person> list = new List<Person>();

        public PersonList()
        {
            list.Add(new Person("Vegard", "Harper",21));
            list.Add(new Person("Ola", "Nordmann", 1));
            list.Add(new Person("Barack", "Obama", 50));
            list.Add(new Person("Harald", "Kongen", 44));
            list.Add(new Person("Steve", "Jobs", 13));
            list.Add(new Person("Bill", "Gates", 1));
            list.Add(new Person("Linus", "Torvald", 50));
            list.Add(new Person("Warren", "Buffet", 50));

        }


        public void addPerson(Person a) {
            list.Add(a);
        }
        public List<Person> getAllPersons() {
            return list;
        }
        public List<Person> searchAge(int value)
        {
             List<Person> result = new List<Person>();
            foreach(Person a in list)
            {
                if(a.Age == value){
                    result.Add(a);
                }
            }
            return result;
        }

        public List<Person> search(string searchString)
        {
            int value = 0;
            bool isValue = Int32.TryParse(searchString, out value);
            if (isValue)
            {
                return searchAge(value);
            }

           List<Person> result = new List<Person>();
           foreach(Person a in list )          
           {
               if (a.Name.Contains(searchString))
               {
                   result.Add(a);
               }
           }
           return result;
        }

    }
}