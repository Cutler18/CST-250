/*
 * Jacob Cutler
 * CST-250
 * 03/15/2026
 * Minesweeper Project
 * Milestone 6
 */

using Microsoft.VisualBasic.Logging;
using MineSweeperClassLibrary.Models;
using MineSweeperClassLibrary.Services.BusinessLogicLayer;
using MineSweeperGUI.Forms;
using System.Data.Common;

namespace MineSweeperGUI
{
    public partial class FrmMineSweeper : Form
    {
        // Class level variables
        private BoardModel _board;
        private MineSweeperLogic _logic;
        private int _score;
        private int _difficulty;
        private int _style;
        private bool _multiply = false;
        // 2D array of buttons for the minesweeper board
        private Button[,] _buttons;
        // Timespan variable to track the time
        TimeSpan elapsedTime = new TimeSpan();

        /// <summary>
        /// Default constructor for FrmMineSweeper
        /// </summary>
        public FrmMineSweeper()
        {
            // Initialize the board
            InitializeComponent();

            // Initialize the variables
            _logic = new MineSweeperLogic();

            // Set the default style of the form
            // Change the form style
            this.ForeColor = Color.Black;
            this.BackColor = Color.White;

            // Change the start button style
            btnStartGame.BackgroundImage = null;
            btnStartGame.BackColor = Color.White;
            btnStartGame.ForeColor = Color.Black;

            // Change the high score button style
            btnHighScores.BackgroundImage = null;
            btnHighScores.BackColor = Color.White;
            btnHighScores.ForeColor = Color.Black;

            // Change the reset button style
            btnReset.BackgroundImage = null;
            btnReset.BackColor = Color.White;
            btnReset.ForeColor = Color.Black;

            // Change the score label style
            lblScore.BackColor = Color.White;
            lblScore.ForeColor = Color.Black;

            // Change the action group box style
            grpAction.BackColor = Color.White;
            grpAction.ForeColor = Color.Black;

            // Change the style group box style
            grpStyle.BackColor = Color.White;
            grpStyle.ForeColor = Color.Black;

            // Change the style of the timer label
            lblTimer.ForeColor = Color.Black;
            lblTimer.BackColor = Color.White;
        }

