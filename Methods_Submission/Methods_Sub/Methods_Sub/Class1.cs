using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Sub
{
    public class Class1
    {
        public int Add(int data, params int[] value) //method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result.
        {

            int i = 2;

            foreach (int num in value)
            {
                i *= num;
            }

            return data + i;
        }
    }
}
