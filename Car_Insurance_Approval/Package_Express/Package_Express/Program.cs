using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Please enter the package weight:"); //Enters package weight
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50) //if weight is greater than 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            }
            else //if package is not greater than 50
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                if (width + height + length > 50) // If the package dimensions greater than 50
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else //if the package dimensions is less than 50
                {
                    int area = width * height * length; //multiply all three dimensions together
                    int total = (area * weight) / 100; //multiply the product by weight and divide by 100

                    Console.WriteLine("Your estimated total for shipping this package is: $" + total + ".00, Thank you!"); // print out the total cost of package
                }
            }

            Console.ReadLine();

        }
    }
}
