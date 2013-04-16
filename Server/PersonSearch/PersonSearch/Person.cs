using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonSearch
{
    public class Person
    {
        string name;
        string firstName;
        string lastName;
        int age;

        public Person() { }
        
        public Person(string firstname, string lastname, int age)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.age = age;
        }

        public string Name
        {
            get {return firstName + " " + lastName; }
            set { }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}