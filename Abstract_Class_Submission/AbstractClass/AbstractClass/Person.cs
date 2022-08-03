using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person //Create an abstract class called Person with two properties: string firstName and string lastName.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName(); //Give it the method SayName().
    }
}
