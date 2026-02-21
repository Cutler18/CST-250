namespace PizzaMaker
{
    partial class FrmOrderDetails
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
            lblOrderDetails = new Label();
            btnSaveOrder = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Location = new Point(90, 73);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(154, 32);
            lblOrderDetails.TabIndex = 0;
            lblOrderDetails.Text = "Order Details";
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(940, 565);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(150, 46);
            btnSaveOrder.TabIndex = 1;
            btnSaveOrder.Text = "Save Order";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += BtnSaveOrderClickEH;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(940, 621);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 46);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBackClickEH;
            // 
            // FrmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 679);
            Controls.Add(btnBack);
            Controls.Add(btnSaveOrder);
            Controls.Add(lblOrderDetails);
            Name = "FrmOrderDetails";
            Text = "Pizza Order Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderDetails;
        private Button btnSaveOrder;
        private Button btnBack;
    }
}