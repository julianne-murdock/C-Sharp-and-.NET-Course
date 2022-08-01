using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! Type a number you want to use for the math operations today."); //allows user to type in nummber for the operations
            int Choice = Convert.ToInt32(Console.ReadLine());
            var Value = Choice; //makes the int value from the user into a var

            var operatorObject = new Math(); //uses the math class to preform operations
            int result = operatorObject.Add(Value, 14);

            Console.WriteLine("The result of " + Choice + " + 14 is " + result);

            decimal Value2 = 5.5m;
            int result2 = operatorObject.Add(Value2, Value);
            Console.WriteLine("The result of " + Choice + " + 5.5 returned as an int is " + result2);

            string Value3 = "24";
            int result3 = operatorObject.Add(Value3, Value);

            Console.WriteLine("The result of " + Choice + " + '24' returned as an int is " + result3);
            Console.ReadLine();
        }
    }
}
