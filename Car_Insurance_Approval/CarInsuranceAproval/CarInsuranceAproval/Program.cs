using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceAproval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Tech Academy's Car Insurance Approval ");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Please answer these questions");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("What is your age?"); //asks age
            string age = Console.ReadLine();
            int applicant_age = Convert.ToInt32(age);


            Console.WriteLine("Have you ever had a DUI? Answer 'true' for yes, or 'false' for no"); //did they have a DUI
            string dui = Console.ReadLine();
            bool applicant_dui = Convert.ToBoolean(dui);


            Console.WriteLine("How many speeding tickets do you have?"); //how many speeding tickets
            string tickets = Console.ReadLine();
            int applicant_tickets = Convert.ToInt32(tickets);

            bool eligible = false;

            if (applicant_age > 15 && applicant_dui == false && applicant_tickets < 3) //applicant older than 15, no DUIs, less than 3 speeding tickets
            {
                eligible = true;
            }
            else
            {
                eligible = false;
            }

            Console.WriteLine("Are you eligable for insurance? : " + eligible);

            Console.ReadLine();
        }
    }
}
