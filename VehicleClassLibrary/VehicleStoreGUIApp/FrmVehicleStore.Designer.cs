namespace VehicleStoreGUIApp
{
    partial class FrmVehicleStore
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
            createVehicleGroupBox = new GroupBox();
            lblTypeError = new Label();
            lblModelError = new Label();
            lblYearError = new Label();
            lblPriceError = new Label();
            lblNumWheelsError = new Label();
            lblMilesPerGallonError = new Label();
            lblNumOwnersError = new Label();
            lblMakeError = new Label();
            btnCreate = new Button();
            txtNumOwners = new TextBox();
            lblNumOwners = new Label();
            txtMilesPerGallon = new TextBox();
            lblNumWheels = new Label();
            txtNumWheels = new TextBox();
            lblMilesPerGallon = new Label();
            txtPrice = new TextBox();
            rdoVehicle = new RadioButton();
            txtYear = new TextBox();
            lblPrice = new Label();
            txtModel = new TextBox();
            rdoCar = new RadioButton();
            txtMake = new TextBox();
            lblYear = new Label();
            rdoPickup = new RadioButton();
            lblModel = new Label();
            rdoMotorcycle = new RadioButton();
            lblMake = new Label();
            specialtyGroupBox = new GroupBox();
            lblDecimalError = new Label();
            lblBoolError = new Label();
            txtSpecial = new TextBox();
            lblDecimal = new Label();
            lblBoolean = new Label();
            rdoFalse = new RadioButton();
            rdoTrue = new RadioButton();
            inventoryGroupBox = new GroupBox();
            lstInventory = new ListBox();
            btnAddToCart = new Button();
            cartGroupBox = new GroupBox();
            lstShoppingCart = new ListBox();
            btnCheckout = new Button();
            lblTotal = new Label();
            lblTotalCost = new Label();
            createVehicleGroupBox.SuspendLayout();
            specialtyGroupBox.SuspendLayout();
            inventoryGroupBox.SuspendLayout();
            cartGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // createVehicleGroupBox
            // 
            createVehicleGroupBox.Controls.Add(lblTypeError);
            createVehicleGroupBox.Controls.Add(lblModelError);
            createVehicleGroupBox.Controls.Add(lblYearError);
            createVehicleGroupBox.Controls.Add(lblPriceError);
            createVehicleGroupBox.Controls.Add(lblNumWheelsError);
            createVehicleGroupBox.Controls.Add(lblMilesPerGallonError);
            createVehicleGroupBox.Controls.Add(lblNumOwnersError);
            createVehicleGroupBox.Controls.Add(lblMakeError);
            createVehicleGroupBox.Controls.Add(btnCreate);
            createVehicleGroupBox.Controls.Add(txtNumOwners);
            createVehicleGroupBox.Controls.Add(lblNumOwners);
            createVehicleGroupBox.Controls.Add(txtMilesPerGallon);
            createVehicleGroupBox.Controls.Add(lblNumWheels);
            createVehicleGroupBox.Controls.Add(txtNumWheels);
            createVehicleGroupBox.Controls.Add(lblMilesPerGallon);
            createVehicleGroupBox.Controls.Add(txtPrice);
            createVehicleGroupBox.Controls.Add(rdoVehicle);
            createVehicleGroupBox.Controls.Add(txtYear);
            createVehicleGroupBox.Controls.Add(lblPrice);
            createVehicleGroupBox.Controls.Add(txtModel);
            createVehicleGroupBox.Controls.Add(rdoCar);
            createVehicleGroupBox.Controls.Add(txtMake);
            createVehicleGroupBox.Controls.Add(lblYear);
            createVehicleGroupBox.Controls.Add(rdoPickup);
            createVehicleGroupBox.Controls.Add(lblModel);
            createVehicleGroupBox.Controls.Add(rdoMotorcycle);
            createVehicleGroupBox.Controls.Add(lblMake);
            createVehicleGroupBox.Location = new Point(12, 12);
            createVehicleGroupBox.Name = "createVehicleGroupBox";
            createVehicleGroupBox.Size = new Size(227, 422);
            createVehicleGroupBox.TabIndex = 0;
            createVehicleGroupBox.TabStop = false;
            createVehicleGroupBox.Text = "Create a Vehicle";
            // 
            // lblTypeError
            // 
            lblTypeError.AutoSize = true;
            lblTypeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTypeError.ForeColor = Color.Red;
            lblTypeError.Location = new Point(64, 19);
            lblTypeError.Name = "lblTypeError";
            lblTypeError.Size = new Size(80, 15);
            lblTypeError.TabIndex = 8;
            lblTypeError.Text = "Select a Type";
            lblTypeError.Visible = false;
            // 
            // lblModelError
            // 
            lblModelError.AutoSize = true;
            lblModelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelError.ForeColor = Color.Red;
            lblModelError.Location = new Point(64, 127);
            lblModelError.Name = "lblModelError";
            lblModelError.Size = new Size(113, 15);
            lblModelError.TabIndex = 8;
            lblModelError.Text = "Enter a Valid Model";
            lblModelError.Visible = false;
            // 
            // lblYearError
            // 
            lblYearError.AutoSize = true;
            lblYearError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearError.ForeColor = Color.Red;
            lblYearError.Location = new Point(64, 171);
            lblYearError.Name = "lblYearError";
            lblYearError.Size = new Size(102, 15);
            lblYearError.TabIndex = 8;
            lblYearError.Text = "Enter a Valid Year";
            lblYearError.Visible = false;
            // 
            // lblPriceError
            // 
            lblPriceError.AutoSize = true;
            lblPriceError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceError.ForeColor = Color.Red;
            lblPriceError.Location = new Point(64, 215);
            lblPriceError.Name = "lblPriceError";
            lblPriceError.Size = new Size(106, 15);
            lblPriceError.TabIndex = 8;
            lblPriceError.Text = "Enter a Valid Price";
            lblPriceError.Visible = false;
            // 
            // lblNumWheelsError
            // 
            lblNumWheelsError.AutoSize = true;
            lblNumWheelsError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumWheelsError.ForeColor = Color.Red;
            lblNumWheelsError.Location = new Point(64, 259);
            lblNumWheelsError.Name = "lblNumWheelsError";
            lblNumWheelsError.Size = new Size(150, 15);
            lblNumWheelsError.TabIndex = 8;
            lblNumWheelsError.Text = "Enter a Valid Wheel Count";
            lblNumWheelsError.Visible = false;
            // 
            // lblMilesPerGallonError
            // 
            lblMilesPerGallonError.AutoSize = true;
            lblMilesPerGallonError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMilesPerGallonError.ForeColor = Color.Red;
            lblMilesPerGallonError.Location = new Point(64, 303);
            lblMilesPerGallonError.Name = "lblMilesPerGallonError";
            lblMilesPerGallonError.Size = new Size(105, 15);
            lblMilesPerGallonError.TabIndex = 8;
            lblMilesPerGallonError.Text = "Enter a Valid MPG";
            lblMilesPerGallonError.Visible = false;
            // 
            // lblNumOwnersError
            // 
            lblNumOwnersError.AutoSize = true;
            lblNumOwnersError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumOwnersError.ForeColor = Color.Red;
            lblNumOwnersError.Location = new Point(64, 347);
            lblNumOwnersError.Name = "lblNumOwnersError";
            lblNumOwnersError.Size = new Size(152, 15);
            lblNumOwnersError.TabIndex = 8;
            lblNumOwnersError.Text = "Enter a Valid Owner Count";
            lblNumOwnersError.Visible = false;
            // 
            // lblMakeError
            // 
            lblMakeError.AutoSize = true;
            lblMakeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeError.ForeColor = Color.Red;
            lblMakeError.Location = new Point(64, 83);
            lblMakeError.Name = "lblMakeError";
            lblMakeError.Size = new Size(109, 15);
            lblMakeError.TabIndex = 8;
            lblMakeError.Text = "Enter a Valid Make";
            lblMakeError.Visible = false;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(64, 394);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += BtnCreateClickEH;
            // 
            // txtNumOwners
            // 
            txtNumOwners.Location = new Point(64, 365);
            txtNumOwners.Name = "txtNumOwners";
            txtNumOwners.Size = new Size(137, 23);
            txtNumOwners.TabIndex = 7;
            txtNumOwners.Leave += TxtOwnersLeaveEH;
            // 
            // lblNumOwners
            // 
            lblNumOwners.AutoSize = true;
            lblNumOwners.Location = new Point(8, 368);
            lblNumOwners.Name = "lblNumOwners";
            lblNumOwners.Size = new Size(50, 15);
            lblNumOwners.TabIndex = 2;
            lblNumOwners.Text = "Owners:";
            // 
            // txtMilesPerGallon
            // 
            txtMilesPerGallon.Location = new Point(64, 321);
            txtMilesPerGallon.Name = "txtMilesPerGallon";
            txtMilesPerGallon.Size = new Size(137, 23);
            txtMilesPerGallon.TabIndex = 6;
            txtMilesPerGallon.Leave += TxtMPGLeaveEH;
            // 
            // lblNumWheels
            // 
            lblNumWheels.AutoSize = true;
            lblNumWheels.Location = new Point(10, 280);
            lblNumWheels.Name = "lblNumWheels";
            lblNumWheels.Size = new Size(48, 15);
            lblNumWheels.TabIndex = 5;
            lblNumWheels.Text = "Wheels:";
            // 
            // txtNumWheels
            // 
            txtNumWheels.Location = new Point(64, 277);
            txtNumWheels.Name = "txtNumWheels";
            txtNumWheels.Size = new Size(137, 23);
            txtNumWheels.TabIndex = 5;
            txtNumWheels.Leave += TxtWheelsLeaveEH;
            // 
            // lblMilesPerGallon
            // 
            lblMilesPerGallon.AutoSize = true;
            lblMilesPerGallon.Location = new Point(22, 324);
            lblMilesPerGallon.Name = "lblMilesPerGallon";
            lblMilesPerGallon.Size = new Size(36, 15);
            lblMilesPerGallon.TabIndex = 1;
            lblMilesPerGallon.Text = "MPG:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(64, 233);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(137, 23);
            txtPrice.TabIndex = 4;
            txtPrice.Leave += TxtPriceLeaveEH;
            // 
            // rdoVehicle
            // 
            rdoVehicle.AutoSize = true;
            rdoVehicle.Location = new Point(106, 62);
            rdoVehicle.Name = "rdoVehicle";
            rdoVehicle.Size = new Size(95, 19);
            rdoVehicle.TabIndex = 4;
            rdoVehicle.TabStop = true;
            rdoVehicle.Text = "Other Vehicle";
            rdoVehicle.UseVisualStyleBackColor = true;
            rdoVehicle.Click += RdoVehicleClickEH;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(64, 189);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(137, 23);
            txtYear.TabIndex = 3;
            txtYear.Leave += TxtYearLeaveEH;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(22, 236);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(64, 145);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(137, 23);
            txtModel.TabIndex = 2;
            txtModel.Leave += TxtModelLeaveEH;
            // 
            // rdoCar
            // 
            rdoCar.AutoSize = true;
            rdoCar.Location = new Point(19, 37);
            rdoCar.Name = "rdoCar";
            rdoCar.Size = new Size(43, 19);
            rdoCar.TabIndex = 1;
            rdoCar.TabStop = true;
            rdoCar.Text = "Car";
            rdoCar.UseVisualStyleBackColor = true;
            rdoCar.Click += RdoCarClickEH;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(64, 101);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(137, 23);
            txtMake.TabIndex = 1;
            txtMake.Leave += TxtMakeLeaveEH;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(26, 192);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(32, 15);
            lblYear.TabIndex = 3;
            lblYear.Text = "Year:";
            // 
            // rdoPickup
            // 
            rdoPickup.AutoSize = true;
            rdoPickup.Location = new Point(19, 62);
            rdoPickup.Name = "rdoPickup";
            rdoPickup.Size = new Size(61, 19);
            rdoPickup.TabIndex = 3;
            rdoPickup.TabStop = true;
            rdoPickup.Text = "Pickup";
            rdoPickup.UseVisualStyleBackColor = true;
            rdoPickup.Click += RdoPickupClickEH;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(14, 148);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(44, 15);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model:";
            // 
            // rdoMotorcycle
            // 
            rdoMotorcycle.AutoSize = true;
            rdoMotorcycle.Location = new Point(106, 37);
            rdoMotorcycle.Name = "rdoMotorcycle";
            rdoMotorcycle.Size = new Size(85, 19);
            rdoMotorcycle.TabIndex = 2;
            rdoMotorcycle.TabStop = true;
            rdoMotorcycle.Text = "Motorcycle";
            rdoMotorcycle.UseVisualStyleBackColor = true;
            rdoMotorcycle.Click += RdoMotorcycleClickEH;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(19, 104);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(39, 15);
            lblMake.TabIndex = 1;
            lblMake.Text = "Make:";
            // 
            // specialtyGroupBox
            // 
            specialtyGroupBox.Controls.Add(lblDecimalError);
            specialtyGroupBox.Controls.Add(lblBoolError);
            specialtyGroupBox.Controls.Add(txtSpecial);
            specialtyGroupBox.Controls.Add(lblDecimal);
            specialtyGroupBox.Controls.Add(lblBoolean);
            specialtyGroupBox.Controls.Add(rdoFalse);
            specialtyGroupBox.Controls.Add(rdoTrue);
            specialtyGroupBox.Location = new Point(12, 440);
            specialtyGroupBox.Name = "specialtyGroupBox";
            specialtyGroupBox.Size = new Size(226, 146);
            specialtyGroupBox.TabIndex = 1;
            specialtyGroupBox.TabStop = false;
            specialtyGroupBox.Text = "Specialty Properties";
            // 
            // lblDecimalError
            // 
            lblDecimalError.AutoSize = true;
            lblDecimalError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDecimalError.ForeColor = Color.Red;
            lblDecimalError.Location = new Point(45, 78);
            lblDecimalError.Name = "lblDecimalError";
            lblDecimalError.Size = new Size(124, 15);
            lblDecimalError.TabIndex = 8;
            lblDecimalError.Text = "Enter a Valid Number";
            lblDecimalError.Visible = false;
            // 
            // lblBoolError
            // 
            lblBoolError.AutoSize = true;
            lblBoolError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoolError.ForeColor = Color.Red;
            lblBoolError.Location = new Point(16, 19);
            lblBoolError.Name = "lblBoolError";
            lblBoolError.Size = new Size(97, 15);
            lblBoolError.TabIndex = 8;
            lblBoolError.Text = "Select Yes or No";
            lblBoolError.Visible = false;
            // 
            // txtSpecial
            // 
            txtSpecial.Location = new Point(10, 117);
            txtSpecial.Name = "txtSpecial";
            txtSpecial.Size = new Size(95, 23);
            txtSpecial.TabIndex = 4;
            txtSpecial.Visible = false;
            txtSpecial.Leave += TxtSpecialLeaveEH;
            // 
            // lblDecimal
            // 
            lblDecimal.AutoSize = true;
            lblDecimal.Location = new Point(7, 99);
            lblDecimal.Name = "lblDecimal";
            lblDecimal.Size = new Size(100, 15);
            lblDecimal.TabIndex = 3;
            lblDecimal.Text = "Specialty Decimal";
            lblDecimal.Visible = false;
            // 
            // lblBoolean
            // 
            lblBoolean.AutoSize = true;
            lblBoolean.Location = new Point(16, 38);
            lblBoolean.Name = "lblBoolean";
            lblBoolean.Size = new Size(100, 15);
            lblBoolean.TabIndex = 2;
            lblBoolean.Text = "Specialty Boolean";
            lblBoolean.Visible = false;
            // 
            // rdoFalse
            // 
            rdoFalse.AutoSize = true;
            rdoFalse.Location = new Point(64, 56);
            rdoFalse.Name = "rdoFalse";
            rdoFalse.Size = new Size(41, 19);
            rdoFalse.TabIndex = 1;
            rdoFalse.TabStop = true;
            rdoFalse.Text = "No";
            rdoFalse.UseVisualStyleBackColor = true;
            rdoFalse.Visible = false;
            rdoFalse.Click += RdoSpecialtyBooleanClickEH;
            // 
            // rdoTrue
            // 
            rdoTrue.AutoSize = true;
            rdoTrue.Location = new Point(16, 56);
            rdoTrue.Name = "rdoTrue";
            rdoTrue.Size = new Size(42, 19);
            rdoTrue.TabIndex = 0;
            rdoTrue.TabStop = true;
            rdoTrue.Text = "Yes";
            rdoTrue.UseVisualStyleBackColor = true;
            rdoTrue.Visible = false;
            rdoTrue.Click += RdoSpecialtyBooleanClickEH;
            // 
            // inventoryGroupBox
            // 
            inventoryGroupBox.Controls.Add(lstInventory);
            inventoryGroupBox.Location = new Point(245, 12);
            inventoryGroupBox.Name = "inventoryGroupBox";
            inventoryGroupBox.Size = new Size(250, 500);
            inventoryGroupBox.TabIndex = 2;
            inventoryGroupBox.TabStop = false;
            inventoryGroupBox.Text = "Store Inventory";
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.ItemHeight = 15;
            lstInventory.Location = new Point(6, 22);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(238, 469);
            lstInventory.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(501, 238);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(75, 48);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += BtnAddToCartClickEH;
            // 
            // cartGroupBox
            // 
            cartGroupBox.Controls.Add(lstShoppingCart);
            cartGroupBox.Location = new Point(582, 12);
            cartGroupBox.Name = "cartGroupBox";
            cartGroupBox.Size = new Size(250, 500);
            cartGroupBox.TabIndex = 4;
            cartGroupBox.TabStop = false;
            cartGroupBox.Text = "Shopping Cart";
            // 
            // lstShoppingCart
            // 
            lstShoppingCart.FormattingEnabled = true;
            lstShoppingCart.ItemHeight = 15;
            lstShoppingCart.Location = new Point(6, 22);
            lstShoppingCart.Name = "lstShoppingCart";
            lstShoppingCart.Size = new Size(238, 469);
            lstShoppingCart.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(676, 518);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(75, 23);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += BtnCheckoutClickEH;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(676, 544);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(732, 544);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(19, 15);
            lblTotalCost.TabIndex = 7;
            lblTotalCost.Text = "$0";
            // 
            // FrmVehicleStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 598);
            Controls.Add(lblTotalCost);
            Controls.Add(lblTotal);
            Controls.Add(btnCheckout);
            Controls.Add(cartGroupBox);
            Controls.Add(btnAddToCart);
            Controls.Add(inventoryGroupBox);
            Controls.Add(specialtyGroupBox);
            Controls.Add(createVehicleGroupBox);
            Name = "FrmVehicleStore";
            Text = "Vehicle Store";
            Load += FrmVehicleStore_Load;
            createVehicleGroupBox.ResumeLayout(false);
            createVehicleGroupBox.PerformLayout();
            specialtyGroupBox.ResumeLayout(false);
            specialtyGroupBox.PerformLayout();
            inventoryGroupBox.ResumeLayout(false);
            cartGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox createVehicleGroupBox;
        private RadioButton rdoVehicle;
        private RadioButton rdoCar;
        private RadioButton rdoPickup;
        private RadioButton rdoMotorcycle;
        private Label lblNumWheels;
        private Label lblPrice;
        private Label lblYear;
        private Label lblModel;
        private Label lblMake;
        private Label lblNumOwners;
        private Label lblMilesPerGallon;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtPrice;
        private TextBox txtNumWheels;
        private TextBox txtMilesPerGallon;
        private TextBox txtNumOwners;
        private Button btnCreate;
        private GroupBox specialtyGroupBox;
        private Label lblBoolean;
        private RadioButton rdoFalse;
        private RadioButton rdoTrue;
        private TextBox txtSpecial;
        private Label lblDecimal;
        private GroupBox inventoryGroupBox;
        private ListBox lstInventory;
        private Button btnAddToCart;
        private GroupBox cartGroupBox;
        private ListBox lstShoppingCart;
        private Button btnCheckout;
        private Label lblTotal;
        private Label lblTotalCost;
        private Label lblMakeError;
        private Label lblNumOwnersError;
        private Label lblMilesPerGallonError;
        private Label lblPriceError;
        private Label lblNumWheelsError;
        private Label lblYearError;
        private Label lblTypeError;
        private Label lblModelError;
        private Label lblBoolError;
        private Label lblDecimalError;
    }
}
