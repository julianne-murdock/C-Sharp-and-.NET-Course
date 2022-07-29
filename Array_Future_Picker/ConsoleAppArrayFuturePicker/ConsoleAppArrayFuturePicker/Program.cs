using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayFuturePicker
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Future Picker. Please follow the instructions below.");

            System.Threading.Thread.Sleep(1000);


            // CONSOLE APP ARRAY SUBMISSION

            //Array sub: an array of strings is shown in question 1, an array of integers is in question 2,
            //Array sub: this doesn't exist message is under the while loop in question 1
            //Array sub: list of strings and selecting an index of the list is in all questions and displaying the content at that index on the screen is at the end after all questions are answered.


            //PICK CAREER
            Console.WriteLine("Pick your career:" + "\n1: Software Developer" + "\n2: Entrepreneur" + "\n3: Artist" +  
                "\n4: Content Creator" + "\n5: Engineer" + "\n6: Missionary" + "\n7: Travel Agent" + "\n8: Life Insurance Agent");
            Console.WriteLine("*ENTER NUMBER BETWEEN 1-8 TO INDICATE CHOICE*");
            int cChoice = Convert.ToInt32(Console.ReadLine());

           
            while (cChoice > 8 || cChoice < 1)
            {
                Console.WriteLine("OPS THAT WASN'T AN OPTION... *ENTER NUMBER BETWEEN 1-8 TO INDICATE CHOICE*");
                cChoice = Convert.ToInt32(Console.ReadLine());

            }
            
            string[] careerType = { "Software Developer", "Entrepreneur", "Artist", "Content Creator", "Engineer", "Missionary", "Travel Agent", "Life Insurance Agent" };
            //END CAREER PICK


            //PICK HOW MANY KIDS
            Console.WriteLine("Choose how many kids you want in your family (your choice will inversely effect your multitasking Level)");
            Console.WriteLine("*ENTER NUMBER BETWEEN 1-6 TO INDICATE CHOICE*");
            int kidsChoice = Convert.ToInt32(Console.ReadLine());
            int[] howManyKids = { 1, 2, 3, 4, 5, 6 };

            while (kidsChoice > 6 || kidsChoice < 1)
            {
                Console.WriteLine("OPS THAT WASN'T AN OPTION... *ENTER NUMBER BETWEEN 1-6 TO INDICATE CHOICE*");
                kidsChoice = Convert.ToInt32(Console.ReadLine());

            }
            //END HOW MANY KIDS


            //PICK AGE
            Console.WriteLine("Choose your age to start your career (the younger you are the more time you have, \nbut the older you are the more intelligence you have) ");
            Console.WriteLine("1: Young" + "\n2: Middle Aged" + "\n3: Elder");
            Console.WriteLine("*ENTER NUMBER BETWEEN 1-3 TO INDICATE CHOICE*");
            int ageChoice = Convert.ToInt32(Console.ReadLine());


            while (ageChoice > 3 || ageChoice < 1)
            {
                Console.WriteLine("OPS THAT WASN'T AN OPTION... *ENTER NUMBER BETWEEN 1-3 TO INDICATE CHOICE*");
                ageChoice = Convert.ToInt32(Console.ReadLine());

            }

           

            List<string> ageList = new List<string>();
            ageList.Add("Young");
            ageList.Add("Middle Aged");
            ageList.Add("Elder");






            

            int A = ageChoice - 1;

            int X = cChoice - 1;

            int Y = kidsChoice - 1;

            int D = 5 * kidsChoice;

            int H = 100 - (20 * ageChoice);

            int I = 20 + (20 * ageChoice);

            Console.WriteLine("\n" + "Your Future is a: " + ageList[A] + " " + careerType[X] + " with a total of "
                + howManyKids[Y] + " kids."+ "\nAnd an Multitasking Level of: " + D + " out of 30");
            Console.WriteLine("\nBecause of your age,\nYour Health Level is set to: " + H + " out of 100" +
                "\nAnd Your Intelligence Level is: " + I + " out of 100");



            Console.ReadLine();
        }
    }
}
