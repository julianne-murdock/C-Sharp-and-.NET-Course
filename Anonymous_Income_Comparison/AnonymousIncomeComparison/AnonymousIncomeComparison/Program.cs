﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Anonymous Income Comparison Program!)");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("We will now compare 2 peoples income");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?"); //hourly rate of person 1
            string p1hr = Console.ReadLine();
            int hourly_rate_p1 = Convert.ToInt32(p1hr);

            Console.WriteLine("How many hours do you work per week?"); //hours per week person 1
            string p1hpw = Console.ReadLine();
            int hours_per_week_p1 = Convert.ToInt32(p1hpw);

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?"); //hourly rate of person 2
            string p2hr = Console.ReadLine();
            int hourly_rate_p2 = Convert.ToInt32(p2hr);

            Console.WriteLine("How many hours do you work per week?"); //hours per week person 2
            string p2hpw = Console.ReadLine();
            int hours_per_week_p2 = Convert.ToInt32(p2hpw);

            int person1_salary = hourly_rate_p1 * hours_per_week_p1 * 52; //yearly salary person 1
            int person2_salary = hourly_rate_p2 * hours_per_week_p2 * 52; //yearly salary person 2


            if (person1_salary < person2_salary)
            {
                bool comp = false; //if person 1 makes more than person 2
                Console.WriteLine("Annual salary of Person 1: " + person1_salary);
                Console.WriteLine("Annual salary of Person 2: " + person2_salary);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Does Person 1 make more money than Person 2 ?" + " " + comp);
                Console.ReadLine();
            }
            else
            {
                bool comp = true; //if person 1 makes less than person 2
                Console.WriteLine("Annual salary of Person 1: " + person1_salary);
                Console.WriteLine("Annual salary of Person 2: " + person2_salary);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Does Person 1 make more money than Person 2 ?" + " " + comp);
                Console.ReadLine();
            }
    }
}
