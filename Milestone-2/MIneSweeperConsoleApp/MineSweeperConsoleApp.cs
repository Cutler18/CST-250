/*
 * Jacob Cutler
 * CST-250
 * 02/01/2026
 * Mine Sweeper Game
 * Milestone Project
 */

using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Web;
using MineSweeperClassLibrary.Models;
using MineSweeperClassLibrary.Services.BusinessLogicLayer;

//---------------------------------------
// Start of the Main Method
//---------------------------------------

// Declare and initialize
MineSweeperLogic logic = new MineSweeperLogic();

// Print a welcome message to the consol
Console.WriteLine("=== MINESWEEPER ===");
// Get the difficulty level
Console.Write("Enter difficulty level:\n1) Easy\n2) Medium\n3) Hard\n");
int difficulty = Utility.GetDifficulty(Console.ReadLine());
// Get the size of the board
int size = Utility.GetBoardSize(difficulty);

// Create a new board
BoardModel board = new BoardModel(size);

// Play the game
Utility.PlayGame(board, logic, difficulty, size);

// Allow the user to exit the console
Console.WriteLine("What do you want do?\n1) Play Again\n2) Exit");
int playAgain = Utility.AnotherGame(Console.ReadLine());

// Determine if the user wants to play again or exit
while (playAgain == 1)
{
    // Restart the program 
    Console.Clear();
    // Play the game
    Utility.PlayGame(board, logic, difficulty, size);
    // Ask the user if they want to play again or exit
    Console.WriteLine("What do you want do?\n1) Play Again\n2) Exit");
    playAgain = Utility.AnotherGame(Console.ReadLine());
}
if (playAgain == 2)
{
    // Exit the program
    Environment.Exit(0);
}

//---------------------------------------
// End of the Main Method
//---------------------------------------

