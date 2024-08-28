using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exponents_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Exponents / Powers Table

            Objectives:
            - User input
            - Calculations

            Task:
            Display a table of powers (squares and cubes). Ask the user if they would like to go again, and if so, loop back to the beginning.
            */

            /*
            What the Application Will Do:
            1. Prompt the user to enter an integer.
            2. Display a table of squares and cubes from 1 to the value entered.
            3. Prompt the user to continue.
            */

            /*
            Build Specifications:
            - Assume that the user will enter valid data.
            - The application should continue only if the user agrees to.
            */

            /*
            Additional Requirements:
            - Ensure you answer the Lab Summary when submitting to the LMS.
            - Deduct 2 points if there are syntax errors or the program does not run (for example, in the Main method).
            */

            /*
            Hints:
            - Be careful to differentiate between squares and cubes.
            - Use \t to tab and line up columns properly.
            - Your instructor will provide sample loops during class regarding how to ask the user if they would like to go again.
            */

            /*
            Extra Challenges:
            - Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number.
            - Research formatted strings and right-align the numbers in columns instead of left-aligning them.
            - Find out the maximum number whose cube will fit in an int, and limit the user input to that number or less.
            */

            /*
            Example Console Preview:

            Learn your squares and cubes!

            Enter an integer: {user input here, for example: 5}

            Number     	Squared       	Cubed
            =======  		=======		======
            1			1			1
            2			4 			8
            3         		9            	27
            4      		16          	64
            5             	25          	125

            Continue? (y/n): {user input here, for example: Y}

            Enter an integer: …
            */
            //Declare Variables
            bool goAgain = true;
            bool validInput = false;
            bool input1;
            bool validInput2 = false;
            int userNum;
            //Loop for if the user wants to go again
            do
            {
                //Prompt the user to enter an integer.
                Console.WriteLine("Please ender an integer above 0: ");
                string userInput = Console.ReadLine();
                input1 = int.TryParse(userInput, out userNum);
                //Input validation that ensures user enters a double - do while loop
                //Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number. - do while loop
                do //do while loop for input validation
                {
                    if (input1)//checks if input is an integer
                    {
                        if (userNum > 0)//checks if input is greater than 0
                        {
                            validInput = true;//if input is an integer and greater than 0, validInput is true
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter an integer above 0.");//if input is not greater than 0, invalid input message
                            validInput = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer above 0.");//if input is not an integer, invalid input message
                        validInput = false;
                    }
                } while (!validInput);//do while loop for input validation
                //For loop for calculating Square and Cube for all values from 1 to the value entered
                //Display Results
                //Research formatted strings and right-align the numbers in columns instead of left-aligning them.
                Console.WriteLine("Number\t\tSquared\t\tCubed");//Header Names
                Console.WriteLine("=======\t\t=======\t\t======");//Header Width
                for (int i = 1; i <= userNum; i++)
                {
                    //Display a table of squares and cubes from 1 to the value entered.
                    //Console.WriteLine("Number\t\tSquared\t\tCubed");
                    //Console.WriteLine("=======\t\t=======\t\t======");
                    Console.WriteLine($"{i,7}\t\t{i * i,7}\t\t{i * i * i,7}");//String interpolation to display the results the "," is used to right align the numbers and the "7" is used to set the width of the column - seven is the number of "=" signs in the header to set the width
                }
                //Ask user if they would like to go again
                do
                {
                    Console.WriteLine("Would you like to go again? (y/n)");
                    //Collect User Input
                    string userResponse = Console.ReadLine().ToLower();
                    //Validate user input is a y or n 
                    if (userResponse == "y" || userResponse == "n")
                    {

                        validInput2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter y or n.");
                        validInput2 = false;
                    }

                    if (userResponse == "y")
                    {
                        goAgain = true;
                    }
                    else
                    {
                        goAgain = false;
                    }
                }
                while (!validInput2);
            } while (!goAgain);
        }  //Main End
    }//Class End
}//Namespace End
