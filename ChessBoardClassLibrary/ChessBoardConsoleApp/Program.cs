/*
 * Jacob Cutler
 * CST - 250
 * 02/08/2026
 * Chess Board Project
 * Activity 2
 */

using ChessBoardClassLibrary.Models;
using ChessBoardClassLibrary.Services.BusinessLogicLayer;

//------------------------------------------------
// Start of Main Method
//------------------------------------------------

// Declare and initialize
string piece = "";
Tuple<int, int>? result;
BoardLogic boardLogic = new BoardLogic();

// Print a welcome message for the user
Console.WriteLine("\n         Hello, Chess Players!\n");

// Create a new chess board
BoardModel board = new BoardModel(8);

// Show the empty board
Utility.PrintBoard(board);

// Prompt the user for th type of chess piece
Console.Write("Enter the type of piece you want to place (Knight, Rook, Bishop, Queen, King): ");
piece = Utility.VerifyRealPiece(Console.ReadLine());

// Prompt the user for the location of the chess piece
result = Utility.GetRowAndCol();

// mark the legal moves based on the input
board = boardLogic.MarkLegalMoves(board, board.Grid[result.Item1, result.Item2], piece);

// Print ou the new chess board
Utility.PrintBoard(board);

//------------------------------------------------
// End of Main Method
//------------------------------------------------

//------------------------------------------------
// Define a utility class
//------------------------------------------------
public static class Utility
{
    /// <summary>
    /// Print the given board to the console
    /// </summary>
    /// <param name="board"></param>
    internal static void PrintBoard(BoardModel board)
    {
        // Print the column numbers at the top of the board
        Console.WriteLine("     0   1   2   3   4   5   6   7");

        // Loop over the rows of the board
        for (int row = 0; row < board.Size; row++)
        {
            // Set up the horizontal line to separate the rows
            Console.WriteLine("   +---+---+---+---+---+---+---+---+");

            // Print the row number at the start of each row
            Console.Write($" {row} |");

            // Loop over the columns of the board
            for (int col = 0; col < board.Size; col++)
            {
                // Get the current cell from the grid
                CellModel cell = board.Grid[row, col];
                // Check if the current cell is a legal move
                if (cell.IsLegalNextMove)
                {
                    // Print a + for a legal move
                    Console.Write(" + |");
                }
                // Check if there is a piece occupying the cell
                else if (cell.PieceOccupyingCell != "")
                {
                    // Print the chess piece letter
                    Console.Write($" {cell.PieceOccupyingCell} |");
                }
                else
                {
                    // Print a . for anything else
                    Console.Write("   |");
                }
            }
            // Start a new line after every row
            Console.WriteLine();
        }

        // Print the final horizontal line at the bottom of the board
        Console.WriteLine("   +---+---+---+---+---+---+---+---+\n");
    } // End of PrintBoard method

    /// <summary>
    /// Create a Tuple method to get the row and column from the user.
    /// </summary>
    /// <returns></returns>
    internal static Tuple<int, int> GetRowAndCol()
    {
        // Declare and initialize
        int row = -1;
        int col = -1;

        while (row < 0 || row > 7)
        {
            // Get the row from the user
            Console.Write("Enter the row number of the piece: ");
            try
            {
                row = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input");
            }
            // Determine if the row is on the board
            if (row < 0 || row > 7)
            {
                Console.WriteLine("Invalid row number. Please enter a number between 0 and 7.");
            }
        }

        while (col < 0 || col > 7)
        {
            // Get the column from the user
            Console.Write("Enter the column number of the piece: ");
            try
            {
                col = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input");
            }
            // Determine if the column is on the board
            if (col < 0 || col > 7)
            {
                Console.WriteLine("Invalid column number. Please enter a number between 0 and 7.");
            }
        }

        // Return the data
        return Tuple.Create(row, col);
    } // End of GetRowAndCol

    /// <summary>
    /// Verify that the piece entered by the user is a valid chess piece.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    internal static string VerifyRealPiece(string input)
    {
        // Declare and initialize
        string piece = "";
        // Loop until the user enters a valid piece
        while (piece == "")
        {
            // Check if the input is a valid piece
            if (input.Equals("Knight", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("Rook", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("Bishop", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("Queen", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("King", StringComparison.OrdinalIgnoreCase))
            {
                piece = input;
            }
            else
            {
                Console.WriteLine("Invalid piece. Please enter Knight, Rook, Bishop, Queen, or King.");
                Console.Write("Enter the type of piece you want to place (Knight, Rook, Bishop, Queen, King): ");
                input = Console.ReadLine();
            }
        }
        return piece;
    } // End of VerifyRealPiece
}