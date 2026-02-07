/*
 * Jacob Cutler
 * CST - 250
 * 02/08/2026
 * Chess Board Project
 * Activity 2
 */

using ChessBoardClassLibrary.Models;
using ChessBoardClassLibrary.Services.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace ChessBoardGUIApp
{
    public partial class FrmChessBoard : Form
    {
        // Class level variables
        private BoardModel _board;
        private BoardLogic _boardLogic;
        // 2D array of buttons for the chess board
        private Button[,] _buttons;

        /// <summary>
        /// Default constructor for FrmChessBoard
        /// </summary>
        public FrmChessBoard()
        {
            InitializeComponent();

            // Initialize the class level variables
            _board = new BoardModel(8);
            _boardLogic = new BoardLogic();
            _buttons = new Button[8, 8];

            // Set up the panel with buttons
            SetUpButtons();
        }

        /// <summary>
        /// Click even handler for the chess board buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSquareClickEH(object sender, EventArgs e)
        {
            // Declare and initialize
            Button button = (Button)sender;
            Point point = (Point)button.Tag;
            int row = point.X;
            int col = point.Y;
            string piece = cmbChessPieces.Text;

            if (piece == "")
            {
                MessageBox.Show("Please select a chess piece from the dropdown menu.");
                return;
            }
            else
            {
                // Show the user their choice
                MessageBox.Show($"You clicked on row {row} and column {col}");
                // Send the board, current cell, and piece to the business logic layer
                _board = _boardLogic.MarkLegalMoves(_board, _board.Grid[row, col], piece);
                // Update the buttons
                UpdateButtons();
            }
        } // End of BtnSquareClick Event Handler method

        /// <summary>
        /// Submit button click event handler to update the colors of the chess board based on the user's selection from the combo boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitColorEH(object sender, EventArgs e)
        {
            SetGridAndTextColor(cmbPrimaryColor.Text, cmbSecondaryColor.Text, cmbTextColors.Text);
        } // End of btnSubmitColorEH event handler method

        /// <summary>
        /// Populate the panel control with buttons
        /// </summary>
        private void SetUpButtons()
        {
            // Declare and initialize
            // Calculate the size of each button based on the panel width and the number of buttons needed
            int buttonSize = pnlChessBoard.Width / _board.Size;
            // Set the panel to be square
            pnlChessBoard.Height = pnlChessBoard.Width;
            // Use nested for loops to loop through the boards Grid
            for (int row = 0; row < _board.Size; row++)
            {
                for (int col = 0; col < _board.Size; col++)
                {
                    // Set up each individual button
                    // Create a new button in the 2D array
                    _buttons[row, col] = new Button();
                    // Get the current button
                    Button button = _buttons[row, col];
                    // Set the size for the button
                    button.Width = buttonSize;
                    button.Height = buttonSize;
                    // Set the location of the button using the lef and top sides
                    button.Left = row * buttonSize;
                    button.Top = col * buttonSize;
                    // Attach a click event handler to the button
                    button.Click += BtnSquareClickEH;
                    // Store the location of the button in the Tag property using a Point object
                    button.Tag = new Point(row, col);
                    // Set the text for the button
                    button.Text = $"{row}, {col}";
                    // Add the button to the panels controls
                    pnlChessBoard.Controls.Add(_buttons[row, col]);
                    
                }
            }
        } // End of SetUpButtons method

        /// <summary>
        /// Update the text for each button based on the board
        /// </summary>
        private void UpdateButtons()
        {
            // Delcare and initialize
            string piece;
            // Set up a dictionary to get the names of the chess pieces
            Dictionary<string, string> pieceMap = new Dictionary<string, string>
            {
                { "N", "Knight" },
                { "R", "Rook" },
                { "B", "Bishop" },
                { "Q", "Queen" },
                { "K", "King" }
            };

            // Loop through each cell in the grid to update the corresponding button
            for (int row = 0; row < _board.Size; row++)
            {
                for (int col = 0; col < _board.Size; col++)
                {
                    if (_board.Grid[row, col].PieceOccupyingCell != "")
                    {
                        // Use the dictionary to get the name of the chess piece
                        piece = pieceMap[_board.Grid[row, col].PieceOccupyingCell];
                        // Update the text for the button
                        _buttons[row, col].Text = piece;
                    }
                    else if (_board.Grid[row, col].IsLegalNextMove)
                    {
                        // Set the text to show a legal move
                        _buttons[row, col].Text = "Legal Move";
                    }
                    else
                    {
                        // Clear the text for any other buttons
                        _buttons[row, col].Text = "";
                    }
                }
            }
        } // End of UpdateButtons method

        /// <summary>
        /// Set the colors for the grid and text based on the user's selection from the combo boxes
        /// </summary>
        /// <param name="primary"></param>
        /// <param name="secondary"></param>
        /// <param name="text"></param>
        private void SetGridAndTextColor(string primary, string secondary, string text)
        {
            for (int row = 0; row < _board.Size; row++)
            {
                for (int col = 0; col < _board.Size; col++)
                {
                    // Set the text color for the button
                    _buttons[row, col].ForeColor = Color.FromName(text);
                    // Set the background color for the button based on whether the row and column are even or odd
                    if ((row + col) % 2 == 0)
                    {
                        _buttons[row, col].BackColor = Color.FromName(primary);
                    }
                    else
                    {
                        _buttons[row, col].BackColor = Color.FromName(secondary);
                    }
                }
            }
        } // End of SetGridAndTextColor method
    }
}
