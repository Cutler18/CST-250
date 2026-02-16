/*
 * Jacob Cutler
 * CST-250
 * 02/15/2026
 * Flood Fill Recursion
 * Activity 3
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodFillRecursion.Models
{
    internal class BoardModel
    {
        // BoardModel Properties
        public int Size { get; set; }
        public CellModel[,] Grid { get; set; }
        public int NumShapes { get; set; }

        /// <summary>
        /// Parameterized constructor for BoardModel
        /// </summary>
        /// <param name="size"></param>
        /// <param name="numShapes"></param>
        public BoardModel(int size, int numShapes)
        {
            Size = size;
            NumShapes = numShapes;
            Grid = new CellModel[Size, Size];
            // Set up the Grid
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Grid[row, col] = new CellModel(row, col, "E");
                }
            }
            // Place random shapes on the board
            PlaceShapes();
        }

        /// <summary>
        /// Create shapes to place on the board
        /// </summary>
        private void PlaceShapes()
        {
            // Dcclare and initialize
            // Random object to generate numbers
            Random random = new Random();
            int shapeSize = Size / 2, row = 0, col = 0;

            // Create three shapes
            for (int shapes = 0; shapes < NumShapes; shapes++)
            {
                // Generate the row and col for the top left corner of the square
                row = random.Next(0, Size - shapeSize + 1);
                col = random.Next(0, Size - shapeSize + 1);

                for (int offset = 0; offset < shapeSize; offset++)
                {
                    // The first shape is a square
                    if (shapes == 0)
                    {
                        // Top Wall
                        Grid[row, col + offset].Contents = "S";
                        // Bottom wall
                        Grid[row + shapeSize - 1, col + offset].Contents = "S";
                        // Left Wall
                        Grid[row + offset, col].Contents = "S";
                        // Right Wall
                        Grid[row + offset, col + shapeSize - 1].Contents = "S";
                    }
                    // If it is the second shape draw a triangle
                    else if (shapes == 1)
                    {
                        // Bottom Wall
                        Grid[row + shapeSize - 1, col + offset].Contents = "T";
                        // Left Wall
                        Grid[row + offset, col].Contents = "T";
                        // Right angled wall
                        Grid[row + offset, col + offset].Contents = "T";
                    }
                    // Everything else is a diamond
                    else if (shapes >= 2)
                    {
                        // Create variables to ensure the shape stays in bounds
                        int radius = shapeSize / 2;
                        int centerX = row + radius;
                        int centerY = col + radius;
                        
                        // Make sure the sides arent too long
                        if (offset < radius)
                        {
                            // Top right
                            if (centerY - radius + offset < Size && centerX + offset < Size)
                            {
                                Grid[centerY - radius + offset, centerX + offset].Contents = "D";
                            }
                            // Bottom right
                            if (centerY + offset < Size && centerX + radius - offset < Size)
                            {
                                Grid[centerY + offset, centerX + radius - offset].Contents = "D";
                            }
                            // Top left
                            if (centerY + radius - offset >= 0 && centerX - offset >= 0)
                            {
                                Grid[centerY + radius - offset, centerX - offset].Contents = "D";
                            }
                            // Bottom left
                            if (centerY - offset >= 0 && centerX - (radius - offset) >= 0)
                            {
                                Grid[centerY - offset, centerX - (radius - offset)].Contents = "D";
                            }
                        }
                    }
                }
            }
        } // End of PlaceShapes method
    }
}
