/*
 * Jacob Cutler
 * CST-250
 * 03/15/2026
 * Minesweeper Project
 * Milestone 6
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MineSweeperClassLibrary.Models;

namespace MineSweeperGUI.Forms
{
    public partial class FrmHighScores : Form
    {
        // Class level list to hold the high scores
        static List<HighScoreModel> scores = new List<HighScoreModel>();

        /// <summary>
        /// Default constructor for FrmHighScores
        /// </summary>
        public FrmHighScores()
        {
            // Initialize the form
            InitializeComponent();
            // Display the data grid view
            DisplayGridView();
        }
        /// <summary>
        /// Parameterized constructor for FrmHighScores
        /// </summary>
        public FrmHighScores(string name, int score, int difficulty, string time, DateTime date)
        {
            // Initialize the form
            InitializeComponent();

            // Get the name of the difficulty
            string stringDifficulty = GetDifficultyName(difficulty);

            // Add the new high score object to the list
            scores.Add(new HighScoreModel(name, score, stringDifficulty, time, date));

            // Keep only top 5 per difficulty
            KeepTopFivePerDifficulty();

            // Set up the data grid view
            DisplayGridView();

            // Set the average score label
            SetAverageScore();

            // Set the average time label
            SetAverageTime();
        }

        /// <summary>
        /// Display the data from the list in the grid view
        /// </summary>
        private void DisplayGridView()
        {
            // Reset the data source
            dgvHighScores.DataSource = null;
            // Get the sorted scores
            var sortedScores = scores
                .OrderBy(s => s.Difficulty)
                .ThenByDescending(s => s.Score)
                .ToList();
            // Set the data source
            dgvHighScores.DataSource = sortedScores;
            // Fill the grid view and resize the columns
            dgvHighScores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Get the name of the difficulty based on the integer
        /// </summary>
        /// <param name="difficulty"></param>
        /// <returns></returns>
        private string GetDifficultyName(int difficulty)
        {
            if (difficulty == 1)
            {
                return "Easy";
            }
            else if (difficulty == 2)
            {
                return "Medium";
            }
            else
            {
                return "Hard";
            }
        }

        /// <summary>
        /// Sort the scores and only keep the top 5 of each difficulty
        /// </summary>
        private void KeepTopFivePerDifficulty()
        {
            scores = scores
                .GroupBy(s => s.Difficulty)
                .SelectMany(group => group
                    .OrderByDescending(s => s.Score)
                    .Take(5))
                .ToList();
        }

        /// <summary>
        /// Save the high scores to a text file
        /// </summary>
        private void SaveHighScores()
        {
            // Use try-catch to catch any exceptions thrown
            try
            {
                // Create a string for the file path
                string filePath = "HighScores.txt";
                // Use streamwriter to write to a text file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Loop through each item within the list
                    foreach (var score in scores.OrderBy(s => s.Difficulty).ThenByDescending(s => s.Score))
                    {
                        // Save each item to the text file
                        writer.WriteLine($"{score.Name} , {score.Score} , {score.Difficulty} , {score.TimeElapse} , {score.Date}");
                    }
                }
                // Show a successful save
                MessageBox.Show("Save Successful");
            }
            catch (Exception ex)
            {
                // Show the error message
                MessageBox.Show("Error saving file: " + ex.Message);
            }
        }

        /// <summary>
        /// Load the high scores from a text file
        /// </summary>
        private void LoadHighScores()
        {
            // Use try-catch to catch any exceptions
            try
            {
                // Create a string for the file path
                string filePath = "HighScores.txt";
                // Make sure the file exists
                if (!File.Exists(filePath))
                {
                    // Show an error message
                    MessageBox.Show("No File Found");
                    return;
                }

                // Clear the current scores
                scores.Clear();

                // Get the lines from the file
                var lines = File.ReadAllLines(filePath);

                // Loop through the lines and separate them
                foreach (var line in lines)
                {
                    // Split the line by ,
                    string[] parts = line.Split(" , ");
                    // Get the name
                    string name = parts[0].Trim();
                    // Get the score
                    int score = int.Parse(parts[1].Trim());
                    // Get the difficulty
                    string difficulty = parts[2].Trim();
                    // Get the time
                    string time = parts[3].Trim();
                    // Get the date
                    DateTime date = DateTime.Parse(parts[4].Trim());
                    // Load the List
                    HighScoreModel loadedScore = new HighScoreModel(name, score, difficulty, time, date);
                    // Add the scores to the list
                    scores.Add(loadedScore);
                }
                // Refresh the data grid view
                DisplayGridView();
                // Show a success message
                MessageBox.Show("Load Successful");
            }
            catch (Exception ex)
            {
                // Show an error message
                MessageBox.Show($"Error: {ex}");
            }
        }

        /// <summary>
        /// Show the list in the grid view
        /// </summary>
        /// <param name="list"></param>
        private void ShowList(List<HighScoreModel> list)
        {
            dgvHighScores.DataSource = null;
            dgvHighScores.DataSource = new BindingSource { DataSource = list };
        }

        /// <summary>
        /// Save the list of high scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItemClickEH(object sender, EventArgs e)
        {
            SaveHighScores();
        }

        /// <summary>
        /// Call the load file method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItemClickEH(object sender, EventArgs e)
        {
            LoadHighScores();
        }

        /// <summary>
        /// Exit the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItemClickEH(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        /// <summary>
        /// Sort the high scores by name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortNameToolStripMenuItemClickEH(object sender, EventArgs e)
        {
            // Reset the data source
            dgvHighScores.DataSource = null;
            // Order by difficulty
            var sortedScores = scores
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.Score)
                .ToList();
            // Set the data source
            ShowList(sortedScores);
            // Fill the grid view and resize the columns
            dgvHighScores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Sort the high scores by score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortScoreToolStripMenuItemClickEH(object sender, EventArgs e)
        {
            // Reset the data source
            dgvHighScores.DataSource = null;
            // Order by score
            var sortedScores = scores
                .OrderByDescending(s => s.Score)
                .ToList();
            // Set the data source
            ShowList(sortedScores);
            // Fill the grid view and resize the columns
            dgvHighScores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Sort the high scores by difficulty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortDifficultyToolStripMenuItemClickEH(object sender, EventArgs e)
        {
            // Reset the data source
            dgvHighScores.DataSource = null;
            // Order by difficulty
            var sortedScores = scores
                .GroupBy(s => s.Difficulty)
                .SelectMany(group => group
                    .OrderByDescending(s => s.Score))
                .ToList();
            // Set the data source
            ShowList(sortedScores);
            // Fill the grid view and resize the columns
            dgvHighScores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Sort the high scores by fastest time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortTimeFinishedToolStripMenuItemClickEH(object sender, EventArgs e)
        {
            // Reset the data source
            dgvHighScores.DataSource = null;
            // Order by time elapsed
            var sortedScores = scores
                .OrderBy(s => s.TimeElapse)
                .ToList();
            // Set the data source
            ShowList(sortedScores);
            // Fill the grid view and resize the columns
            dgvHighScores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Sort the high scores by date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortDateToolStripMenuItemClickEH(object sender, EventArgs e)
        {
            // Reset the data source
            dgvHighScores.DataSource = null;
            // Order by date
            var sortedScores = scores
                .OrderByDescending(s => s.Date)
                .ToList();
            // Set the data source
            ShowList(sortedScores);
            // Fill the grid view and resize the columns
            dgvHighScores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Set the average score to the label
        /// </summary>
        private void SetAverageScore()
        {
            // Set a variable to hold to total scores
            int totalScored = 0;
            // Set a variable to hold the number of scores
            int numScored = 0;
            // Loop through the scores
            foreach (var score in scores)
            {
                // Create a single use int
                int newScore = score.Score;
                totalScored += newScore;
                numScored++;
            }

            // Set the average score label
            lblAverageScore.Text = (totalScored / numScored).ToString();
        }
        
        /// <summary>
        /// Calculate the average time and put it in the average time label
        /// </summary>
        private void SetAverageTime()
        {
            // Set a variable to hold the total time
            double totalTime = 0;
            // Set a variable to hold the average seconds
            double avgSeconds = 0;
            // Set a variable to hold the number of times added
            int numTime = 0;
            // Loop through the times
            foreach (var time in scores)
            {
                // Place the time string back into a TimeSpan
                TimeSpan elapsedTime = TimeSpan.Parse(time.TimeElapse);
                // Put the timespan into an integer based on seconds
                double newTime = elapsedTime.TotalSeconds;
                totalTime += newTime;
                numTime++;
            }
            // Calculate the average seconds
            avgSeconds = totalTime / numTime;
            // Convert the seconds back into a TimeSpan
            TimeSpan averageTime = TimeSpan.FromSeconds(avgSeconds);
            // Display the average time in the label
            lblAverageTime.Text = averageTime.ToString();
        }
    }
}
