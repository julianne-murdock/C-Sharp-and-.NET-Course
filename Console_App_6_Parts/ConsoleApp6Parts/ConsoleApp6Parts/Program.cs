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

            string[] stringArray = { "neon tetra", "beta fish", "albino corydora catfish", "upside down catfish" };

            Console.WriteLine("Enter a verb that describes what your fish are currently doing");
            string adj = (Console.ReadLine());

            for (int j = 0; j < stringArray.Length; j++)
            {
                stringArray[j] = stringArray[j] + " is " + adj; // adds user input to the end of each index value with a space between
            }

            for (int j = 0; j < stringArray.Length; j++) // loops through updated array
            {
                Console.WriteLine("Here is what your fish are all doing: " + stringArray[j]); // prints each index
            }
            Console.ReadLine();   


            //STEP 2  An infinite loop. Fix the infinite loop so that it will execute properly.
            //I fixed it by adding in "a < 5;" so that way it stops when a is greater than 5.

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

            List<string> fishColors = new List<string>() { "blue", "green", "purple" };
            Console.WriteLine("I have 3 fish! What color do you think one of my fish are? (lowercase):");
            string userGuess = Console.ReadLine();
            Console.WriteLine(); //Line Break.
            for (int j = 0; j < 1; j++)
            {
                if (userGuess == "blue")
                {
                    Console.Write("Index Number: " + fishColors.IndexOf("blue"));
                    Console.ReadLine();
                    break;
                }
                if (userGuess == "green")
                {
                    Console.Write("Index Number: " + fishColors.IndexOf("green"));
                    Console.ReadLine();
                    break;
                }
                if (userGuess == "purple")
                {
                    Console.Write("Index Number: " + fishColors.IndexOf("purple"));
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Write("Sorry, that's not on the list.");
                    Console.ReadLine();
                    break;
                }
            }
                   Console.WriteLine(); //Line Break.


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
                    Console.ReadLine();
                }
                
            }

            if (matchExists == false)
                {
                    Console.WriteLine("Sorry, this is not in the list");
                    Console.ReadLine();

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
                    else
                    {

                        Console.WriteLine(" *this has not shown up in the list already* ");
                        break;

                    }


                }

                repeat.Add(name);




            }




            Console.ReadLine();
        }
    }
}
