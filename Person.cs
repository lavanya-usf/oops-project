using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_project
{
    internal class Person
    {
        public String firstName, lastName;
        public static string salutationMs = "Miss.";
        public string salutation;

        public Person() 
        {
            firstName = "Lavanya";
            lastName = "ch";
           salutation = salutationMs;
        }

        public Person(String FirstName, String LastName, string salutation)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.salutation = salutation;
        }

        public String getName() { 
            return firstName + " " + lastName; 
        }
    }
}
