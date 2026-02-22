namespace MineSweeperGUI
{
    partial class FrmGetDifficulty
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
            grpDifficulty = new GroupBox();
            rdoHard = new RadioButton();
            rdoMedium = new RadioButton();
            rdoEasy = new RadioButton();
            btnStartGame = new Button();
            grpDifficulty.SuspendLayout();
            SuspendLayout();
            // 
            // grpDifficulty
            // 
            grpDifficulty.BackColor = Color.SaddleBrown;
            grpDifficulty.Controls.Add(rdoHard);
            grpDifficulty.Controls.Add(rdoMedium);
            grpDifficulty.Controls.Add(rdoEasy);
            grpDifficulty.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDifficulty.ForeColor = Color.SandyBrown;
            grpDifficulty.Location = new Point(12, 12);
            grpDifficulty.Name = "grpDifficulty";
            grpDifficulty.Size = new Size(350, 297);
            grpDifficulty.TabIndex = 0;
            grpDifficulty.TabStop = false;
            grpDifficulty.Text = "Difficulty";
            // 
            // rdoHard
            // 
            rdoHard.AutoSize = true;
            rdoHard.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoHard.Location = new Point(6, 210);
            rdoHard.Name = "rdoHard";
            rdoHard.Size = new Size(116, 44);
            rdoHard.TabIndex = 2;
            rdoHard.TabStop = true;
            rdoHard.Text = "Hard";
            rdoHard.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            rdoMedium.AutoSize = true;
            rdoMedium.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMedium.Location = new Point(6, 140);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(159, 44);
            rdoMedium.TabIndex = 1;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "Medium";
            rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoEasy
            // 
            rdoEasy.AutoSize = true;
            rdoEasy.Font = new Font("Trebuchet MS", 12F);
            rdoEasy.Location = new Point(6, 70);
            rdoEasy.Name = "rdoEasy";
            rdoEasy.Size = new Size(111, 44);
            rdoEasy.TabIndex = 0;
            rdoEasy.TabStop = true;
            rdoEasy.Text = "Easy";
            rdoEasy.UseVisualStyleBackColor = true;
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.SaddleBrown;
            btnStartGame.FlatStyle = FlatStyle.Popup;
            btnStartGame.Font = new Font("Segoe Print", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartGame.ForeColor = Color.SandyBrown;
            btnStartGame.Location = new Point(85, 315);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(200, 60);
            btnStartGame.TabIndex = 1;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += BtnStartGameClickEH;
            // 
            // FrmGetDifficulty
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(374, 384);
            Controls.Add(btnStartGame);
            Controls.Add(grpDifficulty);
            Name = "FrmGetDifficulty";
            Text = "FrmGetDifficulty";
            Load += FrmGetDifficultyLoadEH;
            grpDifficulty.ResumeLayout(false);
            grpDifficulty.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDifficulty;
        private RadioButton rdoHard;
        private RadioButton rdoMedium;
        private RadioButton rdoEasy;
        private Button btnStartGame;
    }
}