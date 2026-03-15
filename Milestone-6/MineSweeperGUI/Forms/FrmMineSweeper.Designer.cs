namespace MineSweeperGUI
{
    partial class FrmMineSweeper
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
            lblTitle = new Label();
            pnlMineSweeperBoard = new Panel();
            grpAction = new GroupBox();
            rdoUseReward = new RadioButton();
            rdoRemoveFlag = new RadioButton();
            rdoFlag = new RadioButton();
            rdoReveal = new RadioButton();
            btnReset = new Button();
            lblGameScore = new Label();
            lblScore = new Label();
            btnStartGame = new Button();
            lblTimer = new Label();
            tmrMinesweeper = new System.Windows.Forms.Timer(components);
            btnHighScores = new Button();
            grpStyle = new GroupBox();
            rdoDefault = new RadioButton();
            rdoMexican = new RadioButton();
            rdoPatriotic = new RadioButton();
            rdoDungeon = new RadioButton();
            grpAction.SuspendLayout();
            grpStyle.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Snap ITC", 19.875F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 0, 0);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(424, 69);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Minesweeper";
            // 
            // pnlMineSweeperBoard
            // 
            pnlMineSweeperBoard.Location = new Point(12, 84);
            pnlMineSweeperBoard.Name = "pnlMineSweeperBoard";
            pnlMineSweeperBoard.Size = new Size(1000, 1000);
            pnlMineSweeperBoard.TabIndex = 1;
            // 
            // grpAction
            // 
            grpAction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpAction.BackColor = Color.SaddleBrown;
            grpAction.Controls.Add(rdoUseReward);
            grpAction.Controls.Add(rdoRemoveFlag);
            grpAction.Controls.Add(rdoFlag);
            grpAction.Controls.Add(rdoReveal);
            grpAction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpAction.ForeColor = Color.Black;
            grpAction.Location = new Point(1032, 84);
            grpAction.Name = "grpAction";
            grpAction.Size = new Size(211, 220);
            grpAction.TabIndex = 4;
            grpAction.TabStop = false;
            grpAction.Text = "Action";
            // 
            // rdoUseReward
            // 
            rdoUseReward.AutoSize = true;
            rdoUseReward.Font = new Font("Segoe UI", 9F);
            rdoUseReward.Location = new Point(11, 164);
            rdoUseReward.Name = "rdoUseReward";
            rdoUseReward.Size = new Size(168, 36);
            rdoUseReward.TabIndex = 8;
            rdoUseReward.TabStop = true;
            rdoUseReward.Text = "Use Reward";
            rdoUseReward.UseVisualStyleBackColor = true;
            // 
            // rdoRemoveFlag
            // 
            rdoRemoveFlag.AutoSize = true;
            rdoRemoveFlag.Font = new Font("Segoe UI", 9F);
            rdoRemoveFlag.Location = new Point(11, 122);
            rdoRemoveFlag.Name = "rdoRemoveFlag";
            rdoRemoveFlag.Size = new Size(182, 36);
            rdoRemoveFlag.TabIndex = 7;
            rdoRemoveFlag.TabStop = true;
            rdoRemoveFlag.Text = "Remove Flag";
            rdoRemoveFlag.UseVisualStyleBackColor = true;
            // 
            // rdoFlag
            // 
            rdoFlag.AutoSize = true;
            rdoFlag.Font = new Font("Segoe UI", 9F);
            rdoFlag.Location = new Point(11, 80);
            rdoFlag.Name = "rdoFlag";
            rdoFlag.Size = new Size(89, 36);
            rdoFlag.TabIndex = 6;
            rdoFlag.TabStop = true;
            rdoFlag.Text = "Flag";
            rdoFlag.UseVisualStyleBackColor = true;
            // 
            // rdoReveal
            // 
            rdoReveal.AutoSize = true;
            rdoReveal.Font = new Font("Segoe UI", 9F);
            rdoReveal.Location = new Point(11, 38);
            rdoReveal.Name = "rdoReveal";
            rdoReveal.Size = new Size(114, 36);
            rdoReveal.TabIndex = 5;
            rdoReveal.TabStop = true;
            rdoReveal.Text = "Reveal";
            rdoReveal.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.BackgroundImage = Properties.Resources.TileNotRevealed;
            btnReset.ForeColor = Color.FromArgb(255, 128, 0);
            btnReset.Location = new Point(1032, 562);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset Game";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Visible = false;
            btnReset.Click += BtnResetGameClickEH;
            // 
            // lblGameScore
            // 
            lblGameScore.AutoSize = true;
            lblGameScore.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameScore.ForeColor = Color.Black;
            lblGameScore.Location = new Point(736, 40);
            lblGameScore.Name = "lblGameScore";
            lblGameScore.Size = new Size(80, 32);
            lblGameScore.TabIndex = 6;
            lblGameScore.Text = "Score:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.FromArgb(128, 64, 64);
            lblScore.ForeColor = Color.NavajoWhite;
            lblScore.Location = new Point(822, 40);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(27, 32);
            lblScore.TabIndex = 7;
            lblScore.Text = "0";
            // 
            // btnStartGame
            // 
            btnStartGame.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartGame.BackgroundImage = Properties.Resources.TileNotRevealed;
            btnStartGame.ForeColor = Color.FromArgb(255, 128, 0);
            btnStartGame.Location = new Point(1093, 12);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(150, 46);
            btnStartGame.TabIndex = 8;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += BtnStartGameClickEH;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(543, 40);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(102, 32);
            lblTimer.TabIndex = 9;
            lblTimer.Text = "00:00:00";
            // 
            // tmrMinesweeper
            // 
            tmrMinesweeper.Interval = 1000;
            tmrMinesweeper.Tick += TmrMinesweeperTickEH;
            // 
            // btnHighScores
            // 
            btnHighScores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHighScores.BackgroundImage = Properties.Resources.Mine;
            btnHighScores.ForeColor = Color.FromArgb(255, 128, 0);
            btnHighScores.Location = new Point(937, 12);
            btnHighScores.Name = "btnHighScores";
            btnHighScores.Size = new Size(150, 46);
            btnHighScores.TabIndex = 10;
            btnHighScores.Text = "High Scores";
            btnHighScores.UseVisualStyleBackColor = true;
            btnHighScores.Click += BtnHighScoresClickEH;
            // 
            // grpStyle
            // 
            grpStyle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpStyle.BackColor = Color.SaddleBrown;
            grpStyle.Controls.Add(rdoDefault);
            grpStyle.Controls.Add(rdoMexican);
            grpStyle.Controls.Add(rdoPatriotic);
            grpStyle.Controls.Add(rdoDungeon);
            grpStyle.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpStyle.ForeColor = Color.Black;
            grpStyle.Location = new Point(1032, 310);
            grpStyle.Name = "grpStyle";
            grpStyle.Size = new Size(220, 246);
            grpStyle.TabIndex = 11;
            grpStyle.TabStop = false;
            grpStyle.Text = "Style";
            // 
            // rdoDefault
            // 
            rdoDefault.AutoSize = true;
            rdoDefault.Checked = true;
            rdoDefault.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoDefault.Location = new Point(9, 44);
            rdoDefault.Name = "rdoDefault";
            rdoDefault.Size = new Size(136, 39);
            rdoDefault.TabIndex = 3;
            rdoDefault.TabStop = true;
            rdoDefault.Text = "Default";
            rdoDefault.UseVisualStyleBackColor = true;
            rdoDefault.CheckedChanged += RdoStylesCheckedChangedEH;
            // 
            // rdoMexican
            // 
            rdoMexican.AutoSize = true;
            rdoMexican.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMexican.Location = new Point(9, 144);
            rdoMexican.Name = "rdoMexican";
            rdoMexican.Size = new Size(145, 39);
            rdoMexican.TabIndex = 2;
            rdoMexican.Text = "Mexican";
            rdoMexican.UseVisualStyleBackColor = true;
            rdoMexican.CheckedChanged += RdoStylesCheckedChangedEH;
            // 
            // rdoPatriotic
            // 
            rdoPatriotic.AutoSize = true;
            rdoPatriotic.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoPatriotic.Location = new Point(9, 194);
            rdoPatriotic.Name = "rdoPatriotic";
            rdoPatriotic.Size = new Size(150, 39);
            rdoPatriotic.TabIndex = 1;
            rdoPatriotic.Text = "Patriotic";
            rdoPatriotic.UseVisualStyleBackColor = true;
            rdoPatriotic.CheckedChanged += RdoStylesCheckedChangedEH;
            // 
            // rdoDungeon
            // 
            rdoDungeon.AutoSize = true;
            rdoDungeon.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoDungeon.Location = new Point(9, 94);
            rdoDungeon.Name = "rdoDungeon";
            rdoDungeon.Size = new Size(151, 39);
            rdoDungeon.TabIndex = 0;
            rdoDungeon.Text = "Dungeon";
            rdoDungeon.UseVisualStyleBackColor = true;
            rdoDungeon.CheckedChanged += RdoStylesCheckedChangedEH;
            // 
            // FrmMineSweeper
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(1255, 1129);
            Controls.Add(grpStyle);
            Controls.Add(btnHighScores);
            Controls.Add(lblTimer);
            Controls.Add(btnStartGame);
            Controls.Add(lblScore);
            Controls.Add(lblGameScore);
            Controls.Add(btnReset);
            Controls.Add(grpAction);
            Controls.Add(pnlMineSweeperBoard);
            Controls.Add(lblTitle);
            ForeColor = Color.FromArgb(128, 64, 0);
            Name = "FrmMineSweeper";
            Text = "Minesweeper";
            grpAction.ResumeLayout(false);
            grpAction.PerformLayout();
            grpStyle.ResumeLayout(false);
            grpStyle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel pnlMineSweeperBoard;
        private GroupBox grpAction;
        private RadioButton rdoUseReward;
        private RadioButton rdoRemoveFlag;
        private RadioButton rdoFlag;
        private RadioButton rdoReveal;
        private Button btnReset;
        private Label lblGameScore;
        private Label lblScore;
        private Button btnStartGame;
        private Label lblTimer;
        private System.Windows.Forms.Timer tmrMinesweeper;
        private Button btnHighScores;
        private GroupBox grpStyle;
        private RadioButton rdoDefault;
        private RadioButton rdoMexican;
        private RadioButton rdoPatriotic;
        private RadioButton rdoDungeon;
    }
}
