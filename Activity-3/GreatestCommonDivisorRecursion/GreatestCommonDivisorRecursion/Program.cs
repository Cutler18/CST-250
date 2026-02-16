/*
 * Jacob Cutler
 * CST-250
 * 02/15/2026
 * Greatest Common Divisor Recursion
 * Activity 3
 */

using GreatestCommonDivisorRecursion.Services.BusinessLogicLayer;
using System.Diagnostics;
//-----------------------------------------------------
// Start of Main Method
//-----------------------------------------------------

// Declare and initialize
int number1 = 0, number2 = 0, result = 0;
GCDLogic logic = new GCDLogic();
Stopwatch stopwatch = new Stopwatch();

// Preliminary prompt
Console.WriteLine("FIRST NUMBER");
// Call the first get number method
number1 = Utility.GetNumber();
// Preliminary prompt
Console.WriteLine("SECOND NUMBER");
// Call the second get number method
number2 = Utility.GetNumber();

// Statement for Recursion
Console.WriteLine("Recursive Approach");
// Start the stopwatch
stopwatch.Start();
// Call the GCD method
result = Utility.GreatestCommonDivisor(number1, number2);
// Stop the stopwatch
stopwatch.Stop();
// Print the result to the user
Console.WriteLine($"The GCD of {number1} and {number2} is {result}");
// Print the elapsed time for recursion
Console.WriteLine($"That took {stopwatch.ElapsedMilliseconds} milliseconds.");

// Reset the stopwatch
stopwatch.Reset();

// Statement for iteration
Console.WriteLine("Iterative Approach");
// Start the stopwatch
stopwatch.Start();
// Call the iterative method
result = logic.IterativeGCD(number1, number2);
// Stop the stopwatch
stopwatch.Stop();
// Print the result to the user
Console.WriteLine($"The GCD of {number1} and {number2} is {result}");
// Print the elapsed time for iteration
Console.WriteLine($"That took {stopwatch.ElapsedMilliseconds} milliseconds.");

// Reset the stopwatch
stopwatch.Reset();

//-----------------------------------------------------
// End of Main Method
//-----------------------------------------------------

//-----------------------------------------------------
// Start of Utility Class
//-----------------------------------------------------

public class Utility
{
    /// <summary>
    /// Get Greatest Commond Divisor using Recursion
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    internal static int GreatestCommonDivisor(int num1, int num2)
    {
        // Declare and initialize
        int remainder = 0;

        // Base case: num2 is 0
        if (num1 == 0 || num2 == 0)
        {
            // Return the greatest common divisor
            return num1;
        }
        else
        {
            // Get the remainder of the dividing num1 and num2
            remainder = num1 % num2;
            // Print an update to the user
            Console.WriteLine($"Not yet. The remainder of {num1} and {num2} is {remainder}");
            // Call the recursive function of the second number and the remainder
            return GreatestCommonDivisor(num2, remainder);
        }
    } // End of GreatestCommonDivisor method

    /// <summary>
    /// Get the 
    /// </summary>
    /// <returns></returns>
    internal static int GetNumber()
    {
        // Declare and initialize
        int number = 0;
        string input = "";

        // Loop through the user input until it is valid
        do
        {
            // Prompt the user
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
        }
        while (!int.TryParse(input, out number) || number < 0);

        return number;
    } // End of GetNumber method
}

//-----------------------------------------------------
// End of Utility Class
//-----------------------------------------------------