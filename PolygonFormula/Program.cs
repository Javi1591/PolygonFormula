/*
Student Name: Xavier Nazario
COP2360 - Assignment 6
Collaboration Statement: I used the textbook.
I had used chapter 7 of the textbook to try exceptions,
but had a hard time understanding it. I also coded input
and hardcode into the program for more practice. The code for
either one felt small, unless I've been overthinking these assignments.
*/

using System;

namespace PolygonFormula;

    // Declare Polygon class *(Not sure if needed to change, just helps
    //  me)*
    // ***USE FORMULA GIVEN: (n - 2) * 180 ***
    // ***Method MUST BE named SumPolygon***
    class Polygon
    {
        // Declare SumPolygon method
        // Use public and int
        // Use n as variable for sides
        public int SumPolygon(int n)
        {
            // Formula (n - 2) * 180
            return (n - 2) * 180;
        }
        static void Main(string[] args)
        {
            // Display instructions and formula
            Console.WriteLine("This program uses the formula" + 
            " (n - 2) x 180 to calculate the total sum of angles in a polygon." + 
            " Then displays the results.");
            Console.WriteLine("When prompted, please enter any number greater than 2.");

            // Declace polygon1 instance for future user input
            Polygon polygon1 = new Polygon();

            // Prompt and Declare user choice
            // Use Y for yes, N for no
            // ***Remeber to PARSE and format***
            Console.WriteLine("Would you like an example? Y for Yes, N for No. ");
            string choice = Console.ReadLine().ToUpper();

            // Use n for variable again (Won't cause issues)
            // Use int
            int n;
            
            // Create if-else Statement for choice
            // Nest a while statement for invalid input
            // ***FORMAT AND PARSE ANY and ALL input/output***
            if (choice == "Y")
            {
                // Example
                n = 5;
                Console.WriteLine($"An example number of sides: {n}");
            }
            else
            {
                // Prompt user input
                Console.Write("Enter the number of sides for the polygon. The number must greater than 2): ");
                
                // Nested while statement creates a loop. (Found that out at debugging/testing.)
                // ***PARSE INPUT***
                // Check for invalid input
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 2)
                {
                    Console.WriteLine("Invalid input. Please enter a number greater than 2.");
                }
            }

            // Calculate and Declare sumOfAngles
            // Use int
            // Remeber polygon1 instance name, not Polygon class as a whole 
            int sumOfAngles = polygon1.SumPolygon(n);

            // Display results
            Console.WriteLine($"The sum of internal angles of a {n}-sided polygon is {sumOfAngles} degrees.");
        }
    }