namespace ChessBoardGUIApp
{
    partial class FrmChessBoard
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
            cmbChessPieces = new ComboBox();
            pnlChessBoard = new Panel();
            lblPieces = new Label();
            lblInstructions = new Label();
            cmbPrimaryColor = new ComboBox();
            cmbTextColors = new ComboBox();
            lblPrimaryColor = new Label();
            lblSecondaryColor = new Label();
            cmbSecondaryColor = new ComboBox();
            lblTextColor = new Label();
            btnSubmitColor = new Button();
            SuspendLayout();
            // 
            // cmbChessPieces
            // 
            cmbChessPieces.FormattingEnabled = true;
            cmbChessPieces.Items.AddRange(new object[] { "King", "Queen", "Bishop", "Knight", "Rook" });
            cmbChessPieces.Location = new Point(691, 12);
            cmbChessPieces.Name = "cmbChessPieces";
            cmbChessPieces.Size = new Size(121, 23);
            cmbChessPieces.TabIndex = 0;
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Location = new Point(12, 27);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(500, 500);
            pnlChessBoard.TabIndex = 1;
            // 
            // lblPieces
            // 
            lblPieces.AutoSize = true;
            lblPieces.Location = new Point(642, 15);
            lblPieces.Name = "lblPieces";
            lblPieces.Size = new Size(43, 15);
            lblPieces.TabIndex = 2;
            lblPieces.Text = "Pieces:";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(12, 9);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(394, 15);
            lblInstructions.TabIndex = 3;
            lblInstructions.Text = "Select a chess piece and its location on the board and see the legal moves";
            // 
            // cmbPrimaryColor
            // 
            cmbPrimaryColor.FormattingEnabled = true;
            cmbPrimaryColor.Items.AddRange(new object[] { "Gray", "White", "Pink", "Red", "Black", "Purple", "Green", "Yellow", "Orange", "Blue" });
            cmbPrimaryColor.Location = new Point(691, 41);
            cmbPrimaryColor.Name = "cmbPrimaryColor";
            cmbPrimaryColor.Size = new Size(121, 23);
            cmbPrimaryColor.TabIndex = 4;
            // 
            // cmbTextColors
            // 
            cmbTextColors.FormattingEnabled = true;
            cmbTextColors.Items.AddRange(new object[] { "Black", "White", "Pink", "Red", "Gray", "Purple", "Green", "Yellow", "Orange", "Blue" });
            cmbTextColors.Location = new Point(691, 99);
            cmbTextColors.Name = "cmbTextColors";
            cmbTextColors.Size = new Size(121, 23);
            cmbTextColors.TabIndex = 5;
            // 
            // lblPrimaryColor
            // 
            lblPrimaryColor.AutoSize = true;
            lblPrimaryColor.Location = new Point(534, 44);
            lblPrimaryColor.Name = "lblPrimaryColor";
            lblPrimaryColor.Size = new Size(151, 15);
            lblPrimaryColor.TabIndex = 6;
            lblPrimaryColor.Text = "Chess Board Primary Color:";
            // 
            // lblSecondaryColor
            // 
            lblSecondaryColor.AutoSize = true;
            lblSecondaryColor.Location = new Point(520, 73);
            lblSecondaryColor.Name = "lblSecondaryColor";
            lblSecondaryColor.Size = new Size(165, 15);
            lblSecondaryColor.TabIndex = 7;
            lblSecondaryColor.Text = "Chess Board Secondary Color:";
            // 
            // cmbSecondaryColor
            // 
            cmbSecondaryColor.FormattingEnabled = true;
            cmbSecondaryColor.Items.AddRange(new object[] { "White", "Gray", "Pink", "Red", "Black", "Purple", "Green", "Yellow", "Orange", "Blue" });
            cmbSecondaryColor.Location = new Point(691, 70);
            cmbSecondaryColor.Name = "cmbSecondaryColor";
            cmbSecondaryColor.Size = new Size(121, 23);
            cmbSecondaryColor.TabIndex = 8;
            // 
            // lblTextColor
            // 
            lblTextColor.AutoSize = true;
            lblTextColor.Location = new Point(622, 102);
            lblTextColor.Name = "lblTextColor";
            lblTextColor.Size = new Size(63, 15);
            lblTextColor.TabIndex = 9;
            lblTextColor.Text = "Text Color:";
            // 
            // btnSubmitColor
            // 
            btnSubmitColor.Location = new Point(676, 128);
            btnSubmitColor.Name = "btnSubmitColor";
            btnSubmitColor.Size = new Size(136, 23);
            btnSubmitColor.TabIndex = 10;
            btnSubmitColor.Text = "Submit Color Change";
            btnSubmitColor.UseVisualStyleBackColor = true;
            btnSubmitColor.Click += btnSubmitColorEH;
            // 
            // FrmChessBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 567);
            Controls.Add(btnSubmitColor);
            Controls.Add(lblTextColor);
            Controls.Add(cmbSecondaryColor);
            Controls.Add(lblSecondaryColor);
            Controls.Add(lblPrimaryColor);
            Controls.Add(cmbTextColors);
            Controls.Add(cmbPrimaryColor);
            Controls.Add(lblInstructions);
            Controls.Add(lblPieces);
            Controls.Add(pnlChessBoard);
            Controls.Add(cmbChessPieces);
            Name = "FrmChessBoard";
            Text = "Chess Board";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbChessPieces;
        private Panel pnlChessBoard;
        private Label lblPieces;
        private Label lblInstructions;
        private ComboBox cmbPrimaryColor;
        private ComboBox cmbTextColors;
        private Label lblPrimaryColor;
        private Label lblSecondaryColor;
        private ComboBox cmbSecondaryColor;
        private Label lblTextColor;
        private Button btnSubmitColor;
    }
}
