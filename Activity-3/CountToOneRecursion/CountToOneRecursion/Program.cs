/*
 * Jacob Cutler
 * CST-250
 * 02/15/2026
 * Count To One Recursion
 * Activity 3
 */

//--------------------------------------------------------
// Start of the Main Method
//--------------------------------------------------------

// Declare and initialize
using System.Diagnostics.Metrics;

int choice = 0, result = 0, counter = 1;
string input = "";

// Prompt the user for a number
Console.Write("Enter a positive number: ");
// Get the users input
input = Console.ReadLine();
// See if the user entered valid input
while (!int.TryParse(input, out choice))
{
    Console.WriteLine("Invalid number");
    // Re-prompt the user for a number
    Console.Write("Enter a positive number: ");
    // Get the users input
    input = Console.ReadLine();
}
// Make sure the number is positive
choice = Utility.IsPositive(choice);
// Call the CountToOne function
result = Utility.CountToOne(choice, counter);
Console.WriteLine($"The end number is {result}");

//--------------------------------------------------------
// End of the Main Method
//--------------------------------------------------------

//--------------------------------------------------------
// Start of the Utility Class
//--------------------------------------------------------

static class Utility
{
    /// <summary>
    /// Count to one using recursion
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    internal static int CountToOne(int num, int counter)
    {
        // Print out the current number
        Console.WriteLine($"The current number is: {num}");
        // Check if the number is 1
        if (num == 1)
        {
            // Print out the step number
            Console.WriteLine($"Step number: {counter}");
            // Increment the counter
            counter++;
            return 1;
        }
        else
        {
            // Check if the number is even
            if ((num % 2) == 0)
            {
                // Print out the step number and the action taken
                Console.WriteLine($"Step number: {counter}");
                Console.WriteLine("The number is even. Divide by 2");
                // Divine the number by 2 and call the function
                return CountToOne(num / 2, counter + 1);
            }
            // Check if the number is divisible by 3
            else if ((num % 3) == 0)    
            {
                // Print out the step number and the action taken
                Console.WriteLine($"Step number: {counter}");
                Console.WriteLine("The number is divisible by 3. Divide by 3");
                // Divine the number by 3 and call the function
                return CountToOne(num / 3, counter + 1);
            }
            // Check if the number is divisible by 5
            else if (num < 5 && num != 1)
            {
                // Print out the step number and the action taken
                Console.WriteLine($"Step number: {counter}");
                Console.WriteLine("The number is divisible by 5. Multiply by 4");
                // Divine the number by 5 and call the function
                return CountToOne(num * 4, counter + 1);
            }
            // Anything else
            else
            {
                // Print out the step number and the action taken
                Console.WriteLine($"Step number: {counter}");
                Console.WriteLine("The number is odd. Add 3");
                // Add 1 and call the function
                return CountToOne(num + 3, counter + 1);
            }
        }
    }

    /// <summary>
    /// Make sure the input is positive
    /// </summary>
    /// <param name="num"></param>
    internal  static int IsPositive(int num)
    {
        // Declare and initialize
        int result = 0;
        // Check if the number is positive
        while (num %2 != 0)
        {
            // If the number is not positive, re-prompt the user for a number
            Console.WriteLine("The number must be positive");
            Console.Write("Enter a positive number: ");
            // Get the users input
            num = int.Parse(Console.ReadLine());
            result = num;
        }

        // Return the number
        return result;
    }
}

//--------------------------------------------------------
// End of the Utility Class
//--------------------------------------------------------