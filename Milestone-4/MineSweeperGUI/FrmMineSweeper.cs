/*
 * Jacob Cutler
 * CST-250
 * 02/22/2026
 * Minesweeper Project
 * Milestone 4
 */

using Microsoft.VisualBasic.Logging;
using MineSweeperClassLibrary.Models;
using MineSweeperClassLibrary.Services.BusinessLogicLayer;
using System.Data.Common;

namespace MineSweeperGUI
{
    public partial class FrmMineSweeper : Form
    {
        // Class level variables
        private BoardModel _board;
        private MineSweeperLogic _logic;
        // 2D array of buttons for the minesweeper board
        private Button[,] _buttons;

        /// <summary>
        /// Default constructor for FrmMineSweeper
        /// </summary>
        public FrmMineSweeper()
        {
            // Initialize the board
            InitializeComponent();

            // Initialize the variables
            _logic = new MineSweeperLogic();

            // Start the game
            ResetGame();
        }

        /// <summary>
        /// Set up the buttons within the panel for the game
        /// </summary>
        private void SetUpButtons()
        {
            // Declare and initialize
            int difficulty = GetDifficulty();
            // Set the panel size
            SetBoardSize(difficulty);
            // Declare and initialize
            int _size = _logic.GetBoardSize(difficulty);
            // Set the board size
            SetBoardSize(difficulty);
            _buttons = new Button[_size, _size];
            _board = new BoardModel(_size);
            // Set the game state
            _board.Lost = false;
            _board.Won = false;
            // Place the mines on the board
            _logic.PlaceMines(_board, _logic.NumberOfMines(difficulty));
            _logic.PlaceRewards(_board);
            // Calculate the size of each button based on the panel with and the number of buttons needed
            int buttonSize = pnlMineSweeperBoard.Width / _size;
            // Use the nested for loops to loop through the boards Grid
            for (int row = 0; row < _size; row++)
            {
                for (int col = 0; col < _size; col++)
                {
                    // Set up each individual button
                    // Create a new button in the 2D array
                    _buttons[row, col] = new Button();
                    // Get the current button
                    Button button = _buttons[row, col];
                    // Set the size for the button
                    button.Width = buttonSize;
                    button.Height = buttonSize;
                    // Set the location of the button using the left and top sides
                    button.Left = row * buttonSize;
                    button.Top = col * buttonSize;
                    // Attach a click event handler to the button
                    button.Click += BtnCellClickEH;
                    // Store the location of the button in the Tag property using a Point object
                    button.Tag = new Point(row, col);
                    // Add the button to the panels controls
                    pnlMineSweeperBoard.Controls.Add(_buttons[row, col]);
                    // Set the image layout and background image
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.BackgroundImage = Properties.Resources.TileNotRevealed;
                }
            }
        } // End of SetUpButtons method

        /// <summary>
        /// Set the size of the panel
        /// </summary>
        /// <param name="difficulty"></param>
        private void SetBoardSize(int difficulty)
        {
            pnlMineSweeperBoard.Width = ((difficulty * 250) + 250);
        }

