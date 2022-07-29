using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there, what number do you want to use for our math calculations today?")
            int Choice = Convert.ToInt32(Console.ReadLine());
            var Value = Choice;

            var operatorObject = new Math();
            int result = operatorObject.Add(Value, 14);

            Console.WriteLine("The result of " + Choice + " + 14 is " + result);

            decimal Value2 = 5.5m
            int result2 = operatorObject.Add(Choice, Value2);
            Console.WriteLine("The result of" + Choice + " + 5.5 returned as an int is " + result2);

            string Value3 = "24";
            int result3 = operatorObject.Add(Choice, Value3);

            Console.WriteLine("The result of" + Choice + " + '24' returned as an int is " + result3);
            Console.ReadLine();

        }
    }
}
