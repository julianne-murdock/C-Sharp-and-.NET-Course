using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            var addition = new Math();
            int input1 = 5;
            int input2 = 4;
            addition.Add(input1, input2);
            Console.WriteLine(input2);
            Console.ReadLine();
        }
    }
}
