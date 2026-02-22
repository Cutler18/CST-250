/*
 * Jacob Cutler
 * CST-250
 * 02/22/2026
 * Minesweeper Project
 * Milestone 4
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class FrmGetDifficulty : Form
    {
        // Property to store selected difficulty
        public int Difficulty { get; private set; }

        /// <summary>
        /// Default constructor for FrmGetDifficulty
        /// </summary>
        public FrmGetDifficulty()
        {
            // Initialize the form
            InitializeComponent();
            // Set the default difficulty to easy
            Difficulty = 1;
        }

        /// <summary>
        /// Load event handler for FrmGetDifficulty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGetDifficultyLoadEH(object sender, EventArgs e)
        {
            // Default set the easy radio button to checked
            rdoEasy.Checked = true;
        }

        /// <summary>
        /// Click event handler for the start game button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartGameClickEH(object sender, EventArgs e)
        {
            if (rdoEasy.Checked)
                Difficulty = 1;
            else if (rdoMedium.Checked)
                Difficulty = 2;
            else if (rdoHard.Checked)
                Difficulty = 3;

            DialogResult = DialogResult.OK; // close the form and return OK
            this.Close();
        }
    }
}
