# C-Sharpe-and-.NET-Course

These are projects I completed during my time at The Tech Academy, from 2021 to 2022. Some of these projects are terminal-based outputs, while others are rendered in the browser.

## Projects Rendered in the Browser:
- Car Insurance MVC
- Challenge Submission

### Car Insurance
This project is a Car Insurance Web Application built using ASP.NET MVC and the .NET Framework, allowing users to manage insuree data through Create, Read, Update, and Delete (CRUD) operations. The app includes functionality to input customer information such as personal details, car make/model, driving history (DUI, speeding tickets), and calculate insurance quotes based on these factors. The admin view allows easy management of insuree records, displaying key details like names, email addresses, and quotes. The user interface is dynamic, utilizing Razor views and C# for backend logic to ensure smooth interactions with the data.

### Challenge Submission
The Challenge Submission project is a basic ASP.NET Core web application that renders a simple homepage using Razor Pages. It includes request routing, HTTPS enforcement, and logging functionality, displaying a "Hello World!" message with a link to ASP.NET Core documentation.

## Terminal Based Projects:
- Abstract Class Submission
- Anonymous Income Comparison
- Array Future Picker
- Basic C# Programs
- Calling Methods
- Car Insurance Approval
- Class Submission Assignment
- Console App 6 Parts
- Console App While Do
- Constructor Submission
- Daily Report Submission
- Date Time Submission
- Final Challenge Submission Assignment

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

### Class Submission Assignment
The Class Submission Assignment is a C# console application that prompts the user to enter a positive number and then divides it by two. It includes a static class for displaying program information and validating user input, ensuring the number entered is positive before proceeding. The program uses method overloading and an out parameter to compare values, demonstrating fundamental C# concepts such as classes, methods, and exception handling. Once a valid number is provided, the division operation is performed in a separate class, reinforcing modular programming practices.

### Console App 6 Parts
The Console App 6 Parts program demonstrates various loop concepts and user interaction in a C# console application. It starts by allowing the user to input a verb describing what their fish are doing, appending this input to a predefined list of fish species and displaying the updated list. The program then fixes an infinite loop, showcasing how to properly control loop execution. It also compares two loops using different operators (< and <=). The program continues by introducing a search functionality for a list of unique items, where the user can input a guess and check if it matches any item in the list. Additionally, it handles searching for duplicates in a list, displaying all indices of matching items, and informing the user if their input is not found. Lastly, it implements a foreach loop to evaluate and display whether each name in a list has already appeared, highlighting duplicate entries. This assignment covers multiple key programming concepts, including loops, conditionals, user input, and list manipulation.

### Console App While Do 
The Console App While Do project is a number guessing game where the user has three attempts to guess The Tech Academy's lucky number, which is 100. The game prompts the user to guess a number between 1 and 200, providing hints if their guess is too high or too low. If the user guesses outside the valid range, they are prompted again without using up a guess. The game gives feedback on the number of guesses remaining and notifies the user if they've won or lost. The use of a while loop ensures the game continues until the user either guesses correctly or runs out of attempts, while a do-while loop is used to provide hints after each valid guess.

### Constructor Submission
The Constructor Submission project demonstrates the use of constants, variables, and constructor chaining in C#. The program defines a constant variable, a var variable, and creates an Employee object using a constructor that chains two constructors together. The Employee class has two constructors: one that accepts only a name and a second that accepts both a name and an ID. The program outputs the employee's name and ID to the console. This project showcases the use of const, var, and constructor chaining, which are fundamental concepts in object-oriented programming in C#.

### Daily Report Submission
The Daily Report Submission is a C# console application designed to collect daily feedback from students. It asks the user for their name, course, page number, whether they need help, any positive experiences to share, additional feedback, and the number of hours they studied. The program then thanks the user and ends. This project demonstrates basic input handling with various data types such as strings, integers, booleans, and doubles, allowing the program to interact with the user and gather detailed information in a simple form.

### Date Time Submission
The DateTime Submission project is a C# console application that simulates a "time travel" experience. It first displays the current date and time, then prompts the user to enter how many hours into the future they want to go. The program uses this input to calculate and display the time after the specified number of hours. It leverages DateTime.Now to fetch the current time and TimeSpan to add the user-defined number of hours, demonstrating the use of time manipulation in C#. The program then thanks the user for using the "Time Travel Program" before ending.

### Final Challenge Submission
The Final Challenge Submission Assignment is a C# console application that demonstrates the use of Entity Framework (EF6) to create a simple database with a Student and Grade class, representing a school system. The application defines a SchoolContext class inheriting from DbContext, managing the interaction with the database. In the main program, a new Student named "Bill" is added to the Students table using Entity Framework, showcasing how to interact with a database by adding an entry and saving changes. The Grade class has a one-to-many relationship with the Student class, where each Student is linked to a Grade, which can contain multiple Students. The program also includes basic properties for both Student and Grade classes, such as name, photo, and birthdate for Student, and GradeName and Section for Grade. This final project highlights the integration of EF6 for database operations in a console application.