        /// <summary>
        /// Open the high scores form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHighScoresClickEH(object sender, EventArgs e)
        {
            // Open the high scores form
            FrmHighScores dlg = new FrmHighScores();
            dlg.ShowDialog();
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

            // Check which cells are revealed and give a score based on time and revealed cells
            if (!_board.Grid[row, col].IsMine && action == "Reveal")
            {
                // Based on time elapsed
                if (elapsedTime < TimeSpan.FromSeconds(10) && !_board.Grid[row, col].IsReward)
                {
                    if (_multiply == true)
                        _score += 60;
                    else
                        _score += 30;
                }
                else if (elapsedTime < TimeSpan.FromSeconds(30) && !_board.Grid[row, col].IsReward)
                {
                    if (_multiply == true)
                        _score += 40;
                    else
                        _score += 20;
                }
                else if (elapsedTime < TimeSpan.FromSeconds(60) && !_board.Grid[row, col].IsReward)
                {
                    if (_multiply == true)
                        _score += 20;
                    else
                        _score += 10;
                }
                else
                {
                    if (_multiply == true)
                        _score += 6;
                    else
                        _score += 3;
                }
            }
            // Check if the user clicked on a reward
            if (_board.Grid[row, col].IsReward)
            {
                _score += 5;
            }
            // Update the score label
            lblScore.Text = _score.ToString();

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

        /// <summary>
        /// Start the game by calling reset game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartGameClickEH(object sender, EventArgs e)
        {
            // Get the difficulty and draw the board
            ResetGame();

            // Make the reset game button visible
            btnReset.Visible = true;
            // Make the start button not visible
            btnStartGame.Visible = false;
        }

        /// <summary>
        /// Tick event handler for the minesweeper timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrMinesweeperTickEH(object sender, EventArgs e)
        {
            // Get teh interval from tmrStopwatch
            int interval = tmrMinesweeper.Interval;
            // And the timers interval to timeelapsed
            elapsedTime = elapsedTime.Add(TimeSpan.FromMilliseconds(interval));
            // Show the timeElapsed on the label
            lblTimer.Text = elapsedTime.ToString();
        }

        /// <summary>
        /// Event handler for checked changed on the style radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoStylesCheckedChangedEH(object sender, EventArgs e)
        {
            // Create a radio button object
            RadioButton rdo = sender as RadioButton;

            // Check if the radio button is already checked
            if (!rdo.Checked)
            {
                // Return so nothing happens
                return;
            }

            // Change the style of the form
            if (rdoDefault.Checked)
            {
                // Change the form style
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;

                // Change the start button style
                btnStartGame.BackgroundImage = null;
                btnStartGame.BackColor = Color.White;
                btnStartGame.ForeColor = Color.Black;

                // Change the high score button style
                btnHighScores.BackgroundImage = null;
                btnHighScores.BackColor = Color.White;
                btnHighScores.ForeColor = Color.Black;

                // Change the reset button style
                btnReset.BackgroundImage = null;
                btnReset.BackColor = Color.White;
                btnReset.ForeColor = Color.Black;

                // Change the score label style
                lblScore.BackColor = Color.White;
                lblScore.ForeColor = Color.Black;

                // Change the action group box style
                grpAction.BackColor = Color.White;
                grpAction.ForeColor = Color.Black;

                // Change the style group box style
                grpStyle.BackColor = Color.White;
                grpStyle.ForeColor = Color.Black;

                // Change the style of the timer label
                lblTimer.ForeColor = Color.Black;
                lblTimer.BackColor = Color.White;
            }

            else if (rdoDungeon.Checked)
            {
                // Change the form style
                this.ForeColor = Color.SandyBrown;
                this.BackColor = Color.SaddleBrown;

                // Change the start button style
                btnStartGame.BackgroundImage = Properties.Resources.TileEmpty;
                btnStartGame.ForeColor = Color.SandyBrown;

                // Change the high score button style
                btnHighScores.BackgroundImage = Properties.Resources.TileEmpty;
                btnHighScores.ForeColor = Color.SandyBrown;

                // Change the reset button style
                btnReset.BackgroundImage = Properties.Resources.TileEmpty;
                btnReset.ForeColor = Color.SandyBrown;

                // Change the score label style
                lblScore.BackColor = Color.Brown;
                lblScore.ForeColor = Color.NavajoWhite;

                // Change the action group box style
                grpAction.BackColor = Color.SaddleBrown;
                grpAction.ForeColor = Color.Black;

                // Change the style group box style
                grpStyle.BackColor = Color.SaddleBrown;
                grpStyle.ForeColor = Color.Black;

                // Change the style of the timer label
                lblTimer.ForeColor = Color.White;
                lblTimer.BackColor = Color.SaddleBrown;
            }
            else if (rdoMexican.Checked)
            {
                // Change the form style
                this.ForeColor = Color.White;
                this.BackColor = Color.Green;

                // Change the start button style
                btnStartGame.BackgroundImage = null;
                btnStartGame.BackColor = Color.Red;
                btnStartGame.ForeColor = Color.Green;

                // Change the high score button style
                btnHighScores.BackgroundImage = null;
                btnHighScores.BackColor = Color.Red;
                btnHighScores.ForeColor = Color.Green;

                // Change the reset button style
                btnHighScores.BackgroundImage = null;
                btnHighScores.BackColor = Color.Red;
                btnHighScores.ForeColor = Color.Green;

                // Change the score label style
                lblScore.BackColor = Color.DarkGreen;
                lblScore.ForeColor = Color.White;

                // Change the action group box style
                grpAction.BackColor = Color.Green;
                grpAction.ForeColor = Color.White;

                // Change the style group box style
                grpStyle.BackColor = Color.Green;
                grpStyle.ForeColor = Color.White;

                // Change the style of the timer label
                lblTimer.ForeColor = Color.White;
                lblTimer.BackColor = Color.Green;
            }
            else if (rdoPatriotic.Checked)
            {
                // Change the form style
                this.ForeColor = Color.Red;
                this.BackColor = Color.LightBlue;

                // Change the start button style
                btnStartGame.BackgroundImage = null;
                btnStartGame.BackColor = Color.DarkBlue;
                btnStartGame.ForeColor = Color.White;

                // Change the high score button style
                btnStartGame.BackgroundImage = null;
                btnStartGame.BackColor = Color.DarkBlue;
                btnStartGame.ForeColor = Color.White;

                // Change the reset button style
                btnStartGame.BackgroundImage = null;
                btnStartGame.BackColor = Color.DarkBlue;
                btnStartGame.ForeColor = Color.White;

                // Change the score label style
                lblScore.BackColor = Color.Blue;
                lblScore.ForeColor = Color.Red;

                // Change the action group box style
                grpAction.BackColor = Color.LightBlue;
                grpAction.ForeColor = Color.Red;

                // Change the style group box style
                grpStyle.BackColor = Color.LightBlue;
                grpStyle.ForeColor = Color.Red;

                // Change the style of the timer label
                lblTimer.ForeColor = Color.White;
                lblTimer.BackColor = Color.DarkBlue;
            }
            // Reset the game
            ResetGame();
            // Make the reset game button visible
            btnReset.Visible = true;
            // Make the start button not visible
            btnStartGame.Visible = false;
        }

        /// <summary>
        /// Set up the buttons within the panel for the game
        /// </summary>
        private void SetUpButtons()
        {// Set the style
            _style = GetStyle();
            // Declare and initialize
            _difficulty = GetDifficulty();
            // Set the panel size
            SetBoardSize(_difficulty);
            // Declare and initialize
            int _size = _logic.GetBoardSize(_difficulty);
            // Set the board size
            SetBoardSize(_difficulty);
            _buttons = new Button[_size, _size];
            _board = new BoardModel(_size);
            // Set the game state
            _board.Lost = false;
            _board.Won = false;
            // Place the mines on the board
            _logic.PlaceMines(_board, _logic.NumberOfMines(_difficulty));
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
                    // Use a switch case for the styles
                    
                    switch (_style)
                    {
                        case 1:
                            button.BackColor = Color.DarkGray;
                            button.Text = "";
                            break;
                        case 2:
                            // Set the image layout and background image
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                            button.BackgroundImage = Properties.Resources.TileNotRevealed;
                            break;
                        case 3:
                            button.BackColor = Color.Green;
                            button.Text = "";
                            break;
                        case 4:
                            button.BackColor = Color.Blue;
                            button.Text = "";
                            break;
                    }
                }
            }
            // Start the timer
            tmrMinesweeper.Start();
        } // End of SetUpButtons method

