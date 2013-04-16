using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonSearch
{
    public class Person
    {
        string firstName;
        string lastName;
        int age;

        public Person(string firstname, string lastname, int age)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.age = age;
        }

        public string Name
        {
            get {return firstName + " " + lastName; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LasttName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}