/*
 * Jacob Cutler
 * CST-250
 * 03/01/2026
 * Whack-A-Mole
 * Activity 5
 */

namespace WhackAMole
{
    public partial class FrmStopWatch : Form
    {
        // Class level variable to hold the timers time
        TimeSpan timeElapsed = new TimeSpan();
        // Create a new Random object to generate numbers
        Random random = new Random();
        // Create a score variable
        private int _score = 0;
        // Create a high scores list
        List<TimeSpan> highScores = new List<TimeSpan>();
        // Create a private speed variable
        private int _speed = 3;

        /// <summary>
        /// Default constructor for FrmStopWatch
        /// Initializes the form
        /// </summary>
        public FrmStopWatch()
        {
            // Initialize the form
            InitializeComponent();
        } // End of FrmStopwatch

        /// <summary>
        /// Click event handler for btnStart
        /// Starts the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartClickEH(object sender, EventArgs e)
        {
            // Start the timer
            tmrStopwatch.Start();
        } // End BtnStartClickEH

        /// <summary>
        /// Click event handler for btnStop
        /// Stops the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStopClickEH(object sender, EventArgs e)
        {
            // Stop the timer
            tmrStopwatch.Stop();
        } // End of BtnStopClickEH

        /// <summary>
        /// Tick event handler for tmrStopwatch
        /// Updates the timeElapsed variable and the label
        /// Moves btnTarget every three seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrStopwatchTickEH(object sender, EventArgs e)
        {
            // Get teh interval from tmrStopwatch
            int interval = tmrStopwatch.Interval;
            // And the timers interval to timeelapsed
            timeElapsed = timeElapsed.Add(TimeSpan.FromMilliseconds(interval));
            // Show the timeElapsed on the label
            lblTimeElapsed.Text = timeElapsed.ToString();
            // Check if it is time to move the target button
            if (timeElapsed.Seconds % _speed == 0)
            {
                // Select a new location for the top of btnTarget
                // Randomly generate a location for the top of the button
                // between 0 and the form height minus the button height
                btnTarget.Top = random.Next(50, this.Height - (btnStart.Height * 10));
                // Select a new location for the left side of btnTarget
                btnTarget.Left = random.Next(0, this.Height - btnTarget.Width - lblHighScoresTitle.Width);
                // Get random numbers for the RGB color for the button
                btnTarget.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

                // Set the target to be visible
                btnTarget.Visible = true;
            }
        } // End of TmrStopwatchTickEH

        /// <summary>
        /// Click Event Handler for btnReset
        /// Reset the timer and related variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResetClickEH(object sender, EventArgs e)
        {
            ResetGame();
        } // End of BtnResetClickEH

        /// <summary>
        /// Click event handler for btnTarget to hide the target
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTargetClickEH(object sender, EventArgs e)
        {
            // Hide the target
            btnTarget.Visible = false;
            // Update the score when the button is clicked
            _score += 10;
            // Update the lblScore to the current score
            lblScore.Text = _score.ToString();
            // Make the button smaller when the player gets over 100 points
            if (_score == 100)
            {
                btnTarget.Size = btnTarget.Size / 2;
            }
            // Make the button smaller when the player gets over 400 points
            if (_score == 400)
            {
                btnTarget.Size = btnTarget.Size / 2;
            }
            // If the score limit is reached
            if (_score == 90)
            {
                //Stop the stopwatch
                tmrStopwatch.Stop();
                // Show the message
                MessageBox.Show($"Score reached.\nYour time: {timeElapsed}");
                // Reset the game
                ResetGame();
            }
        } // End of BtnTargetClickEH

        /// <summary>
        /// Add 5 seconds as a penalty to miss clicking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStopwatchClickEH(object sender, EventArgs e)
        {
            timeElapsed += TimeSpan.FromSeconds(5);
        } // End of FrmStopwatchClickEH

        /// <summary>
        /// Event handler for when a radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoButtonChangedEH(object sender, EventArgs e)
        {
            // Reset the game
            ResetGame();
            // Create a new radio button object
            RadioButton rdo = (RadioButton)sender;
            // Create a switch statement to determine the speed
            switch (rdo.Text)
            {
                case "Slow":
                    _speed = 3;
                    break;
                case "Medium":
                    _speed = 2;
                    break;
                case "Fast":
                    _speed = 1;
                    break;
            }
        } // End of RdoButtonChangedEH

        /// <summary>
        /// Event handler for the when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStopwatchLoadEH(object sender, EventArgs e)
        {
            // Set to easy as default
            rdoSlow.Checked = true;
            // Make sure the timer is stopped
            tmrStopwatch.Stop();
            // Set the speed
            _speed = 3;
        }

        /// <summary>
        /// Reset the game
        /// Update the high score
        /// </summary>
        private void ResetGame()
        {
            // Stop the timer
            tmrStopwatch.Stop();
            // Reset the size of the target button
            btnTarget.Width = 150;
            btnTarget.Height = 120;
            // Add the current time if game was completed
            if (_score == 90)
            {
                // Add the score to the list
                highScores.Add(timeElapsed);

                // Sort from fastest to slowest
                highScores.Sort();

                // Keep only top 10
                if (highScores.Count > 10)
                {
                    // Remove the lowest score
                    highScores.RemoveAt(10);
                }
            }
            // Update the high scores
            UpdateHighScoreLabels();

            // Reset values
            timeElapsed = TimeSpan.Zero;
            lblTimeElapsed.Text = timeElapsed.ToString();
            // Reset the score
            _score = 0;
            lblScore.Text = "0";
        } // End of ResetGame

        /// <summary>
        /// Update the labels for the high scores
        /// </summary>
        private void UpdateHighScoreLabels()
        {
            // Remove old dynamic labels (except the first one)
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                // Remove the old label
                if (this.Controls[i] is Label lbl &&
                    lbl.Name.StartsWith("lblHighScore") && lbl.Name != "lblHighScore" && lbl.Name != "lblHighScoresTitle")
                {
                    this.Controls.RemoveAt(i);
                }
            }

            // Update first label
            if (highScores.Count > 0)
            {
                // Set the text of the label
                lblHighScore.Text = highScores[0].ToString();
            }
            else
            {
                // Set the text if there are no scores
                lblHighScore.Text = "No Scores";
            }

            // Add remaining labels
            for (int i = 1; i < highScores.Count; i++)
            {
                // Create a new label
                Label newLabel = new Label();
                // Update the name of the label
                newLabel.Name = $"lblHighScore{i}";
                // Change the text of the label
                newLabel.Text = highScores[i].ToString();
                // Allow the label to autosize
                newLabel.AutoSize = true;
                // Place the label on the form in an appropriate order
                newLabel.Location = new Point(lblHighScore.Left, lblHighScore.Top + (lblHighScore.Height * i)
                );
                // Add the label to the form
                this.Controls.Add(newLabel);
            }
        } // End of UpdateHighScoreLabels
    }
}