//---------------------------------------
// Define a Utility Class
//---------------------------------------
public static class Utility
{
    /// <summary>
    /// Get the difficulty from the user
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    internal static int GetDifficulty(string input)
    {
        // Declare and initialize
        int difficulty = 0;

        // Loop the attempt at selecting difficulty
        while (difficulty < 1 || difficulty > 3)
        {
            // Catch any attempt at entering bad input
            try
            {
                // Parse the difficulty
                difficulty = int.Parse(input);
                // Check if the number is wrong
                if (difficulty < 1 || difficulty > 3)
                {
                    // Error message
                    Console.Write("Input out of bounds. Please enter a difficulty level:\n1) Easy\n2) Medium\n3) Hard\n");
                    // Get new input
                    input = Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input.\nPlease enter a difficulty level:\n1) Easy\n2) Medium\n3) Hard\n");
                input = Console.ReadLine();
            }
        }

        return difficulty;
    } // End of GetDifficulty method

    /// <summary>
    /// Determine the size of the board based on difficulty
    /// </summary>
    /// <param name="difficulty"></param>
    /// <returns></returns>
    internal static int GetBoardSize(int difficulty)
    {
        // Declare and initialize
        int size = 0;
        // Get size based on difficulty
        if (difficulty == 1)
        {
            size = 10;
        }
        else if (difficulty == 2)
        {
            size = 15;
        }
        else if (difficulty == 3)
        {
            size = 20;
        }
        // Return the size of the board
        return size;
    } // End of GetBoardSize Method

    /// <summary>
    /// Get the row input
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    internal static int GetRow(string input, int size)
    {
        // Declare and initialize
        int row = -1;
        // Loop through the message until a valid row is entered
        while (row < 0)
        {
            // Try to parse the row
            try
            {
                // Parse the string input
                row = int.Parse(input);
                // Make sure the input is valid
                if (row > size)
                {
                    // Error message
                    Console.Write("Row out of bounds. Please enter a row number: ");
                    // Get new input
                    input = Console.ReadLine();
                }
            }
            catch
            {
                // Error message
                Console.Write("Invalid Input. Please enter a row: ");
                // Get new input
                input = Console.ReadLine();
            }
        }
        // Return the row
        return row;
    } // End of GetRow Method

    /// <summary>
    /// Get the column from the user
    /// </summary>
    /// <param name="input"></param>
    /// <param name="size"></param>
    /// <returns></returns>
    internal static int GetColumn(string input, int size)
    {
        // Declare and initialize
        int col = -1;
        // Loop through the message until a valid column is entered
        while (col < 0)
        {
            // Try to parse the input
            try
            {
                // Parse the string input
                col = int.Parse(input);
                // Make sure the input is valid
                if (col > size)
                {
                    // Error message
                    Console.Write("Column out of bounds. Please enter a column number: ");
                    // Get new input
                    input = Console.ReadLine();
                }
            }
            catch
            {
                // Error Message
                Console.Write("Invalid Input. Please enter a column number: ");
                // Get new input
                input = Console.ReadLine();
            }
        }
        // Return the column
        return col;
    } // End of GetColumn Method

    /// <summary>
    /// Print the board
    /// </summary>
    /// <param name="board"></param>
    internal static void PrintBoard(BoardModel board, MineSweeperLogic logic)
    {
        // Tab the numbers to match the columns
        Console.Write("\t");
        // Write the column numbers
        for (int index = 0; index < board.Size; index++)
        {
            if (index < 10)
            {
                // Write the numbers
                Console.Write($"  {index} ");
            }
            else
            {
                // Write the numbers
                Console.Write($"  {index}");
            }
            
        }
        // Start the next line
        Console.WriteLine();
        // Loop through the row
        for (int row = 0; row < board.Size; row++)
        {
            // Set up the cosmetic of the board
            Console.Write("\t");
            for (int index = 0; index < board.Size; index++)
            {
                Console.Write("----");
            }
            // Move to the next line
            Console.WriteLine();
            // Print the row number
            Console.Write($"{row}\t|");
            // Loop through the columns
            for (int col = 0; col < board.Size; col++)
            {
                // Create a CellModel object
                CellModel cell = board.Grid[row, col];

                // What to write if the cell is not revealed
                if (!cell.IsRevealed)
                {
                    if (cell.IsFlagged)
                    {
                        // Change the color of the flags to yellow
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        // Write if the cell is flagged
                        Console.Write(" F ");
                        // Change the foreground back to the default color
                        Console.ResetColor();
                        Console.Write("|");
                        continue;
                    }
                    else
                    {
                        // Change the color of the unrevealed cells
                        Console.ForegroundColor = ConsoleColor.Green;
                        // Write if the cell is revealed
                        Console.Write(" # ");
                        // Change the foreground back to the default color
                        Console.ResetColor();
                        Console.Write("|");
                    }
                }
                else if (cell.IsMine)
                {
                    if (!cell.IsDiffused)
                    {
                        // Change the color of the bombs to red
                        Console.ForegroundColor = ConsoleColor.Red;
                        // Write if the cell is a mine
                        Console.Write(" * ");
                        // Change the foreground back to the default color
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    else if (cell.IsDiffused)
                    {
                        // Change the color of the diffused bombs to gray
                        Console.ForegroundColor = ConsoleColor.Gray;
                        // Write if the cell is a diffused mine
                        Console.Write(" * ");
                        // Change the foreground back to the default color
                        Console.ResetColor();
                        Console.Write("|");
                    }

                }
                else if (cell.IsReward)
                {
                    // Change the color of the rewards to dark yellow
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    // Write if the cell is a reward
                    Console.Write(" $ ");
                    // Change the foreground back to the default color
                    Console.ResetColor();
                    Console.Write("|");
                }
                else
                {
                    // Count the adjacent mines
                    int count = logic.CountAdjacentMines(board, row, col);
                    // If there are no mines around the cell, print a blank space
                    if (count == 0)
                    {
                        // Write a blank space
                        Console.Write("   |");
                        continue;
                    }
                    // If there is one mine around the cell, print the number in cyan
                    else if (count == 1)
                    {
                        // Change the color of the numbers to cyan
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        // Print how many mines the square is touching
                        Console.Write($" {count} ");
                        // Change the foreground back to the default color
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    // If there is two mines around the cell, print the number in dark cyan
                    else if (count == 2)
                    {
                        // Change the color of the numbers to blue
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        // Print how many mines the square is touching
                        Console.Write($" {count} ");
                        // Change the foreground back to the default color
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    // If there are three or more mines around the cell, print the number in magenta
                    else
                    {
                        // Change the color of the numbers to red
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        // Print how many mines the square is touching
                        Console.Write($" {count} ");
                        // Change the foreground back to the default color
                        Console.ResetColor();
                        Console.Write("|");
                    }
                }

            }
            // Move a line down
            Console.WriteLine();
        }
        // Tab to match the board
        Console.Write("\t");
        // Write the column numbers
        for (int index = 0; index < board.Size; index++)
        {
            // Write the numbers
            Console.Write($"----");
        }
        // Create space
        Console.WriteLine("\n");
    } // End of PrintBoard method

    /// <summary>
    /// Reveal all of the cells in the board
    /// </summary>
    /// <param name="board"></param>
    internal static void RevealAll(BoardModel board)
    {
        // Loop through all of the cells and reveal them
        foreach (var cell in board.Grid)
        {
            cell.IsRevealed = true;
        }
    } // End of RevealAll Method

    internal static int GetAction(string input)
    {
        // Declare and initialize
        int action = 0;
        // Loop the attempt at selecting an action
        while (action < 1 || action > 4)
        {
            // Catch any attempt at entering bad input
            try
            {
                // Parse the action
                action = int.Parse(input);
                // Check if the number is wrong
                if (action < 1 || action > 4)
                {
                    // Error message
                    Console.Write("Input out of bounds. Please enter an action:\n1) Reveal a square\n2) Place a flag\n3) Remove a flag\n4) Use a reward\n");
                    // Get new input
                    input = Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input.\nPlease enter an action:\n1) Reveal a square\n2) Place a flag\n3) Remove a flag\n4) Use a reward\n");
                input = Console.ReadLine();
            }
        }
        return action;
    } // End of GetAction method

    internal static int AnotherGame(string input)
    {
        // Declare and initialize
        int choice = 0;
        // Loop the attempt at selecting an action
        while (choice < 1 || choice > 2)
        {
            // Catch any attempt at entering bad input
            try
            {
                // Parse the action
                choice = int.Parse(input);
                // Check if the number is wrong
                if (choice < 1 || choice > 2)
                {
                    // Error message
                    Console.Write("Input out of bounds. Please enter an action:\n1) Play Again\n2) Exit\n");
                    // Get new input
                    input = Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input.\nPlease enter an action:\n1) Play Again\n2) Exit\n");
                input = Console.ReadLine();
            }
        }
        // Return the choice
        return choice;
    } // End of AnotherGame method

    /// <summary>
    /// Play the game
    /// </summary>
    /// <param name="board"></param>
    /// <param name="logic"></param>
    /// <param name="difficulty"></param>
    /// <param name="size"></param>
    internal static void PlayGame(BoardModel board, MineSweeperLogic logic, int difficulty, int size)
    {
        // Start a new game
        board = logic.StartNewGame(size);
        // Reset the board for the new game
        board = logic.ResetBoard(board);

        // Get the number of mines
        int numOfMines = logic.NumberOfMines(difficulty);
        // Place the mines
        logic.PlaceMines(board, numOfMines);
        // Place the rewards
        logic.PlaceRewards(board);

        // New game can't be game over
        bool gameOver = false;

        // Play the game
        while (!gameOver)
        {
            // Clear the console for a clean game
            Console.Clear();
            // Print a new board
            Utility.PrintBoard(board, logic);

            // Prompt the user for an action
            Console.Write("What would you like to do?\n1) Reveal a square\n2) Place a flag\n3) Remove a flag\n4) Use a reward\n");
            int action = Utility.GetAction(Console.ReadLine());

            // Get input for the game play
            Console.Write("Enter a row: ");
            int row = Utility.GetRow(Console.ReadLine(), size);
            Console.Write("Enter a column: ");
            int column = Utility.GetColumn(Console.ReadLine(), size);

            // Check if the location is on the board
            if (!logic.IsOnBoard(board, row, column))
            {
                // Error message
                Console.WriteLine("Invalid position. Press enter to continue.");
                // Continue the loop
                Console.ReadLine();
                continue;
            }

            // Perform the action based on the user's choice
            switch (action)
            {
                case 1:
                    // Reveal the squares
                    logic.RevealCell(board, row, column);
                    break;
                case 2:
                    // Place a flag 
                    logic.PlaceFlag(board, row, column);
                    continue;
                case 3:
                    // Remove a flag
                    logic.RemoveFlag(board, row, column);
                    continue;
                case 4:
                    // Create a CellModel object
                    CellModel cell = board.Grid[row, column];
                    // Check if a reward is in the revealed cell
                    if (cell.IsRevealed && cell.IsReward)
                    {
                        // Determine the type of reward
                        string reward = logic.DetermineReward();
                        // Apply the reward to the board
                        logic.ApplyReward(board, reward, row, column);
                        // Message for the user about the reward
                        if (reward == "Fake Reward")
                        {
                            // Show message for fake reward
                            Console.WriteLine("Bad luck! You got a fake reward. Press enter to continue.");
                            Console.ReadLine();
                        }
                        else
                        {
                            // Show message for good reward
                            Console.WriteLine($"Congratulations! You got a {reward}. Press enter to continue.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        // Error message
                        Console.WriteLine("No reward in this cell. Press enter to continue.");
                        // Continue the loop
                        Console.ReadLine();
                    }
                    cell.IsReward = false;
                    continue;
            }

            logic.DetermineGameState(board, row, column);

            // Check if the game is over
            if (board.Lost)
            {
                // Clear the board and reveal all of the squares
                Console.Clear();
                Utility.RevealAll(board);
                Utility.PrintBoard(board, logic);
                // Print a message for losers
                Console.WriteLine("You hit a mine. Game over!");
                gameOver = true;
            }
            // Check if the game is won
            else if (board.Won)
            {
                // Clear the board and reveall all of the sqaures
                Console.Clear();
                Utility.RevealAll(board);
                Utility.PrintBoard(board, logic);
                // Write a message for winners
                Console.WriteLine("You Win!");
                // Set gameOver bool to true
                gameOver = true;
            }
            else
            {
                // Continue the game
                continue;
            }
        }
    } // End of PlayGame method
} // End of Utility class