        /// <summary>
        /// Set the size of the panel
        /// </summary>
        /// <param name="difficulty"></param>
        private void SetBoardSize(int difficulty)
        {
            // Set the size of the board based on the difficulty
            pnlMineSweeperBoard.Width = ((difficulty * 250) + 250);
        }

        /// <summary>
        /// Get the difficulty from the radio buttons
        /// </summary>
        /// <returns></returns>
        private int GetDifficulty()
        {
            // Use the get difficulty form
            using (FrmGetDifficulty dlg = new FrmGetDifficulty())
            {
                // Show the dialog and make sure it returns OK
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Return the difficulty
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
        /// Get the style from the radio buttons
        /// </summary>
        /// <returns></returns>
        private int GetStyle()
        {
            // Determine the style based on the users selection
            if (rdoDefault.Checked)
                return 1;
            else if (rdoDungeon.Checked)
                return 2;
            else if (rdoMexican.Checked)
                return 3;
            else
                return 4;
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
            // Reset the score
            _score = 0;
            lblScore.Text = "0";
            // Restart the time
            elapsedTime = TimeSpan.Zero;
            lblTimer.Text = "00:00:00";
            // Set up the buttons
            SetUpButtons();
        }

        /// <summary>
        /// Play the game
        /// </summary>
        private async Task PlayGame(Button button, Point point, int row, int col, string action)
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
                            // Stop the timer
                            tmrMinesweeper.Stop();
                            // Print a message for losers
                            MessageBox.Show("You hit a mine. Game over!");
                            // Reset the timer label
                            lblTimer.Text = "00:00:00";
                            // Reset the game
                            ResetGame();
                        }
                        // Check if the game is won
                        else if (_board.Won)
                        {
                            _board.FloodFill(0, 0);
                            // Stop the timer
                            tmrMinesweeper.Stop();
                            // Set the date and time of the high score
                            DateTime date = DateTime.Now;
                            // Call a new form
                            FrmGetHighScoreInfo dlg = new FrmGetHighScoreInfo(_score, _difficulty, elapsedTime.ToString(), date);
                            // Show the form
                            dlg.ShowDialog();
                            // Reset the timer label
                            lblTimer.Text = "00:00:00";
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
                        switch (_style)
                        {
                            case 1:
                                button.BackColor = Color.LightGray;
                                button.ForeColor = Color.Orange;
                                button.Text = "F";
                                break;
                            case 2:
                                // Set the image layout and background image
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                                button.BackgroundImage = Properties.Resources.Flag;
                                break;
                            case 3:
                                button.BackColor = Color.DarkOliveGreen;
                                button.ForeColor = Color.Pink;
                                button.Text = "|^";
                                break;
                            case 4:
                                button.BackColor = Color.DarkSlateBlue;
                                button.ForeColor = Color.PaleVioletRed;
                                button.Text = "|^";
                                break;
                        }
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
                        // Use a switch case to apply the reward
                        switch (reward)
                        {
                            // If the reward is define in the logic, call the logic method
                            case "Fake Reward":
                                _logic.ApplyReward(_board, reward, row, col);
                                break;
                            case "Reveal Random Safe Spot":
                                _logic.ApplyReward(_board, reward, row, col);
                                break;
                            case "Locate Random Mine":
                                _logic.ApplyReward(_board, reward, row, col);
                                break;
                            // Stop the timer for 5 seconds
                            case "Time Stop":
                                // Stop the timer
                                tmrMinesweeper.Stop();
                                // Show the reward message
                                MessageBox.Show("Pause the timer for 5 seconds");
                                // Reset the action to reveal
                                rdoUseReward.Checked = false;
                                rdoReveal.Checked = true;
                                // Delay the task for 5 seconds, 5000 milliseconds
                                await Task.Delay(5000);
                                // Start the timer again once the 5 seconds is finished
                                tmrMinesweeper.Start();
                                break;
                            // Set the multiply variable to true for 5 seconds
                            case "Multiplier":
                                // Show the reward message
                                MessageBox.Show("2x points for 5 seconds");
                                // Set the reward bool to true
                                _multiply = true;
                                // Reset the action to reveal
                                rdoUseReward.Checked = false;
                                rdoReveal.Checked = true;
                                // Mulitply for 5 seconds, 5000 milliseconds
                                await Task.Delay(5000);
                                // After  the 5 seconds, reset the multiply bool to false
                                _multiply = false;
                                break;
                        }
                        // Set the reward to false
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
            // Get the style
            _style = GetStyle();
            // Get the mine count
            int mineCount = _logic.CountAdjacentMines(_board, r, c);
            // Only add numbers to the cells that are touching a mine
            if (mineCount > 0 && !_board.Grid[r, c].IsMine && !_board.Grid[r, c].IsReward)
            {
                // Use a switch case to determine which image to use
                switch (mineCount)
                {
                    case 1:
                        // Separate dungeon style vs the rest
                        if (_style == 2)
                        {
                            // Set the image layout and background image
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            btn.BackgroundImage = Properties.Resources.Number_1;
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.DarkGreen;
                            btn.Text = "1";
                        }
                        break;
                    case 2:
                        // Separate dungeon style vs the rest
                        if (_style == 2)
                        {
                            // Set the image layout and background image
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            btn.BackgroundImage = Properties.Resources.Number_2;
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.LightGreen;
                            btn.Text = "2";
                        }
                        break;
                    case 3:
                        // Separate dungeon style vs the rest
                        if (_style == 2)
                        {
                            // Set the image layout and background image
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            btn.BackgroundImage = Properties.Resources.Number_3;
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.DarkBlue;
                            btn.Text = "3";
                        }
                        break;
                    case 4:
                        // Separate dungeon style vs the rest
                        if (_style == 2)
                        {
                            // Set the image layout and background image
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            btn.BackgroundImage = Properties.Resources.Number_4;
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.LightBlue;
                            btn.Text = "4";
                        }
                        break;
                    case 5:
                        // Separate dungeon style vs the rest
                        if (_style == 2)
                        {
                            // Set the image layout and background image
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            btn.BackgroundImage = Properties.Resources.Number_5;
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.MediumPurple;
                            btn.Text = "5";
                        }
                        break;
                    case 6:
                        // Separate dungeon style vs the rest
                        if (_style == 2)
                        {
                            // Set the image layout and background image
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            btn.BackgroundImage = Properties.Resources.Number_6;
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.HotPink;
                            btn.Text = "6";
                        }
                        break;
                    case 7:
                        // Separate dungeon style vs the rest
                        if (_style == 2)
                        {
                            // Set the image layout and background image
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            btn.BackgroundImage = Properties.Resources.Number_7;
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.DarkOrange;
                            btn.Text = "7";
                        }
                        break;
                    case 8:
                        // Separate dungeon style vs the rest
                        if (_style == 2)
                        {
                            // Set the image layout and background image
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            btn.BackgroundImage = Properties.Resources.Number_8;
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.OrangeRed;
                            btn.Text = "8";
                        }
                        break;
                }
            }
            else if (_board.Grid[r, c].IsReward)
            {
                // Use a switch case for the styles
                switch (_style)
                {
                    case 1:
                        btn.BackColor = Color.LightGray;
                        btn.ForeColor = Color.Black;
                        btn.Text = "R";
                        break;
                    case 2:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.Reward;
                        break;
                    case 3:
                        btn.BackColor = Color.LightGreen;
                        btn.ForeColor = Color.DarkGreen;
                        btn.Text = "$";
                        break;
                    case 4:
                        btn.BackColor = Color.LightBlue;
                        btn.ForeColor = Color.DarkBlue;
                        btn.Text = "$";
                        break;
                }

            }
            else if (_board.Grid[r, c].IsMine)
            {
                // Use a switch case for the styles
                switch (_style)
                {
                    case 1:
                        btn.BackColor = Color.LightGray;
                        btn.ForeColor = Color.Red;
                        btn.Text = "B";
                        break;
                    case 2:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.Mine;
                        break;
                    case 3:
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.Orange;
                        btn.Text = "*";
                        break;
                    case 4:
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.Yellow;
                        btn.Text = "*";
                        break;
                }
            }
            else if (mineCount == 0)
            {
                // Use a switch case for the styles
                switch (_style)
                {
                    case 1:
                        btn.BackColor = Color.White;
                        btn.Text = "";
                        break;
                    case 2:
                        // Set the image layout and background image
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Properties.Resources.TileEmpty;
                        break;
                    case 3:
                        btn.BackColor = Color.LightGreen;
                        btn.Text = "";
                        break;
                    case 4:
                        btn.BackColor = Color.White;
                        btn.Text = "";
                        break;
                }
            }
        }

        /// <summary>
        /// Draw the board
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private void DrawBoard(int row, int col)
        {
            // Set the style
            _style = GetStyle();
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
                            // Use a switch case for the styles
                            switch (_style)
                            {
                                case 1:
                                    btn.BackColor = Color.White;
                                    btn.Text = "";
                                    break;
                                case 2:
                                    // Set the image layout and background image
                                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                                    btn.BackgroundImage = Properties.Resources.TileEmpty;
                                    break;
                                case 3:
                                    btn.BackColor = Color.LightGreen;
                                    btn.Text = "";
                                    break;
                                case 4:
                                    btn.BackColor = Color.White;
                                    btn.Text = "";
                                    break;
                            }

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
    }
}
