namespace WhackAMole
{
    partial class FrmStopWatch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTimeElapsed = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            tmrStopwatch = new System.Windows.Forms.Timer(components);
            btnTarget = new Button();
            lblScoreTitle = new Label();
            lblScore = new Label();
            lblHighScore = new Label();
            lblHighScoresTitle = new Label();
            grpSpeed = new GroupBox();
            rdoFast = new RadioButton();
            rdoMedium = new RadioButton();
            rdoSlow = new RadioButton();
            grpSpeed.SuspendLayout();
            SuspendLayout();
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.Font = new Font("Yu Gothic UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeElapsed.ForeColor = Color.Red;
            lblTimeElapsed.Location = new Point(12, 9);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(121, 37);
            lblTimeElapsed.TabIndex = 0;
            lblTimeElapsed.Text = "00:00:00";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStart.ForeColor = Color.Green;
            btnStart.Location = new Point(12, 784);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 46);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStartClickEH;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStop.ForeColor = Color.FromArgb(192, 0, 0);
            btnStop.Location = new Point(168, 784);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(150, 46);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStopClickEH;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReset.ForeColor = Color.Blue;
            btnReset.Location = new Point(324, 784);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnResetClickEH;
            // 
            // tmrStopwatch
            // 
            tmrStopwatch.Enabled = true;
            tmrStopwatch.Interval = 1000;
            tmrStopwatch.Tick += TmrStopwatchTickEH;
            // 
            // btnTarget
            // 
            btnTarget.BackColor = Color.Green;
            btnTarget.ForeColor = Color.FromArgb(255, 128, 0);
            btnTarget.Location = new Point(168, 238);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(150, 120);
            btnTarget.TabIndex = 4;
            btnTarget.Text = "X";
            btnTarget.UseVisualStyleBackColor = false;
            btnTarget.Click += BtnTargetClickEH;
            // 
            // lblScoreTitle
            // 
            lblScoreTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblScoreTitle.AutoSize = true;
            lblScoreTitle.Font = new Font("Tw Cen MT", 15F, FontStyle.Bold | FontStyle.Italic);
            lblScoreTitle.Location = new Point(745, 16);
            lblScoreTitle.Name = "lblScoreTitle";
            lblScoreTitle.Size = new Size(113, 47);
            lblScoreTitle.TabIndex = 5;
            lblScoreTitle.Text = "Score:";
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.FromArgb(0, 192, 0);
            lblScore.Location = new Point(864, 23);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(32, 37);
            lblScore.TabIndex = 6;
            lblScore.Text = "0";
            // 
            // lblHighScore
            // 
            lblHighScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHighScore.AutoSize = true;
            lblHighScore.ForeColor = SystemColors.ActiveCaption;
            lblHighScore.Location = new Point(1156, 73);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(27, 32);
            lblHighScore.TabIndex = 0;
            lblHighScore.Text = "0";
            // 
            // lblHighScoresTitle
            // 
            lblHighScoresTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHighScoresTitle.AutoSize = true;
            lblHighScoresTitle.Font = new Font("Castellar", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHighScoresTitle.Location = new Point(1075, 16);
            lblHighScoresTitle.Name = "lblHighScoresTitle";
            lblHighScoresTitle.Size = new Size(312, 44);
            lblHighScoresTitle.TabIndex = 7;
            lblHighScoresTitle.Text = "High Scores:";
            // 
            // grpSpeed
            // 
            grpSpeed.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            grpSpeed.Controls.Add(rdoFast);
            grpSpeed.Controls.Add(rdoMedium);
            grpSpeed.Controls.Add(rdoSlow);
            grpSpeed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpSpeed.Location = new Point(1234, 650);
            grpSpeed.Name = "grpSpeed";
            grpSpeed.Size = new Size(153, 180);
            grpSpeed.TabIndex = 8;
            grpSpeed.TabStop = false;
            grpSpeed.Text = "Speed";
            // 
            // rdoFast
            // 
            rdoFast.AutoSize = true;
            rdoFast.Font = new Font("Segoe UI", 9F);
            rdoFast.Location = new Point(6, 133);
            rdoFast.Name = "rdoFast";
            rdoFast.Size = new Size(86, 36);
            rdoFast.TabIndex = 2;
            rdoFast.Text = "Fast";
            rdoFast.UseVisualStyleBackColor = true;
            rdoFast.CheckedChanged += RdoButtonChangedEH;
            // 
            // rdoMedium
            // 
            rdoMedium.AutoSize = true;
            rdoMedium.Font = new Font("Segoe UI", 9F);
            rdoMedium.Location = new Point(6, 91);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(135, 36);
            rdoMedium.TabIndex = 1;
            rdoMedium.Text = "Medium";
            rdoMedium.UseVisualStyleBackColor = true;
            rdoMedium.CheckedChanged += RdoButtonChangedEH;
            // 
            // rdoSlow
            // 
            rdoSlow.AutoSize = true;
            rdoSlow.Checked = true;
            rdoSlow.Font = new Font("Segoe UI", 9F);
            rdoSlow.Location = new Point(6, 49);
            rdoSlow.Name = "rdoSlow";
            rdoSlow.Size = new Size(95, 36);
            rdoSlow.TabIndex = 0;
            rdoSlow.TabStop = true;
            rdoSlow.Text = "Slow";
            rdoSlow.UseVisualStyleBackColor = true;
            rdoSlow.CheckedChanged += RdoButtonChangedEH;
            // 
            // FrmStopWatch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1399, 842);
            Controls.Add(grpSpeed);
            Controls.Add(lblHighScoresTitle);
            Controls.Add(lblHighScore);
            Controls.Add(lblScore);
            Controls.Add(lblScoreTitle);
            Controls.Add(btnTarget);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTimeElapsed);
            Name = "FrmStopWatch";
            Text = "Stopwatch";
            Load += FrmStopwatchLoadEH;
            Click += FrmStopwatchClickEH;
            grpSpeed.ResumeLayout(false);
            grpSpeed.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimeElapsed;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private System.Windows.Forms.Timer tmrStopwatch;
        private Button btnTarget;
        private Label lblScoreTitle;
        private Label lblScore;
        private Label lblHighScore;
        private Label lblHighScoresTitle;
        private GroupBox grpSpeed;
        private RadioButton rdoFast;
        private RadioButton rdoMedium;
        private RadioButton rdoSlow;
    }
}
