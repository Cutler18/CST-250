namespace MineSweeperGUI
{
    partial class FrmGetHighScoreInfo
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
            txtHighScoreName = new TextBox();
            lblGetName = new Label();
            btnSubmitName = new Button();
            lblHighScore = new Label();
            lblScore = new Label();
            SuspendLayout();
            // 
            // txtHighScoreName
            // 
            txtHighScoreName.BackColor = Color.FromArgb(224, 224, 224);
            txtHighScoreName.Location = new Point(60, 141);
            txtHighScoreName.Name = "txtHighScoreName";
            txtHighScoreName.Size = new Size(384, 39);
            txtHighScoreName.TabIndex = 0;
            // 
            // lblGetName
            // 
            lblGetName.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGetName.ForeColor = Color.Black;
            lblGetName.Location = new Point(51, 42);
            lblGetName.Name = "lblGetName";
            lblGetName.Size = new Size(413, 96);
            lblGetName.TabIndex = 1;
            lblGetName.Text = "Congrats You WIN! Please enter you name:";
            // 
            // btnSubmitName
            // 
            btnSubmitName.Location = new Point(187, 220);
            btnSubmitName.Name = "btnSubmitName";
            btnSubmitName.Size = new Size(150, 46);
            btnSubmitName.TabIndex = 2;
            btnSubmitName.Text = "Submit";
            btnSubmitName.UseVisualStyleBackColor = true;
            btnSubmitName.Click += BtnSubmitClickEH;
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.Font = new Font("Lucida Calligraphy", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHighScore.ForeColor = Color.Black;
            lblHighScore.Location = new Point(12, 183);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(99, 36);
            lblHighScore.TabIndex = 3;
            lblHighScore.Text = "Score:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.ForeColor = Color.Black;
            lblScore.Location = new Point(117, 187);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(27, 32);
            lblScore.TabIndex = 4;
            lblScore.Text = "0";
            // 
            // FrmGetHighScoreInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(508, 293);
            Controls.Add(lblScore);
            Controls.Add(lblHighScore);
            Controls.Add(btnSubmitName);
            Controls.Add(lblGetName);
            Controls.Add(txtHighScoreName);
            Name = "FrmGetHighScoreInfo";
            Text = "FrmGetHighScoreInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHighScoreName;
        private Label lblGetName;
        private Button btnSubmitName;
        private Label lblHighScore;
        private Label lblScore;
    }
}