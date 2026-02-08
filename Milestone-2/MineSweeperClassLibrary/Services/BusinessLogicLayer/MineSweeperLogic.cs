using MineSweeperClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClassLibrary.Services.BusinessLogicLayer
{
    public class MineSweeperLogic
    {
        /// <summary>
        /// Reset the cells to the default values for a new game.
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public BoardModel ResetBoard(BoardModel board)
        {
            // Use a foreach loop to iterate over every cell
            foreach (CellModel cell in board.Grid)
            {
                // Set the properties to their defaults
                cell.IsMine = false;
                cell.IsRevealed = false;
            }

            // Return the board back to presentation layer
            return board;
        } // End of ResetBoard method

        /// <summary>
        /// Determine if location is on the board.
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public bool IsOnBoard(BoardModel board, int row, int column)
        {
            // Get the size of the board
            int size = board.Size;

            // Check if the row is on the board
            bool IsRowSafe = row >= 0 && row < size;

            // Check if the column is on the board
            bool IsColumnSafe = column >= 0 && column < size;

            // Return true if both row and column are safe
            return IsRowSafe && IsColumnSafe;
        } // End of IsOnBoard method

        /// <summary>
        /// Start a new game
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public BoardModel StartNewGame(int size)
        {
            // Create a new board model with the given size
            BoardModel board = new BoardModel(size);
            // Reset the board to the default values
            return ResetBoard(board);
        } // End of StartNewGame method

        /// <summary>
        /// Place the mines randomly on the board
        /// </summary>
        /// <param name="board"></param>
        /// <param name="numberOfMines"></param>
        public void PlaceMines(BoardModel board, int numberOfMines)
        {
            // Get the size of the board
            int size = board.Size;
            // Create a random number generator
            Random random = new Random();
            // Loop until the desired number of mines are placed
            for (int i = 0; i < numberOfMines; i++)
            {
                // Generate random row and column indices
                int row = random.Next(size);
                int column = random.Next(size);
                // Check if the cell is already a mine
                if (!board.Grid[row, column].IsMine)
                {
                    // Place a mine in the cell
                    board.Grid[row, column].IsMine = true;
                }
                else
                {
                    // If the cell already has a mine, decrement i to try again
                    i--;
                }
            }
        } // End of PlaceMines method

        /// <summary>
        /// Determine the number of mines based on the difficulty level
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public int NumberOfMines(int difficultyLevel)
        {
            // Declare and initialize
            int size = 0;
            int numOfMines = 0;

            // Calculate the number of mines based on the size of the board
            if (difficultyLevel == 1)
            {
                size = 10;
            }
            else if (difficultyLevel == 2)
            {
                size = 15;
            }
            else if (difficultyLevel == 3)
            {
                size = 20;
            }
            // Set the number of mines
            numOfMines = (int)(size * size * 0.1);
            // Return the number of mines based on the difficulty level
            return numOfMines;
        } // End of NumberOfMines method

        /// <summary>
        /// Count the number of adjacent mines for a given cell
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public int CountAdjacentMines(BoardModel board, int row, int column)
        {
            // Define the directions to check for adjacent cells
            int[] directions = { -1, 0, 1 };
            int mineCount = 0;
            // Loop through each direction
            foreach (int dRow in directions)
            {
                foreach (int dCol in directions)
                {
                    // Skip the current cell
                    if (dRow == 0 && dCol == 0)
                        continue;
                    int newRow = row + dRow;
                    int newCol = column + dCol;
                    // Check if the new position is on the board
                    if (IsOnBoard(board, newRow, newCol))
                    {
                        // Check if the adjacent cell is a mine
                        if (board.Grid[newRow, newCol].IsMine)
                        {
                            mineCount++;
                        }
                    }
                }
            }
            return mineCount;
        } // End of CountAdjacentMines method

        /// <summary>
        /// Determine if the game is over
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        private bool IsGameOver(BoardModel board, int row, int column)
        {
            // Check if the cell is a mine
            return board.Grid[row, column].IsMine;
        } // End of IsGameOver method

        /// <summary>
        /// Determine if the game is won
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        private bool IsGameWon(BoardModel board)
        {
            // Loop through each cell in the grid
            foreach (CellModel cell in board.Grid)
            {
                // If the cell is not a mine and has not been revealed, the game is not won
                if (!cell.IsMine && !cell.IsRevealed)
                {
                    // Game not won
                    return false;
                }
            }
            // Game won
            return true;
        } // End of IsGameWon method

        /// <summary>
        /// Check if the cell is flagged
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public bool IsFlagged(BoardModel board, int row, int column)
        {
            // Check if the cell is flagged
            return board.Grid[row, column].IsFlagged;
        } // End of IsFlagged method

        /// <summary>
        /// Place the flag on the cell
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void PlaceFlag(BoardModel board, int row, int column)
        {
            // Check if the cell is not already flagged
            if (!IsFlagged(board, row, column))
            {
                // Place the flag on the cell
                board.Grid[row, column].IsFlagged = true;
            }
        }

        /// <summary>
        /// Remove the flag from the cell
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void RemoveFlag(BoardModel board, int row, int column)
        {
            // Check if the cell is flagged
            if (IsFlagged(board, row, column))
            {
                // Remove the flag from the cell
                board.Grid[row, column].IsFlagged = false;
            }
        }

        /// <summary>
        /// Reveal the cell and its adjacent cells if there are no adjacent mines
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void RevealCell(BoardModel board, int row, int column)
        {
            // Check if the cell is on the board
            if (!IsOnBoard(board, row, column))
            {
                return;
            }
            CellModel cell = board.Grid[row, column];
            // If the cell is already revealed, do nothing
            if (cell.IsRevealed || cell.IsFlagged)
            {
                return;
            }

            // Determine if the cell is flagge
            else if (cell.IsFlagged)
            {
                return;
            }

            else
            {
                // Reveal the cell
                cell.IsRevealed = true;
            }

            // Determine if it is game over
            if (IsGameOver(board, row, column))
            {
                // Handle game over logic here (e.g., reveal all mines, show game over message)
                return;
            }

            // If the cell has no adjacent mines, reveal adjacent cells
            if (CountAdjacentMines(board, row, column) == 0)
            {
                int[] directions = { -1, 0, 1 };
                foreach (int dRow in directions)
                {
                    foreach (int dCol in directions)
                    {
                        if (dRow == 0 && dCol == 0)
                            continue;
                        RevealCell(board, row + dRow, column + dCol);
                    }
                }
            }
        }

        /// <summary>
        /// Determine the game state after revealing a cell (check for game over or game won)
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void DetermineGameState(BoardModel board, int row, int column)
        {
            // Make a CellModel object
            CellModel cell = board.Grid[row, column];
            // Check if the game is over because of a mine
            if (IsGameOver(board, row, column) && !cell.IsDiffused)
            {
                // Determine if a mine was hit
                board.Lost = true;
                board.Won = false;
                board.InProgress = false;
            }
            // Check if the game has been won
            else if (IsGameWon(board))
            {
                // Determine if the game is won
                board.Won = true;
                board.Lost = false;
                board.InProgress = false;
            }
            // Check if the game is still in progress
            else
            {
                // The game is still in progress
                board.Won = false;
                board.Lost = false;
                board.InProgress = true;
            }
        } // End of DetermineGameState method

        /// <summary>
        /// Place a given number of rewards based on the size of the board
        /// </summary>
        /// <param name="board"></param>
        public void PlaceRewards(BoardModel board)
        {
            // Get the size of the board
            int size = board.Size;
            // Count the number of rewards
            int numberOfRewards = (board.Size / 4);
            // Create a random number generator
            Random random = new Random();
            // Loop until the desired number of mines are placed
            for (int i = 0; i < numberOfRewards; i++)
            {
                // Generate random row and column indices
                int row = random.Next(size);
                int column = random.Next(size);
                // Check if the cell is already a mine
                if (!board.Grid[row, column].IsReward && !board.Grid[row, column].IsMine)
                {
                    // Place a mine in the cell
                    board.Grid[row, column].IsReward = true;
                }
                else
                {
                    // If the cell already has a mine, decrement i to try again
                    i--;
                }
            }
        } // End of PlaceRewards method

        /// <summary>
        /// Return a random reward
        /// </summary>
        /// <returns></returns>
        public string DetermineReward()
        {
            // Create a random number generator based on 3 types of rewards
            Random random = new Random();
            // Return a reward based on the number
            if (random.Next(3) == 1)
            {
                return "Fake Reward";
            }
            else if (random.Next(3) == 2)
            {
                return "Reveal Random Safe Spot";
            }
            else
            {
                return "Locate a Random Mine";
            }
        } // End of DetermindReward method

        /// <summary>
        /// Apply the reward from a user
        /// </summary>
        /// <param name="board"></param>
        /// <param name="reward"></param>
        public void ApplyReward(BoardModel board, string reward, int row, int column)
        {
            // Determine the type of reward and apply it
            if (reward == "Fake Reward")
            {
                // Determine if the cell has a bomb
                if (board.Grid[row, column].IsMine)
                {
                    board.Grid[row, column].IsDiffused = true;
                }
                else
                {
                    return;
                }
            }
            else if (reward == "Reveal Random Safe Spot")
            {
                // Loop through the board and reveal a random safe spot
                for (int index = 0; index < board.Size; index++)
                {
                    // Set a random object
                    Random random = new Random();
                    // Declare and initialize
                    int aRow = random.Next(board.Size);
                    int col = random.Next(board.Size);
                    // Determine if a random cell is revealed and safe
                    if (!board.Grid[aRow, col].IsRevealed && !board.Grid[aRow, col].IsMine)
                    {
                        RevealCell(board, aRow, col);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                    
                }
            }
            else if (reward == "Locate a Random Mine")
            {
                // Loop through the board and reveal a random mine
                for (int index = 0; index < board.Size; index++)
                {
                    // Set a random object
                    Random random = new Random();
                    // Declare and initialize
                    int aRow = random.Next(board.Size);
                    int col = random.Next(board.Size);
                    // Determine if a random cell is revealed and safe
                    if (board.Grid[aRow, col].IsMine)
                    {
                        board.Grid[aRow, col].IsDiffused = true;
                        RevealCell(board, aRow, col);
                        break;
                    }
                    else
                    {
                        continue;
                    }

                }
            }
        }
    } // End of MineSweeperLogic class
} // End of namespace


