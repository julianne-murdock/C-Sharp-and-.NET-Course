using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To the Day Of The Week App!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Please enter what day it is today... (ex 'Monday')");//Prompt the user to enter the current day of the week.
            string dayAnswer = (Console.ReadLine());


             try //try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
            {
                Day day = (Day)Enum.Parse(typeof(Day), dayAnswer); //Assign the value to a variable of that enum data type you just created.
                if (Enum.IsDefined(typeof(Day), day))
                {
                    Console.WriteLine("Good job!");
                    Console.ReadLine();
                }

            }

            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
            }
        }


    }
}
