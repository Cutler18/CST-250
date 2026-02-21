namespace PizzaMaker
{
    partial class FrmPizzaMaker
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
            lblName = new Label();
            txtName = new TextBox();
            grpIngredients = new GroupBox();
            chbTomatoes = new CheckBox();
            chbPeppers = new CheckBox();
            chbSausage = new CheckBox();
            chbPineapple = new CheckBox();
            chbMushrooms = new CheckBox();
            chbOlives = new CheckBox();
            chbBacon = new CheckBox();
            chbPepperoni = new CheckBox();
            lblStrangeAddOns = new Label();
            lsbStrangeAddOns = new ListBox();
            grpCrust = new GroupBox();
            rdoGlutenFree = new RadioButton();
            rdoStuffedCrust = new RadioButton();
            rdoDeepDish = new RadioButton();
            rdoThinCrust = new RadioButton();
            grpExtraGoodies = new GroupBox();
            lblCheese = new Label();
            lblAmountOfCheese = new Label();
            lblSauce = new Label();
            lblAmountOfSauce = new Label();
            hsbCheese = new HScrollBar();
            hsbSauce = new HScrollBar();
            lblDeliveryTime = new Label();
            dtpDeliveryTime = new DateTimePicker();
            lblPizzaBoxColor = new Label();
            picPizzaBoxColor = new PictureBox();
            lblPizzaPrice = new Label();
            lblPrice = new Label();
            btnResetFrm = new Button();
            btnCreatePizza = new Button();
            btnSeeFullOrder = new Button();
            grpIngredients.SuspendLayout();
            grpCrust.SuspendLayout();
            grpExtraGoodies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 38);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(383, 44);
            txtName.TabIndex = 1;
            txtName.Leave += TxtNameLeaveEH;
            // 
            // grpIngredients
            // 
            grpIngredients.Controls.Add(chbTomatoes);
            grpIngredients.Controls.Add(chbPeppers);
            grpIngredients.Controls.Add(chbSausage);
            grpIngredients.Controls.Add(chbPineapple);
            grpIngredients.Controls.Add(chbMushrooms);
            grpIngredients.Controls.Add(chbOlives);
            grpIngredients.Controls.Add(chbBacon);
            grpIngredients.Controls.Add(chbPepperoni);
            grpIngredients.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpIngredients.Location = new Point(12, 62);
            grpIngredients.Name = "grpIngredients";
            grpIngredients.Size = new Size(500, 250);
            grpIngredients.TabIndex = 2;
            grpIngredients.TabStop = false;
            grpIngredients.Text = "Ingredients";
            // 
            // chbTomatoes
            // 
            chbTomatoes.AutoSize = true;
            chbTomatoes.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbTomatoes.Location = new Point(265, 187);
            chbTomatoes.Name = "chbTomatoes";
            chbTomatoes.Size = new Size(187, 42);
            chbTomatoes.TabIndex = 7;
            chbTomatoes.Text = "Tomatoes";
            chbTomatoes.UseVisualStyleBackColor = true;
            chbTomatoes.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbPeppers
            // 
            chbPeppers.AutoSize = true;
            chbPeppers.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPeppers.Location = new Point(265, 139);
            chbPeppers.Name = "chbPeppers";
            chbPeppers.Size = new Size(162, 42);
            chbPeppers.TabIndex = 6;
            chbPeppers.Text = "Peppers";
            chbPeppers.UseVisualStyleBackColor = true;
            chbPeppers.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbSausage
            // 
            chbSausage.AutoSize = true;
            chbSausage.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbSausage.Location = new Point(265, 91);
            chbSausage.Name = "chbSausage";
            chbSausage.Size = new Size(163, 42);
            chbSausage.TabIndex = 5;
            chbSausage.Text = "Sausage";
            chbSausage.UseVisualStyleBackColor = true;
            chbSausage.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbPineapple
            // 
            chbPineapple.AutoSize = true;
            chbPineapple.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPineapple.Location = new Point(265, 43);
            chbPineapple.Name = "chbPineapple";
            chbPineapple.Size = new Size(188, 42);
            chbPineapple.TabIndex = 4;
            chbPineapple.Text = "Pineapple";
            chbPineapple.UseVisualStyleBackColor = true;
            chbPineapple.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbMushrooms
            // 
            chbMushrooms.AutoSize = true;
            chbMushrooms.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbMushrooms.Location = new Point(10, 187);
            chbMushrooms.Name = "chbMushrooms";
            chbMushrooms.Size = new Size(220, 42);
            chbMushrooms.TabIndex = 3;
            chbMushrooms.Text = "Mushrooms";
            chbMushrooms.UseVisualStyleBackColor = true;
            chbMushrooms.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbOlives
            // 
            chbOlives.AutoSize = true;
            chbOlives.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbOlives.Location = new Point(10, 139);
            chbOlives.Name = "chbOlives";
            chbOlives.Size = new Size(136, 42);
            chbOlives.TabIndex = 2;
            chbOlives.Text = "Olives";
            chbOlives.UseVisualStyleBackColor = true;
            chbOlives.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbBacon
            // 
            chbBacon.AutoSize = true;
            chbBacon.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbBacon.Location = new Point(10, 91);
            chbBacon.Name = "chbBacon";
            chbBacon.Size = new Size(137, 42);
            chbBacon.TabIndex = 1;
            chbBacon.Text = "Bacon";
            chbBacon.UseVisualStyleBackColor = true;
            chbBacon.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbPepperoni
            // 
            chbPepperoni.AutoSize = true;
            chbPepperoni.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPepperoni.Location = new Point(10, 43);
            chbPepperoni.Name = "chbPepperoni";
            chbPepperoni.Size = new Size(193, 42);
            chbPepperoni.TabIndex = 0;
            chbPepperoni.Text = "Pepperoni";
            chbPepperoni.UseVisualStyleBackColor = true;
            chbPepperoni.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // lblStrangeAddOns
            // 
            lblStrangeAddOns.AutoSize = true;
            lblStrangeAddOns.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStrangeAddOns.Location = new Point(12, 315);
            lblStrangeAddOns.Name = "lblStrangeAddOns";
            lblStrangeAddOns.Size = new Size(291, 38);
            lblStrangeAddOns.TabIndex = 3;
            lblStrangeAddOns.Text = "Strange Add Ons";
            // 
            // lsbStrangeAddOns
            // 
            lsbStrangeAddOns.FormattingEnabled = true;
            lsbStrangeAddOns.Items.AddRange(new object[] { "Hotdogs", "Eggplant", "Artichoke Hearts", "Eggs", "Peanut Butter", "Prosciutto", "Honey", "Chili Thread", "Olive Oil", "Arugula", "Garlic", "Chicken", "Anchovies", "BBQ Sauce", "Green Onion", "Red Onion", "Carrots", "Peanuts" });
            lsbStrangeAddOns.Location = new Point(12, 356);
            lsbStrangeAddOns.Name = "lsbStrangeAddOns";
            lsbStrangeAddOns.SelectionMode = SelectionMode.MultiSimple;
            lsbStrangeAddOns.Size = new Size(315, 232);
            lsbStrangeAddOns.TabIndex = 4;
            lsbStrangeAddOns.SelectedIndexChanged += LsbStrangeAddOnsSelectedIndexChangedEH;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdoGlutenFree);
            grpCrust.Controls.Add(rdoStuffedCrust);
            grpCrust.Controls.Add(rdoDeepDish);
            grpCrust.Controls.Add(rdoThinCrust);
            grpCrust.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCrust.Location = new Point(333, 318);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(252, 270);
            grpCrust.TabIndex = 5;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust";
            // 
            // rdoGlutenFree
            // 
            rdoGlutenFree.AutoSize = true;
            rdoGlutenFree.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoGlutenFree.Location = new Point(6, 187);
            rdoGlutenFree.Name = "rdoGlutenFree";
            rdoGlutenFree.Size = new Size(214, 42);
            rdoGlutenFree.TabIndex = 3;
            rdoGlutenFree.TabStop = true;
            rdoGlutenFree.Text = "Gluten Free";
            rdoGlutenFree.UseVisualStyleBackColor = true;
            rdoGlutenFree.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoStuffedCrust
            // 
            rdoStuffedCrust.AutoSize = true;
            rdoStuffedCrust.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoStuffedCrust.Location = new Point(6, 139);
            rdoStuffedCrust.Name = "rdoStuffedCrust";
            rdoStuffedCrust.Size = new Size(235, 42);
            rdoStuffedCrust.TabIndex = 2;
            rdoStuffedCrust.TabStop = true;
            rdoStuffedCrust.Text = "Stuffed Crust";
            rdoStuffedCrust.UseVisualStyleBackColor = true;
            rdoStuffedCrust.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoDeepDish
            // 
            rdoDeepDish.AutoSize = true;
            rdoDeepDish.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoDeepDish.Location = new Point(6, 91);
            rdoDeepDish.Name = "rdoDeepDish";
            rdoDeepDish.Size = new Size(194, 42);
            rdoDeepDish.TabIndex = 1;
            rdoDeepDish.TabStop = true;
            rdoDeepDish.Text = "Deep Dish";
            rdoDeepDish.UseVisualStyleBackColor = true;
            rdoDeepDish.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoThinCrust
            // 
            rdoThinCrust.AutoSize = true;
            rdoThinCrust.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoThinCrust.Location = new Point(6, 43);
            rdoThinCrust.Name = "rdoThinCrust";
            rdoThinCrust.Size = new Size(201, 42);
            rdoThinCrust.TabIndex = 0;
            rdoThinCrust.TabStop = true;
            rdoThinCrust.Text = "Thin Crust";
            rdoThinCrust.UseVisualStyleBackColor = true;
            rdoThinCrust.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // grpExtraGoodies
            // 
            grpExtraGoodies.Controls.Add(lblCheese);
            grpExtraGoodies.Controls.Add(lblAmountOfCheese);
            grpExtraGoodies.Controls.Add(lblSauce);
            grpExtraGoodies.Controls.Add(lblAmountOfSauce);
            grpExtraGoodies.Controls.Add(hsbCheese);
            grpExtraGoodies.Controls.Add(hsbSauce);
            grpExtraGoodies.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpExtraGoodies.Location = new Point(12, 594);
            grpExtraGoodies.Name = "grpExtraGoodies";
            grpExtraGoodies.Size = new Size(573, 323);
            grpExtraGoodies.TabIndex = 6;
            grpExtraGoodies.TabStop = false;
            grpExtraGoodies.Text = "Extra Goodies";
            // 
            // lblCheese
            // 
            lblCheese.AutoSize = true;
            lblCheese.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheese.Location = new Point(321, 189);
            lblCheese.Name = "lblCheese";
            lblCheese.Size = new Size(57, 38);
            lblCheese.TabIndex = 5;
            lblCheese.Text = "00";
            lblCheese.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmountOfCheese
            // 
            lblAmountOfCheese.AutoSize = true;
            lblAmountOfCheese.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountOfCheese.Location = new Point(10, 189);
            lblAmountOfCheese.Name = "lblAmountOfCheese";
            lblAmountOfCheese.Size = new Size(274, 38);
            lblAmountOfCheese.TabIndex = 4;
            lblAmountOfCheese.Text = "Amount of Cheese";
            // 
            // lblSauce
            // 
            lblSauce.AutoSize = true;
            lblSauce.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSauce.Location = new Point(321, 75);
            lblSauce.Name = "lblSauce";
            lblSauce.Size = new Size(57, 38);
            lblSauce.TabIndex = 3;
            lblSauce.Text = "00";
            lblSauce.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmountOfSauce
            // 
            lblAmountOfSauce.AutoSize = true;
            lblAmountOfSauce.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountOfSauce.Location = new Point(10, 75);
            lblAmountOfSauce.Name = "lblAmountOfSauce";
            lblAmountOfSauce.Size = new Size(258, 38);
            lblAmountOfSauce.TabIndex = 2;
            lblAmountOfSauce.Text = "Amount of Sauce";
            // 
            // hsbCheese
            // 
            hsbCheese.Location = new Point(10, 227);
            hsbCheese.Name = "hsbCheese";
            hsbCheese.Size = new Size(552, 68);
            hsbCheese.TabIndex = 1;
            hsbCheese.ValueChanged += HsbExtraGoodiesValueChanged;
            // 
            // hsbSauce
            // 
            hsbSauce.Location = new Point(10, 113);
            hsbSauce.Name = "hsbSauce";
            hsbSauce.Size = new Size(552, 68);
            hsbSauce.TabIndex = 0;
            hsbSauce.ValueChanged += HsbExtraGoodiesValueChanged;
            // 
            // lblDeliveryTime
            // 
            lblDeliveryTime.AutoSize = true;
            lblDeliveryTime.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeliveryTime.Location = new Point(662, 15);
            lblDeliveryTime.Name = "lblDeliveryTime";
            lblDeliveryTime.Size = new Size(247, 38);
            lblDeliveryTime.TabIndex = 7;
            lblDeliveryTime.Text = "Delivery Time";
            // 
            // dtpDeliveryTime
            // 
            dtpDeliveryTime.CustomFormat = "MM/dd/yyy hh:mm";
            dtpDeliveryTime.Format = DateTimePickerFormat.Custom;
            dtpDeliveryTime.Location = new Point(662, 62);
            dtpDeliveryTime.Name = "dtpDeliveryTime";
            dtpDeliveryTime.Size = new Size(421, 44);
            dtpDeliveryTime.TabIndex = 8;
            dtpDeliveryTime.ValueChanged += DtpDeliveryTimeValueChangedEH;
            // 
            // lblPizzaBoxColor
            // 
            lblPizzaBoxColor.AutoSize = true;
            lblPizzaBoxColor.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPizzaBoxColor.Location = new Point(662, 109);
            lblPizzaBoxColor.Name = "lblPizzaBoxColor";
            lblPizzaBoxColor.Size = new Size(273, 38);
            lblPizzaBoxColor.TabIndex = 9;
            lblPizzaBoxColor.Text = "Pizza Box Color";
            // 
            // picPizzaBoxColor
            // 
            picPizzaBoxColor.BorderStyle = BorderStyle.FixedSingle;
            picPizzaBoxColor.Location = new Point(662, 153);
            picPizzaBoxColor.Name = "picPizzaBoxColor";
            picPizzaBoxColor.Size = new Size(421, 100);
            picPizzaBoxColor.TabIndex = 10;
            picPizzaBoxColor.TabStop = false;
            picPizzaBoxColor.Click += PicPizzaBoxColorClickEH;
            // 
            // lblPizzaPrice
            // 
            lblPizzaPrice.AutoSize = true;
            lblPizzaPrice.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPizzaPrice.Location = new Point(662, 256);
            lblPizzaPrice.Name = "lblPizzaPrice";
            lblPizzaPrice.Size = new Size(208, 38);
            lblPizzaPrice.TabIndex = 11;
            lblPizzaPrice.Text = "Pizza Price:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(875, 256);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(60, 38);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "$0";
            // 
            // btnResetFrm
            // 
            btnResetFrm.Location = new Point(662, 297);
            btnResetFrm.Name = "btnResetFrm";
            btnResetFrm.Size = new Size(187, 46);
            btnResetFrm.TabIndex = 13;
            btnResetFrm.Text = "Reset Form";
            btnResetFrm.UseVisualStyleBackColor = true;
            btnResetFrm.Click += BtnResetFormEH;
            // 
            // btnCreatePizza
            // 
            btnCreatePizza.Location = new Point(875, 297);
            btnCreatePizza.Name = "btnCreatePizza";
            btnCreatePizza.Size = new Size(208, 46);
            btnCreatePizza.TabIndex = 14;
            btnCreatePizza.Text = "Create Pizza";
            btnCreatePizza.UseVisualStyleBackColor = true;
            btnCreatePizza.Click += BtnCreatePizzaClickEH;
            // 
            // btnSeeFullOrder
            // 
            btnSeeFullOrder.Location = new Point(662, 349);
            btnSeeFullOrder.Name = "btnSeeFullOrder";
            btnSeeFullOrder.Size = new Size(235, 46);
            btnSeeFullOrder.TabIndex = 15;
            btnSeeFullOrder.Text = "See Full Order";
            btnSeeFullOrder.UseVisualStyleBackColor = true;
            btnSeeFullOrder.Click += BtnSeeFullOrderClickEH;
            // 
            // FrmPizzaMaker
            // 
            AutoScaleDimensions = new SizeF(19F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 929);
            Controls.Add(btnSeeFullOrder);
            Controls.Add(btnCreatePizza);
            Controls.Add(btnResetFrm);
            Controls.Add(lblPrice);
            Controls.Add(lblPizzaPrice);
            Controls.Add(picPizzaBoxColor);
            Controls.Add(lblPizzaBoxColor);
            Controls.Add(dtpDeliveryTime);
            Controls.Add(lblDeliveryTime);
            Controls.Add(grpExtraGoodies);
            Controls.Add(grpCrust);
            Controls.Add(lsbStrangeAddOns);
            Controls.Add(lblStrangeAddOns);
            Controls.Add(grpIngredients);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmPizzaMaker";
            Text = "Pizza Maker";
            grpIngredients.ResumeLayout(false);
            grpIngredients.PerformLayout();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            grpExtraGoodies.ResumeLayout(false);
            grpExtraGoodies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private GroupBox grpIngredients;
        private CheckBox chbTomatoes;
        private CheckBox chbPeppers;
        private CheckBox chbSausage;
        private CheckBox chbPineapple;
        private CheckBox chbMushrooms;
        private CheckBox chbOlives;
        private CheckBox chbBacon;
        private CheckBox chbPepperoni;
        private Label lblStrangeAddOns;
        private ListBox lsbStrangeAddOns;
        private GroupBox grpCrust;
        private RadioButton rdoGlutenFree;
        private RadioButton rdoStuffedCrust;
        private RadioButton rdoDeepDish;
        private RadioButton rdoThinCrust;
        private GroupBox grpExtraGoodies;
        private HScrollBar hsbCheese;
        private HScrollBar hsbSauce;
        private Label lblCheese;
        private Label lblAmountOfCheese;
        private Label lblSauce;
        private Label lblAmountOfSauce;
        private Label lblDeliveryTime;
        private DateTimePicker dtpDeliveryTime;
        private Label lblPizzaBoxColor;
        private PictureBox picPizzaBoxColor;
        private Label lblPizzaPrice;
        private Label lblPrice;
        private Button btnResetFrm;
        private Button btnCreatePizza;
        private Button btnSeeFullOrder;
    }
}
