using System;
class DailyReport
{
    static void Main()
    {

        Console.WriteLine("\nThe Tech Academy\n");
        Console.WriteLine("Student Daily Report Submission\n");

        Console.WriteLine("What is your name?"); //Asks the student for name
        string name = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("What page number?");
        int pageNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
        bool needHelp = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("\n");

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string posXp = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("How many hours did you study today?");
        double studyHrs = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n");

        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        Console.ReadLine();
    }
}