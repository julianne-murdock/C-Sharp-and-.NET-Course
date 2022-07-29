using System;

namespace myConsoleProject.cs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum + 5;
            Console.WriteLine( "Your favorite Number plus 5 is " + total);
            Console.Read();
        }
    }
}
