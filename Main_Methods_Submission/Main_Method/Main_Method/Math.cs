using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    public class Math
    {
        public int Add(int data, int value) //method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer.
        {
            return data + value;
        }

        public int Add(decimal data, int value) //method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.
        {
            int dData = Decimal.ToInt32(data);
            return dData + value;
        }

        public int Add(string data, int value) //method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.
        {
            int sData = Int32.Parse(data);
            return sData + value;
        }
    }
}
