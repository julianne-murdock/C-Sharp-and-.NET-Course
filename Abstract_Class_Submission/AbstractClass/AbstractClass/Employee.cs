using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person //Create another class called Employee and have it inherit from the Person class.
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName); //Implement the SayName() method inside of the Employee class.
            Console.ReadLine();
        }
    }
}
