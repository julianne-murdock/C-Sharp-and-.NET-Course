using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6Parts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STEP 1: A one-dimensional array of strings. Ask the user to input some text.
            //A loop that iterates through each string in the array and adds the user's text input to the end of each string. This step will not output anything to the console, but will update each array element by appending the user's text.
            //Then create a second loop that prints off each string in the array one at a time.

            string[] stringArray = { "neon tetras", "beta fish", "albino corydora catfish", "upside down catfish" };

            Console.WriteLine("Enter an adjective that describes fish");
            string adj = (Console.ReadLine());

            for (int j = 0; j < stringArray.Length; j++)
            {

                {
                    Console.WriteLine(adj + " " + stringArray[j]);

                }
            }


            //STEP 2  An infinite loop. Fix the infinite loop so that it will execute properly.

            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine("I fixed the infinite loop" + adj);
            }


            //STEP 3  A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            //Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.

            for (int b = 0; b < 3; b++)
            {
                Console.WriteLine("the comparison that’s used to determine whether to continue iterating the loop is a  '<'" + adj);
            }

            for (int c = 0; c <= 6; c++)
            {
                Console.WriteLine("the comparison that’s used to determine whether to continue iterating the loop is a  '<='" + adj);
            }


            //STEP 4 A list of strings where each item in the list is unique.
            //Ask the user to input text to search for in the list.
            //A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            //Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list. 
            //Add code that stops the loop from executing once a match has been found.

            string[] stringArray2 = { "neon tetras", "beta fish", "albino corydora catfish", "upside down catfish" };

            Console.WriteLine("guess a type of fish to see if it is in the secret list! (please use only lower case letters and some names may have two words)");
            string guess = (Console.ReadLine());

            for (int j = 0; j < stringArray2.Length; j++)
            {
                if (stringArray2[j] == guess)
                {
                    Console.WriteLine("Yes, your guess of " + stringArray2[j] + " is in the list!");
                    break;
                }
                else
                {
                    Console.WriteLine("Your guess " + "'" + guess + "'" + " is not in the secret list");
                    Console.WriteLine("*HINT* this fish lives in a smaller tank and has huge wavy fins (make sure your guess is lowercase and it could have two words)");

                    Console.WriteLine("Please guess again");
                    guess = (Console.ReadLine());

                    if (stringArray2[j] == guess)
                    {
                        Console.WriteLine("Yes, your guess of " + stringArray2[j] + " is in the list!");
                        break;
                    }

                }
            }


            //STEP 5  A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            //Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text.Ensure to remove any break statements that may prevent your code from returning multiple matches.
            //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list. (You do not need to provide any additional chances for the user to enter text.)

            List<string> fruit = new List<string>() { "apple", "banana", "cherry", "grape", "peach", "pear", "peach" };

            Console.WriteLine("guess a type of fruit, make sure you use all lowercase");
            string aGuess = (Console.ReadLine());

            bool matchExists = false;

            for (int fru = 0; fru < fruit.Count; fru++)
            {
                if (fruit[fru] == aGuess)
                {
                    matchExists = true;
                    Console.WriteLine(fru + aGuess);
                }
                if (matchExists == false)
                {
                    Console.WriteLine("Sorry, this is not in the list");

                }
            }




            //STEP 6 Create a list of strings that has at least two identical strings in the list.
            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.



            List<string> names2 = new List<string>() { "Julianne", "Julianne", "Brice", "Bertrand", "Julianne", "Brice", "Murdock", "Julianne" };
            List<string> repeat = new List<string>();
            bool matchExists2 = false;
            int count2 = 0;


            //FOR EACH HERE
            foreach (string name in names2)
            {
                Console.WriteLine("-------------------- \n" + name);
                for (int nam = 0; nam < repeat.Count; nam++)
                {

                    if (repeat[nam] == name)
                    {
                        matchExists2 = true;

                        Console.WriteLine(" *this has already shown up in the list* ");
                        break;

                    }


                }

                repeat.Add(name);




            }




            Console.ReadLine();
        }
    }
}
