using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constVariable = "This is my constant variable.";  //Create a const variable.
            Console.WriteLine(constVariable); 

            var variable = "This is my var variable."; //Create a variable using the keyword “var.”
            Console.WriteLine(variable); 

            Employee employee = new Employee("Eric"); 
            Console.WriteLine("The employee's name is {0}.", employee.Name); 
            Console.WriteLine("The employee's ID is {0}.", employee.Id); 
            Console.ReadLine();
        }

        public class Employee 
        {
            public Employee(string name) : this(name, 1) //Chain two constructors together.
            {

            }

            public Employee(string name, int id) 
            {
                Name = name; 
                Id = id; 
            }

            public string Name { get; set; } 
            public int Id { get; set; } 
        }
    }
}
