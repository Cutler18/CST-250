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
            lblTitle = new Label();
            pnlMineSweeperBoard = new Panel();
            grpAction = new GroupBox();
            rdoUseReward = new RadioButton();
            rdoRemoveFlag = new RadioButton();
            rdoFlag = new RadioButton();
            rdoReveal = new RadioButton();
            btnReset = new Button();
            grpAction.SuspendLayout();
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
            btnReset.BackgroundImage = Properties.Resources.TileNotRevealed;
            btnReset.ForeColor = Color.FromArgb(255, 128, 0);
            btnReset.Location = new Point(1032, 310);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset Game";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnResetGameClickEH;
            // 
            // FrmMineSweeper
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(1255, 1129);
            Controls.Add(btnReset);
            Controls.Add(grpAction);
            Controls.Add(pnlMineSweeperBoard);
            Controls.Add(lblTitle);
            ForeColor = Color.FromArgb(128, 64, 0);
            Name = "FrmMineSweeper";
            Text = "Minesweeper";
            grpAction.ResumeLayout(false);
            grpAction.PerformLayout();
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
    }
}
