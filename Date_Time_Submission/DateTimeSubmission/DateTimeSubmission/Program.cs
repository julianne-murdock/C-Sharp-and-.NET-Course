using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Time Travel Program\n");
            System.Threading.Thread.Sleep(1000);
            DateTime date = DateTime.Now;
            Console.WriteLine("The Time Is: " + date); //Prints the current date and time to the console.
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nHow Many Hours Into The Future Do You Want To Go?");
            int answer = Convert.ToInt32(Console.ReadLine()); //Asks the user for a number.

            TimeSpan time = new TimeSpan(0, answer, 0, 0);
            DateTime combined = date.Add(time);
            Console.WriteLine("The Time Is Now: " + combined); //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nThankyou for using The Time Travel Program");


            Console.ReadLine();
        }
    }
}
