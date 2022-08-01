using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> things = new Employee<string>(); //Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.
            things.Things = new List<string>() { "thing 1 ", "thing 2 ", "thing 3" };

            Employee<int> intss = new Employee<int>(); //Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.
            intss.Things = new List<int>() { 1, 2, 3 };

            foreach (var thing in things.Things) //Create a loop that prints all of the Things to the Console.
            {
                Console.WriteLine(thing);
            }
            foreach (var ints in intss.Things) //another loop
            {
                Console.WriteLine(ints);
            }



            Console.ReadLine();
        }
    }
}
