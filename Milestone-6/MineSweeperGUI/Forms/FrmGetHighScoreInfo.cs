/*
 * Jacob Cutler
 * CST-250
 * 03/15/2026
 * Minesweeper Project
 * Milestone 6
 */

using MineSweeperGUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class FrmGetHighScoreInfo : Form
    {
        // Private class level variables
        private int _score;
        private int _difficulty;
        private string _time;
        private string _name;
        private DateTime _date;

        public FrmGetHighScoreInfo(int score, int difficulty, string time, DateTime date)
        {
            InitializeComponent();

            // Set the score label
            lblScore.Text = score.ToString();

            // Initialize the private variable
            _score = score;
            _difficulty = difficulty;
            _time = time;
            _date = date;
        }

        /// <summary>
        /// Click event handler for the submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmitClickEH(object sender, EventArgs e)
        {
            // Set the name
            _name = txtHighScoreName.Text;
            // Call the high score form
            FrmHighScores dlg = new FrmHighScores(_name, _score, _difficulty, _time, _date);
            dlg.ShowDialog();

            // Close the current form
            this.Close();
        }
    }
}
