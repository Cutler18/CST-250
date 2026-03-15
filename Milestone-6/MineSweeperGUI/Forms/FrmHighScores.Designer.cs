namespace MineSweeperGUI.Forms
{
    partial class FrmHighScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvHighScores = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnDropDown = new ToolStripDropDownButton();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            lblToolStrip = new ToolStripLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            byNameToolStripMenuItem = new ToolStripMenuItem();
            byScoreToolStripMenuItem = new ToolStripMenuItem();
            byDifficultyToolStripMenuItem = new ToolStripMenuItem();
            byTimeFinishedToolStripMenuItem = new ToolStripMenuItem();
            byDateToolStripMenuItem = new ToolStripMenuItem();
            lblSortToolStrip = new ToolStripLabel();
            lblAverageScoreTitle = new Label();
            lblAverageTimeTitle = new Label();
            lblAverageScore = new Label();
            lblAverageTime = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHighScores).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHighScores
            // 
            dgvHighScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHighScores.Location = new Point(12, 80);
            dgvHighScores.Name = "dgvHighScores";
            dgvHighScores.RowHeadersWidth = 82;
            dgvHighScores.Size = new Size(1355, 863);
            dgvHighScores.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDropDown, lblToolStrip, toolStripDropDownButton1, lblSortToolStrip });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1379, 38);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnDropDown
            // 
            btnDropDown.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDropDown.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            btnDropDown.ImageTransparentColor = Color.Magenta;
            btnDropDown.Name = "btnDropDown";
            btnDropDown.Size = new Size(22, 32);
            btnDropDown.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(198, 44);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItemClickEH;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(198, 44);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += LoadToolStripMenuItemClickEH;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(198, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItemClickEH;
            // 
            // lblToolStrip
            // 
            lblToolStrip.Name = "lblToolStrip";
            lblToolStrip.Size = new Size(51, 32);
            lblToolStrip.Text = "File";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { byNameToolStripMenuItem, byScoreToolStripMenuItem, byDifficultyToolStripMenuItem, byTimeFinishedToolStripMenuItem, byDateToolStripMenuItem });
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(22, 32);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // byNameToolStripMenuItem
            // 
            byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            byNameToolStripMenuItem.Size = new Size(329, 44);
            byNameToolStripMenuItem.Text = "By Name";
            byNameToolStripMenuItem.Click += SortNameToolStripMenuItemClickEH;
            // 
            // byScoreToolStripMenuItem
            // 
            byScoreToolStripMenuItem.Name = "byScoreToolStripMenuItem";
            byScoreToolStripMenuItem.Size = new Size(329, 44);
            byScoreToolStripMenuItem.Text = "By Score";
            byScoreToolStripMenuItem.Click += SortScoreToolStripMenuItemClickEH;
            // 
            // byDifficultyToolStripMenuItem
            // 
            byDifficultyToolStripMenuItem.Name = "byDifficultyToolStripMenuItem";
            byDifficultyToolStripMenuItem.Size = new Size(329, 44);
            byDifficultyToolStripMenuItem.Text = "By Difficulty";
            byDifficultyToolStripMenuItem.Click += SortDifficultyToolStripMenuItemClickEH;
            // 
            // byTimeFinishedToolStripMenuItem
            // 
            byTimeFinishedToolStripMenuItem.Name = "byTimeFinishedToolStripMenuItem";
            byTimeFinishedToolStripMenuItem.Size = new Size(329, 44);
            byTimeFinishedToolStripMenuItem.Text = "By Time Finished";
            byTimeFinishedToolStripMenuItem.Click += SortTimeFinishedToolStripMenuItemClickEH;
            // 
            // byDateToolStripMenuItem
            // 
            byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            byDateToolStripMenuItem.Size = new Size(329, 44);
            byDateToolStripMenuItem.Text = "By Date";
            byDateToolStripMenuItem.Click += SortDateToolStripMenuItemClickEH;
            // 
            // lblSortToolStrip
            // 
            lblSortToolStrip.Name = "lblSortToolStrip";
            lblSortToolStrip.Size = new Size(57, 32);
            lblSortToolStrip.Text = "Sort";
            // 
            // lblAverageScoreTitle
            // 
            lblAverageScoreTitle.AutoSize = true;
            lblAverageScoreTitle.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAverageScoreTitle.Location = new Point(12, 946);
            lblAverageScoreTitle.Name = "lblAverageScoreTitle";
            lblAverageScoreTitle.Size = new Size(280, 40);
            lblAverageScoreTitle.TabIndex = 2;
            lblAverageScoreTitle.Text = "Average Score: ";
            // 
            // lblAverageTimeTitle
            // 
            lblAverageTimeTitle.AutoSize = true;
            lblAverageTimeTitle.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAverageTimeTitle.Location = new Point(681, 946);
            lblAverageTimeTitle.Name = "lblAverageTimeTitle";
            lblAverageTimeTitle.Size = new Size(258, 40);
            lblAverageTimeTitle.TabIndex = 3;
            lblAverageTimeTitle.Text = "Average Time: ";
            // 
            // lblAverageScore
            // 
            lblAverageScore.AutoSize = true;
            lblAverageScore.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageScore.Location = new Point(298, 946);
            lblAverageScore.Name = "lblAverageScore";
            lblAverageScore.Size = new Size(32, 37);
            lblAverageScore.TabIndex = 4;
            lblAverageScore.Text = "0";
            // 
            // lblAverageTime
            // 
            lblAverageTime.AutoSize = true;
            lblAverageTime.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageTime.Location = new Point(945, 946);
            lblAverageTime.Name = "lblAverageTime";
            lblAverageTime.Size = new Size(32, 37);
            lblAverageTime.TabIndex = 5;
            lblAverageTime.Text = "0";
            // 
            // FrmHighScores
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 1026);
            Controls.Add(lblAverageTime);
            Controls.Add(lblAverageScore);
            Controls.Add(lblAverageTimeTitle);
            Controls.Add(lblAverageScoreTitle);
            Controls.Add(toolStrip1);
            Controls.Add(dgvHighScores);
            Name = "FrmHighScores";
            Text = "FrmHighScores";
            ((System.ComponentModel.ISupportInitialize)dgvHighScores).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHighScores;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton btnDropDown;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripLabel lblToolStrip;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem byNameToolStripMenuItem;
        private ToolStripMenuItem byScoreToolStripMenuItem;
        private ToolStripMenuItem byDifficultyToolStripMenuItem;
        private ToolStripMenuItem byTimeFinishedToolStripMenuItem;
        private ToolStripMenuItem byDateToolStripMenuItem;
        private ToolStripLabel lblSortToolStrip;
        private Label lblAverageScoreTitle;
        private Label lblAverageTimeTitle;
        private Label lblAverageScore;
        private Label lblAverageTime;
    }
}