/*
 * Jacob Cutler
 * CST-250
 * 02/22/2026
 * Mine Sweeper Game
 * Milestone Project
 */

using MineSweeperClassLibrary.Services.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClassLibrary.Models
{
    public class BoardModel
    {
        // Class level properties
        public int Size { get; private set; }
        public CellModel[,] Grid { get; private set; }
        public bool Won { get; set; }
        public bool Lost { get; set; }
        public bool InProgress { get; set; }

        /// <summary>
        /// Default constructor for BoardModel
        /// </summary>
        /// <param name="size"></param>
        public BoardModel(int size)
        {
            // Initialize the properties for the model
            Size = size;
            Grid = new CellModel[Size, Size];
            Won = false;
            Lost = false;
            InProgress = true;

            // Create the board
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            // Loop through the rows of the grid
            for (int row = 0; row < Size; row++)
            {
                // Loop through the columns of the grid
                for (int col = 0; col < Size; col++)
                {
                    // Set each index to a new CellModel using the row and column
                    Grid[row, col] = new CellModel(row, col);
                }
            }
        }

        /// <summary>
        /// Fill the board using recursion
        /// </summary>
        /// <param name="board"></param>
        /// <param name="logic"></param>
        public void FloodFill(int row, int col)
        {

            // Check if the cell is on the board
            if (row < 0 || row >= Size || col < 0 || col >= Size)
            {
                return;
            }
            // Check if the cell has already been filled
            if (Grid[row, col].IsFilled)
            {
                return;
            }
            // Check if the cells should be revealed
            else if (!Grid[row, col].IsFilled)
            {
                Grid[row, col].IsRevealed = true;
                Grid[row, col].IsFilled = true;
            }

            // Call the method to itself
            FloodFill(row - 1, col);
            FloodFill(row, col + 1);
            FloodFill(row + 1, col);
            FloodFill(row, col + 1);

        } // End of FloodFill Method
    }
}
