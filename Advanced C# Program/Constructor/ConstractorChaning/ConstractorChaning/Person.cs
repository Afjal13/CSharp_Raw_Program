using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstractorChaning
{
    public class Person
    {
        private string? firstName;
        private string? middleName;
        private string? lastName;


        public Person(string firstName, string middleName, string lastName):this(firstName,lastName)
        {
            this.middleName = middleName;
        }
        public Person(string firstName, string lastName):this(firstName)
        {
            this.lastName = lastName;
        }

        public Person(string firstName):this()
        {
            this.firstName = firstName;
        }

        public Person() { }



        public string GetName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
    }
}
