using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsIntegersTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Create a list of integers.
            // Ask the user for a number to divide each number in the list by.
            // Write a loop that takes each integer in the list, divides it by the
            // number the user entered, and displays the result to the screen.
            

            //Part 2: Now put the loop in a try/catch block. Below and outside of the
            //try/catch block, make the program print a message to the display to let you
            //know the program has emerged from the try/catch block and continued on with
            //program execution. In the catch block, display the error message to the screen.
            //Then try various combinations of user input: valid numbers, zero and a string.
            //Ensure the proper error messages display on the screen, and that the code after
            //the try/catch block gets executed.
            try
            {
                List<int> testScores = new List<int>() { 100, 99, 98, 70, 80, 60 };
                Console.WriteLine("please type a number");
                int num = Convert.ToInt32(Console.ReadLine());
                foreach (int score in testScores)
                {
                    Console.WriteLine(score / num);
                }
            }
            catch (FormatException ex) //wrong format please fix
            {
                Console.WriteLine("Please type a whole number");
                Console.ReadLine();
            }
            catch (DivideByZeroException ex) //choose a different number specified
            {
                Console.WriteLine("Please type a non-zero, positive number");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

            finally
            {
                Console.WriteLine("the end");
                Console.ReadLine();
            }
        }
    }
}
