using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
    class Program
    {
        static void Main(string[] args)
        {


            IQuittable emp1 = new Employee(); //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.

            emp1.Quit();


            Employee employee = new Employee();

            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();


        }
    }
}
