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

        /// <summary>
        /// Default constructor for BoardModel
        /// </summary>
        /// <param name="size"></param>
        public BoardModel(int size)
        {
            // Initialize the properties for the model
            Size = size;
            Grid = new CellModel[Size, Size];

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
    }
}
