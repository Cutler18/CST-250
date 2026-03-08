namespace FileIOAndLINQ.PresentationLayer
{
    partial class FrmVerseList
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
            mnsFileActions = new MenuStrip();
            tsmFile = new ToolStripMenuItem();
            tsmSave = new ToolStripMenuItem();
            tsmLoad = new ToolStripMenuItem();
            tsmExit = new ToolStripMenuItem();
            grpAddVerse = new GroupBox();
            lblVerseImportanceError = new Label();
            lblVerseMeaningError = new Label();
            lblVerseTextError = new Label();
            lblVerseVerseError = new Label();
            lblVerseChapterError = new Label();
            lblVerseBookError = new Label();
            btnAddVerse = new Button();
            nudVerseImportance = new NumericUpDown();
            txtVerseMeaning = new TextBox();
            txtVerseText = new TextBox();
            lblVerseImportance = new Label();
            lblVerseMeaning = new Label();
            lblVerseText = new Label();
            txtVerseVerse = new TextBox();
            txtVerseChapter = new TextBox();
            cmbVerseBook = new ComboBox();
            lblVerseVerse = new Label();
            lblVerseChapter = new Label();
            lblVerseBook = new Label();
            grpFilterAndSort = new GroupBox();
            rdoShowMostImportant = new RadioButton();
            rdoShowLeastImportant = new RadioButton();
            rdoShowAll = new RadioButton();
            trbNumberToShow = new TrackBar();
            dgvVerseDisplay = new DataGridView();
            mnsFileActions.SuspendLayout();
            grpAddVerse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudVerseImportance).BeginInit();
            grpFilterAndSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbNumberToShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVerseDisplay).BeginInit();
            SuspendLayout();
            // 
            // mnsFileActions
            // 
            mnsFileActions.ImageScalingSize = new Size(32, 32);
            mnsFileActions.Items.AddRange(new ToolStripItem[] { tsmFile });
            mnsFileActions.Location = new Point(0, 0);
            mnsFileActions.Name = "mnsFileActions";
            mnsFileActions.Size = new Size(1958, 40);
            mnsFileActions.TabIndex = 0;
            mnsFileActions.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            tsmFile.DropDownItems.AddRange(new ToolStripItem[] { tsmSave, tsmLoad, tsmExit });
            tsmFile.Name = "tsmFile";
            tsmFile.Size = new Size(71, 36);
            tsmFile.Text = "File";
            // 
            // tsmSave
            // 
            tsmSave.Name = "tsmSave";
            tsmSave.Size = new Size(198, 44);
            tsmSave.Text = "Save";
            tsmSave.Click += TsmSaveClickEH;
            // 
            // tsmLoad
            // 
            tsmLoad.Name = "tsmLoad";
            tsmLoad.Size = new Size(198, 44);
            tsmLoad.Text = "Load";
            tsmLoad.Click += TsmLoadClickEH;
            // 
            // tsmExit
            // 
            tsmExit.Name = "tsmExit";
            tsmExit.Size = new Size(198, 44);
            tsmExit.Text = "Exit";
            // 
            // grpAddVerse
            // 
            grpAddVerse.Controls.Add(lblVerseImportanceError);
            grpAddVerse.Controls.Add(lblVerseMeaningError);
            grpAddVerse.Controls.Add(lblVerseTextError);
            grpAddVerse.Controls.Add(lblVerseVerseError);
            grpAddVerse.Controls.Add(lblVerseChapterError);
            grpAddVerse.Controls.Add(lblVerseBookError);
            grpAddVerse.Controls.Add(btnAddVerse);
            grpAddVerse.Controls.Add(nudVerseImportance);
            grpAddVerse.Controls.Add(txtVerseMeaning);
            grpAddVerse.Controls.Add(txtVerseText);
            grpAddVerse.Controls.Add(lblVerseImportance);
            grpAddVerse.Controls.Add(lblVerseMeaning);
            grpAddVerse.Controls.Add(lblVerseText);
            grpAddVerse.Controls.Add(txtVerseVerse);
            grpAddVerse.Controls.Add(txtVerseChapter);
            grpAddVerse.Controls.Add(cmbVerseBook);
            grpAddVerse.Controls.Add(lblVerseVerse);
            grpAddVerse.Controls.Add(lblVerseChapter);
            grpAddVerse.Controls.Add(lblVerseBook);
            grpAddVerse.Location = new Point(12, 43);
            grpAddVerse.Name = "grpAddVerse";
            grpAddVerse.Size = new Size(488, 842);
            grpAddVerse.TabIndex = 1;
            grpAddVerse.TabStop = false;
            grpAddVerse.Text = "Add A Bible Verse";
            // 
            // lblVerseImportanceError
            // 
            lblVerseImportanceError.AutoSize = true;
            lblVerseImportanceError.ForeColor = Color.Red;
            lblVerseImportanceError.Location = new Point(153, 727);
            lblVerseImportanceError.Name = "lblVerseImportanceError";
            lblVerseImportanceError.Size = new Size(192, 32);
            lblVerseImportanceError.TabIndex = 11;
            lblVerseImportanceError.Text = "Importance Error";
            // 
            // lblVerseMeaningError
            // 
            lblVerseMeaningError.AutoSize = true;
            lblVerseMeaningError.ForeColor = Color.Red;
            lblVerseMeaningError.Location = new Point(153, 637);
            lblVerseMeaningError.Name = "lblVerseMeaningError";
            lblVerseMeaningError.Size = new Size(166, 32);
            lblVerseMeaningError.TabIndex = 10;
            lblVerseMeaningError.Text = "Meaning Error";
            // 
            // lblVerseTextError
            // 
            lblVerseTextError.AutoSize = true;
            lblVerseTextError.ForeColor = Color.Red;
            lblVerseTextError.Location = new Point(153, 460);
            lblVerseTextError.Name = "lblVerseTextError";
            lblVerseTextError.Size = new Size(114, 32);
            lblVerseTextError.TabIndex = 9;
            lblVerseTextError.Text = "Text Error";
            // 
            // lblVerseVerseError
            // 
            lblVerseVerseError.AutoSize = true;
            lblVerseVerseError.ForeColor = Color.Red;
            lblVerseVerseError.Location = new Point(153, 260);
            lblVerseVerseError.Name = "lblVerseVerseError";
            lblVerseVerseError.Size = new Size(128, 32);
            lblVerseVerseError.TabIndex = 8;
            lblVerseVerseError.Text = "Verse Error";
            // 
            // lblVerseChapterError
            // 
            lblVerseChapterError.AutoSize = true;
            lblVerseChapterError.ForeColor = Color.Red;
            lblVerseChapterError.Location = new Point(153, 170);
            lblVerseChapterError.Name = "lblVerseChapterError";
            lblVerseChapterError.Size = new Size(155, 32);
            lblVerseChapterError.TabIndex = 7;
            lblVerseChapterError.Text = "Chapter Error";
            // 
            // lblVerseBookError
            // 
            lblVerseBookError.AutoSize = true;
            lblVerseBookError.ForeColor = Color.Red;
            lblVerseBookError.Location = new Point(153, 81);
            lblVerseBookError.Name = "lblVerseBookError";
            lblVerseBookError.Size = new Size(125, 32);
            lblVerseBookError.TabIndex = 6;
            lblVerseBookError.Text = "Book Error";
            // 
            // btnAddVerse
            // 
            btnAddVerse.Location = new Point(169, 775);
            btnAddVerse.Name = "btnAddVerse";
            btnAddVerse.Size = new Size(150, 46);
            btnAddVerse.TabIndex = 2;
            btnAddVerse.Text = "Add Verse";
            btnAddVerse.UseVisualStyleBackColor = true;
            btnAddVerse.Click += BtnAddVerseClickEH;
            // 
            // nudVerseImportance
            // 
            nudVerseImportance.Location = new Point(153, 685);
            nudVerseImportance.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudVerseImportance.Name = "nudVerseImportance";
            nudVerseImportance.Size = new Size(316, 39);
            nudVerseImportance.TabIndex = 2;
            nudVerseImportance.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudVerseImportance.Leave += NudVerseImportanceLeaveEH;
            // 
            // txtVerseMeaning
            // 
            txtVerseMeaning.Location = new Point(153, 508);
            txtVerseMeaning.Multiline = true;
            txtVerseMeaning.Name = "txtVerseMeaning";
            txtVerseMeaning.Size = new Size(316, 126);
            txtVerseMeaning.TabIndex = 5;
            txtVerseMeaning.Leave += TxtVerseMeaningLeaveEH;
            // 
            // txtVerseText
            // 
            txtVerseText.Location = new Point(153, 308);
            txtVerseText.Multiline = true;
            txtVerseText.Name = "txtVerseText";
            txtVerseText.Size = new Size(316, 149);
            txtVerseText.TabIndex = 2;
            txtVerseText.Leave += TxtVerseTextLeaveEH;
            // 
            // lblVerseImportance
            // 
            lblVerseImportance.AutoSize = true;
            lblVerseImportance.Location = new Point(7, 687);
            lblVerseImportance.Name = "lblVerseImportance";
            lblVerseImportance.Size = new Size(140, 32);
            lblVerseImportance.TabIndex = 2;
            lblVerseImportance.Text = "Importance:";
            // 
            // lblVerseMeaning
            // 
            lblVerseMeaning.AutoSize = true;
            lblVerseMeaning.Location = new Point(33, 508);
            lblVerseMeaning.Name = "lblVerseMeaning";
            lblVerseMeaning.Size = new Size(114, 32);
            lblVerseMeaning.TabIndex = 2;
            lblVerseMeaning.Text = "Meaning:";
            // 
            // lblVerseText
            // 
            lblVerseText.AutoSize = true;
            lblVerseText.Location = new Point(85, 308);
            lblVerseText.Name = "lblVerseText";
            lblVerseText.Size = new Size(62, 32);
            lblVerseText.TabIndex = 2;
            lblVerseText.Text = "Text:";
            // 
            // txtVerseVerse
            // 
            txtVerseVerse.Location = new Point(153, 218);
            txtVerseVerse.Name = "txtVerseVerse";
            txtVerseVerse.Size = new Size(316, 39);
            txtVerseVerse.TabIndex = 4;
            txtVerseVerse.Leave += TxtVerseVerseLeaveEH;
            // 
            // txtVerseChapter
            // 
            txtVerseChapter.Location = new Point(153, 128);
            txtVerseChapter.Name = "txtVerseChapter";
            txtVerseChapter.Size = new Size(316, 39);
            txtVerseChapter.TabIndex = 3;
            txtVerseChapter.Leave += TxtVerseChapterLeaveEH;
            // 
            // cmbVerseBook
            // 
            cmbVerseBook.FormattingEnabled = true;
            cmbVerseBook.Location = new Point(153, 38);
            cmbVerseBook.Name = "cmbVerseBook";
            cmbVerseBook.Size = new Size(316, 40);
            cmbVerseBook.TabIndex = 3;
            cmbVerseBook.Leave += CmbVerseBookLeaveEH;
            // 
            // lblVerseVerse
            // 
            lblVerseVerse.AutoSize = true;
            lblVerseVerse.Location = new Point(76, 221);
            lblVerseVerse.Name = "lblVerseVerse";
            lblVerseVerse.Size = new Size(71, 32);
            lblVerseVerse.TabIndex = 2;
            lblVerseVerse.Text = "Verse";
            // 
            // lblVerseChapter
            // 
            lblVerseChapter.AutoSize = true;
            lblVerseChapter.Location = new Point(44, 131);
            lblVerseChapter.Name = "lblVerseChapter";
            lblVerseChapter.Size = new Size(103, 32);
            lblVerseChapter.TabIndex = 2;
            lblVerseChapter.Text = "Chapter:";
            // 
            // lblVerseBook
            // 
            lblVerseBook.AutoSize = true;
            lblVerseBook.Location = new Point(74, 41);
            lblVerseBook.Name = "lblVerseBook";
            lblVerseBook.Size = new Size(73, 32);
            lblVerseBook.TabIndex = 2;
            lblVerseBook.Text = "Book:";
            // 
            // grpFilterAndSort
            // 
            grpFilterAndSort.Controls.Add(rdoShowMostImportant);
            grpFilterAndSort.Controls.Add(rdoShowLeastImportant);
            grpFilterAndSort.Controls.Add(rdoShowAll);
            grpFilterAndSort.Location = new Point(12, 891);
            grpFilterAndSort.Name = "grpFilterAndSort";
            grpFilterAndSort.Size = new Size(488, 206);
            grpFilterAndSort.TabIndex = 2;
            grpFilterAndSort.TabStop = false;
            grpFilterAndSort.Text = "Filter and Sort";
            // 
            // rdoShowMostImportant
            // 
            rdoShowMostImportant.AutoSize = true;
            rdoShowMostImportant.Location = new Point(7, 150);
            rdoShowMostImportant.Name = "rdoShowMostImportant";
            rdoShowMostImportant.Size = new Size(276, 36);
            rdoShowMostImportant.TabIndex = 5;
            rdoShowMostImportant.TabStop = true;
            rdoShowMostImportant.Text = "Show Most Important";
            rdoShowMostImportant.UseVisualStyleBackColor = true;
            rdoShowMostImportant.CheckedChanged += RdoShowMostImportantCheckedChangedEH;
            // 
            // rdoShowLeastImportant
            // 
            rdoShowLeastImportant.AutoSize = true;
            rdoShowLeastImportant.Location = new Point(6, 100);
            rdoShowLeastImportant.Name = "rdoShowLeastImportant";
            rdoShowLeastImportant.Size = new Size(276, 36);
            rdoShowLeastImportant.TabIndex = 4;
            rdoShowLeastImportant.TabStop = true;
            rdoShowLeastImportant.Text = "Show Least Important";
            rdoShowLeastImportant.UseVisualStyleBackColor = true;
            rdoShowLeastImportant.CheckedChanged += RdoShowLeastImportantCheckChangedEH;
            // 
            // rdoShowAll
            // 
            rdoShowAll.AutoSize = true;
            rdoShowAll.Location = new Point(7, 50);
            rdoShowAll.Name = "rdoShowAll";
            rdoShowAll.Size = new Size(137, 36);
            rdoShowAll.TabIndex = 3;
            rdoShowAll.TabStop = true;
            rdoShowAll.Text = "Show All";
            rdoShowAll.UseVisualStyleBackColor = true;
            rdoShowAll.CheckedChanged += RdoShowAllCheckedChangedEH;
            // 
            // trbNumberToShow
            // 
            trbNumberToShow.Location = new Point(12, 1103);
            trbNumberToShow.Name = "trbNumberToShow";
            trbNumberToShow.Size = new Size(488, 90);
            trbNumberToShow.TabIndex = 3;
            trbNumberToShow.Scroll += TrbNumberToShowScrollEH;
            // 
            // dgvVerseDisplay
            // 
            dgvVerseDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerseDisplay.Location = new Point(506, 43);
            dgvVerseDisplay.Name = "dgvVerseDisplay";
            dgvVerseDisplay.RowHeadersWidth = 82;
            dgvVerseDisplay.Size = new Size(1440, 1054);
            dgvVerseDisplay.TabIndex = 4;
            // 
            // FrmVerseList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1958, 1171);
            Controls.Add(dgvVerseDisplay);
            Controls.Add(trbNumberToShow);
            Controls.Add(grpFilterAndSort);
            Controls.Add(grpAddVerse);
            Controls.Add(mnsFileActions);
            MainMenuStrip = mnsFileActions;
            Name = "FrmVerseList";
            Text = "Bible Verses";
            Load += FrmVerseListLoadEH;
            mnsFileActions.ResumeLayout(false);
            mnsFileActions.PerformLayout();
            grpAddVerse.ResumeLayout(false);
            grpAddVerse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudVerseImportance).EndInit();
            grpFilterAndSort.ResumeLayout(false);
            grpFilterAndSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbNumberToShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVerseDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsFileActions;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsmSave;
        private ToolStripMenuItem tsmLoad;
        private ToolStripMenuItem tsmExit;
        private GroupBox grpAddVerse;
        private Label lblVerseVerse;
        private Label lblVerseChapter;
        private Label lblVerseBook;
        private Label lblVerseText;
        private Label lblVerseImportance;
        private Label lblVerseMeaning;
        private TextBox txtVerseVerse;
        private TextBox txtVerseChapter;
        private ComboBox cmbVerseBook;
        private TextBox txtVerseMeaning;
        private TextBox txtVerseText;
        private NumericUpDown nudVerseImportance;
        private Button btnAddVerse;
        private Label lblVerseImportanceError;
        private Label lblVerseMeaningError;
        private Label lblVerseTextError;
        private Label lblVerseVerseError;
        private Label lblVerseChapterError;
        private Label lblVerseBookError;
        private GroupBox grpFilterAndSort;
        private RadioButton rdoShowMostImportant;
        private RadioButton rdoShowLeastImportant;
        private RadioButton rdoShowAll;
        private TrackBar trbNumberToShow;
        private DataGridView dgvVerseDisplay;
    }
}