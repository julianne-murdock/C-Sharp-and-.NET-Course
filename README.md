# C-Sharpe-and-.NET-Course

These are projects I completed during my time at The Tech Academy, from 2021 to 2022. Some of these projects are terminal-based outputs, while others are rendered in the browser.

## Terminal Based Projects:
- Abstract Class Submission
- Anonymous Income Comparison
- Array Future Picker
- Basic C# Programs
- Calling Methods
- Car Insurance Approval

### Abstract Class Submission
This project demonstrates the use of abstract classes and inheritance in C#. It consists of three main files: Program.cs, Person.cs, and Employee.cs. In the Program.cs file, an Employee object is instantiated with first name "Sample" and last name "Student", and its SayName() method is called to display the full name. The Person.cs file contains the abstract class Person, which defines two properties, FirstName and LastName, and an abstract method SayName(). The Employee.cs file defines the Employee class, which inherits from Person and implements the SayName() method to display the employee's full name. This project demonstrates the basics of inheritance and overriding methods in object-oriented programming.

### Anonymous Income Comparison
This program compares the annual salaries of two individuals based on their hourly rates and weekly working hours. In the Program.cs file, the user is prompted to enter the hourly rate and weekly working hours for both Person 1 and Person 2. The program then calculates the annual salaries for both individuals by multiplying their hourly rate, weekly hours, and 52 (the number of weeks in a year). After calculating the salaries, the program compares them and displays which person earns more, including their respective annual salaries. The program also uses sleep intervals to enhance the user experience between prompts and results.

### Array Future Picker
The ConsoleAppArrayFuturePicker (app folder name) program is an interactive console application where the user can explore a simulated future based on their career choice, number of children, and age. In the Program.cs file, users are prompted to choose their career from a list of eight options, select the number of children they wish to have, and decide their starting age (young, middle-aged, or elder). Based on these inputs, the program calculates and displays a simulated "future" that includes the chosen career, number of children, multitasking level, health level, and intelligence level. The program uses arrays and lists to store career and age options, and it ensures that the user's inputs are valid through while loops. The output provides a fun, personalized view of a hypothetical future.

### Basic C# Programs
This simple console application asks the user for their name and favorite number, then provides personalized responses. In the Program.cs file, the program first prompts the user for their name and greets them with a message. Next, it asks for the user's favorite number, converts it to an integer, adds 5 to it, and displays the result. The program makes use of basic input and output operations, string manipulation, and type conversion. It provides a straightforward demonstration of working with user input and performing basic arithmetic operations in C#.

### Calling Methods Project
The Calling_Methods project demonstrates the use of methods for basic arithmetic operations in C#. It consists of two main files: Program.cs and Class1.cs. In Program.cs, the user is prompted to enter a number, which is then processed through a series of mathematical operations (addition, subtraction, and division) using methods from the Math class. The program creates an instance of the Math class and calls its methods—Add, Sub, and Div—to compute the result step by step, displaying each intermediate result to the user. The Math class in Class1.cs contains these methods, which perform the respective operations on the given data and return the result. This project demonstrates how to define and use methods to handle different operations on input data.

### Car Insurance Approval
The CarInsuranceApproval project is a simple console application that determines whether a person is eligible for car insurance based on their age, DUI history, and number of speeding tickets. In the Program.cs file, the program prompts the user to input their age, whether they have ever had a DUI (answered as true or false), and the number of speeding tickets they have received. The program then checks if the applicant is over 15 years old, has no DUIs, and has fewer than 3 speeding tickets to determine eligibility. If all conditions are met, the applicant is deemed eligible for insurance; otherwise, they are not. The result is displayed at the end. This project demonstrates basic conditional logic and user input handling in C#.



## Projects Rendered in the Browser:
- Car Insurance MVC

### Car Insurance
This project is a Car Insurance Web Application built using ASP.NET MVC and the .NET Framework, allowing users to manage insuree data through Create, Read, Update, and Delete (CRUD) operations. The app includes functionality to input customer information such as personal details, car make/model, driving history (DUI, speeding tickets), and calculate insurance quotes based on these factors. The admin view allows easy management of insuree records, displaying key details like names, email addresses, and quotes. The user interface is dynamic, utilizing Razor views and C# for backend logic to ensure smooth interactions with the data.