        /// <summary>
        /// Get the difficulty from the radio buttons
        /// </summary>
        /// <returns></returns>
        private int GetDifficulty()
        {
            using (FrmGetDifficulty dlg = new FrmGetDifficulty())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    return dlg.Difficulty;
                }
                else
                {
                    // If cancelled, default to Easy
                    return 1;
                }
            }
        }

        /// <summary>
        /// Get the action from the user based on the radio button
        /// </summary>
        /// <returns></returns>
        private string GetAction()
        {
            // If the user checks the reveal button
            if (rdoReveal.Checked)
            {
                // Return the action
                return "Reveal";
            }
            // If the user checks the flag button
            else if (rdoFlag.Checked)
            {
                // Return the action
                return "Flag";
            }
            // If the user checks the remove flag button
            else if (rdoRemoveFlag.Checked)
            {
                // Return the action
                return "Remove Flag";
            }
            // If the user checks the use reward button
            else
            {
                // Return the action
                return "Use Reward";
            }
        }

        /// <summary>
        /// Reset the game
        /// </summary>
        private void ResetGame()
        {
            // Clear the game board
            pnlMineSweeperBoard.Controls.Clear();
            // Set up the buttons
            SetUpButtons();
        }

        /// <summary>
        /// Play the game
        /// </summary>
        private void PlayGame(Button button, Point point, int row, int col, string action)
        {
            // Use a switch case to play the game based on the action
            switch (action)
            {
                // If the reveal action is used
                case "Reveal":
                    // Check if the cell is flagged first
                    if (!_board.Grid[row, col].IsFlagged)
                    {
                        // Reveal the cell
                        _logic.RevealCell(_board, row, col);
                        // Call DrawBoard
                        DrawBoard(row, col);

                        // Check if the game is over
                        if (_board.Lost)
                        {
                            _board.FloodFill(0, 0);
                            // Print a message for losers
                            MessageBox.Show("You hit a mine. Game over!");
                            // Reset the game
                            ResetGame();
                        }
                        // Check if the game is won
                        else if (_board.Won)
                        {
                            _board.FloodFill(0, 0);
                            // Write a message for winners
                            MessageBox.Show("You Win!");
                            // Reset the game
                            ResetGame();
                        }
                    }
                    break;
                // If the flag option is chosen
                case "Flag":
                    // Make sure the cell isn't already revealed
                    if (!_board.Grid[row, col].IsRevealed)
                    {
                        // Place the flag
                        _logic.PlaceFlag(_board, row, col);
                        // Change the color
                        button.BackColor = Color.Red;
                        // Change the background image
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.BackgroundImage = Properties.Resources.Flag;
                    }
                    break;
                // If the remove flag action is chosen
                case "Remove Flag":
                    // Make sure the cell is flagged
                    if (_board.Grid[row, col].IsFlagged)
                    {
                        // Remove the flag
                        _logic.RemoveFlag(_board, row, col);
                        // Change the color
                        button.BackColor = Color.White;
                        // Change the background image
                        button.BackgroundImage = Properties.Resources.TileNotRevealed;
                    }
                    break;
                // If the use reward option is chosen
                case "Use Reward":
                    // Make sure the cell is a reward
                    if (_board.Grid[row, col].IsReward)
                    {
                        // Use the reward
                        string reward = _logic.DetermineReward();
                        // Messagebox to show the reward
                        MessageBox.Show($"REWARD:\n{reward}");
                        // Apply the reward
                        _logic.ApplyReward(_board, reward, row, col);
                        // Set the reward to flase
                        _board.Grid[row, col].IsReward = false;
                        // Declare a mineCount variable
                        int mines = _logic.CountAdjacentMines(_board, row, col);
                        // Draw the board
                        DrawBoard(row, col);
                    }
                    break;
            }
        }

        /// <summary>
        /// Set the tiles to images based on what they are
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <param name="btn"></param>
        private void SetTiles(int r, int c, Button btn)
        {
            // Get the mine count
            int mineCount = _logic.CountAdjacentMines(_board, r, c);
            // Only add numbers to the cells that are touching a mine
            if (mineCount > 0 && !_board.Grid[r, c].IsMine && !_board.Grid[r, c].IsReward)
            {
                // Use a switch case to determine which image to use
                switch (mineCount)
                {
                    case 1:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.Number_1;
                        break;
                    case 2:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.Number_2;
                        break;
                    case 3:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.Number_3;
                        break;
                    case 4:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.Number_4;
                        break;
                    case 5:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.Number_5;
                        break;
                    case 6:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.Number_6;
                        break;
                    case 7:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.Number_7;
                        break;
                    case 8:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.Number_8;
                        break;
                }
            }
            else if (_board.Grid[r, c].IsReward)
            {
                // Set the image layout and background image
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackgroundImage = Properties.Resources.Reward;
            }
            else if (_board.Grid[r, c].IsMine)
            {
                // Set the image layout and background image
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackgroundImage = Properties.Resources.Mine;
            }
            else if (mineCount == 0)
            {
                // Set the image layout and background image
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackgroundImage = Properties.Resources.TileEmpty;
            }
        }

        /// <summary>
        /// Draw the board
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private void DrawBoard(int row, int col)
        {
            // Determine if the revealed cells are not mines
            if (_board.Grid[row, col].IsRevealed && !_board.Grid[row, col].IsMine)
            {
                // Loop the cells to determine which are revealed
                for (int r = 0; r < _board.Size; r++)
                {
                    for (int c = 0; c < _board.Size; c++)
                    {
                        // Determine if the cell needs to be revealed
                        if (_board.Grid[r, c].IsRevealed)
                        {
                            // Create a button object for the cell to be revealed
                            Button btn = _buttons[r, c];
                            // Set the image layout and background image
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            btn.BackgroundImage = Properties.Resources.TileEmpty;

                            // Set the tiles
                            SetTiles(r, c, btn);
                        }
                    }
                }
            }
            // If the cell is a mine
            else if (_board.Grid[row, col].IsRevealed && _board.Grid[row, col].IsMine)   
            {
                // Reveal all cells
                _board.FloodFill(0, 0);
                // Game lost
                _board.Lost = true;
                // Loop through each cell to reveal the entire board
                for (int r = 0; r < _board.Size; r++)
                {
                    for (int c = 0; c < _board.Size; c++)
                    {
                        // Create a button for each cell
                        Button btn = _buttons[r, c];

                        // Call Set Tiles
                        SetTiles(r, c, btn);
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for clicking the buttons in the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCellClickEH(object sender, EventArgs e)
        {
            // Declare and initialize
            Button button = (Button)sender;
            Point point = (Point)button.Tag;
            int row = point.X;
            int col = point.Y;
            string action = GetAction();

            // Play the game
            PlayGame(button, point, row, col, action);
        }

        /// <summary>
        /// Click Event handler for BtnResetGame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResetGameClickEH(object sender, EventArgs e)
        {
            // Call the reset game method
            ResetGame();
        }
    }
}
