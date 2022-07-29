using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodMath
{
    internal class Math
    {
        public int Add(int data, int value) // takes a int and int and returns the sum
        {
            return data + value;
        }

        public int Add(decimal data, int value) // takes a decimal and an int, changes the decimal to an int, returns the sum
        {
            int dData = Decimal.ToInt32(data);
            return dData + value;
        }

        public int Add(string data, int value) //takes a string and a int, convert the string representation of a number to its 32-bit signed integer equivalent, returns the sum
        {
            int sData = Int32.Parse(data);
            return sData + value;
    }
}
