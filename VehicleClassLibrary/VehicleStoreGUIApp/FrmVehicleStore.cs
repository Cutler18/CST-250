/*
 * Jacob Cutler
 * CST250
 * 02/01/2026
 * Vehicle Class Library
 * Activity 1
 * */

using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BusinessLogicLayer;

namespace VehicleStoreGUIApp
{
    public partial class FrmVehicleStore : Form
    {
        // Class level variables
        string currentVehicleType;
        bool isVehicleTypeValid = false, isMakeValid = false, isModelValid = false,
            isYearValid = false, isPriceValid = false, isNumWheelsValid = false,
            isMilesPerGallonValid = false, isNumOwnersValid = false,
            isSpecialtyBooleanValid = false, isSpecialtyDecimalValid = false;
        // Create a new vehicle store logic variable
        private StoreLogic _storeLogic;
        // Binding Sources for the inventory and shopping cart
        private BindingSource _inventoryBindingSource;
        private BindingSource _shoppingCartBindingSource;

        /// <summary>
        /// Default Constructor for the FrmVehicleStore class
        /// </summary>
        public FrmVehicleStore()
        {
            InitializeComponent();

            // Initialize class level variables
            currentVehicleType = "";

            // Hide the error labels
            lblTypeError.Visible = false;
            lblMakeError.Visible = false;
            lblModelError.Visible = false;
            lblYearError.Visible = false;
            lblPriceError.Visible = false;
            lblNumWheelsError.Visible = false;
            lblMilesPerGallonError.Visible = false;
            lblNumOwnersError.Visible = false;
            lblBoolError.Visible = false;
            lblDecimalError.Visible = false;

            // Initialize the store logic variable
            _storeLogic = new StoreLogic();

            // Initialize the binding source variables
            _inventoryBindingSource = new BindingSource();
            _shoppingCartBindingSource = new BindingSource();
            // Set the data sources of the binding source objects
            _inventoryBindingSource.DataSource = _storeLogic.GetInventory();
            _shoppingCartBindingSource.DataSource = _storeLogic.GetShoppingCart();
            // Set the data source for each list control
            lstInventory.DataSource = _inventoryBindingSource;
            lstShoppingCart.DataSource = _shoppingCartBindingSource;
        }

        /// <summary>
        /// Event handler for the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVehicleStore_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Vehicle Store");
        }

        /// <summary>
        /// Event handler for the Car radio button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoCarClickEH(object sender, EventArgs e)
        {
            // Update the selected vehicle variable
            currentVehicleType = "Car";

            // Change the label for the specialty boolean
            lblBoolean.Text = "Convertible: ";
            // Change the label for the specialty decimal
            lblDecimal.Text = "Trunk Size (cubic ft): ";

            // Show the specialty boolean label and radio buttons
            lblBoolean.Visible = true;
            rdoTrue.Visible = true;
            rdoFalse.Visible = true;
            // Show the specialty decimal label and textbox
            lblDecimal.Visible = true;
            txtSpecial.Visible = true;

            // Validate the vehicle type
            ValidateVehicleType();
        }

        /// <summary>
        /// Event handler for the Motorcycle radio button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoMotorcycleClickEH(object sender, EventArgs e)
        {
            // Update the selected vehicle variable
            currentVehicleType = "Motorcycle";

            // Change the label for the specialty boolean
            lblBoolean.Text = "Has a Side Car: ";
            // Change the label for the specialty decimal
            lblDecimal.Text = "Seat Height (inches): ";

            // Show the specialty boolean label and radio buttons
            lblBoolean.Visible = true;
            rdoTrue.Visible = true;
            rdoFalse.Visible = true;
            // Show the specialty decimal label and text box
            lblDecimal.Visible = true;
            txtSpecial.Visible = true;

            // Validate the vehicle type
            ValidateVehicleType();
        }

        /// <summary>
        /// Event handler for the pickup radio button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoPickupClickEH(object sender, EventArgs e)
        {
            // Update the selected vehicle variable
            currentVehicleType = "Pickup";

            // Change the label for the specialty boolean
            lblBoolean.Text = "Has a Bed Cover: ";
            // Change the label for the specialty decimal
            lblDecimal.Text = "Bed Size (cubic feet)";

            // Show the specialty boolean label and radio buttons
            lblBoolean.Visible = true;
            rdoTrue.Visible = true;
            rdoFalse.Visible = true;
            // Show the specialty decimal label and text box
            lblDecimal.Visible = true;
            txtSpecial.Visible = true;

            // Validate the vehicle type
            ValidateVehicleType();
        }

        /// <summary>
        /// Event handler for the vehicle radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoVehicleClickEH(object sender, EventArgs e)
        {
            // Update the selected vehicle variable
            currentVehicleType = "Vehicle";

            // Hide the specialty boolean label and radio buttons
            lblBoolean.Visible = false;
            rdoTrue.Visible = false;
            rdoFalse.Visible = false;
            // Hide the specialty decimal label and text box
            lblDecimal.Visible = false;
            txtSpecial.Visible = false;

            // Validate the vehicle type
            ValidateVehicleType();
        }

        /// <summary>
        /// Event handler for the specialty boolean event click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoSpecialtyBooleanClickEH(object sender, EventArgs e)
        {
            // Validate the specialty boolean
            ValidateSpecialtyBoolean();
        }

        /// <summary>
        /// Event handler for the create button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateClickEH(object sender, EventArgs e)
        {
            // Declare and initialize variables
            int id = 0;
            string make = "", model = "";
            int year = -1, numWheels = -1, numOwners = -1;
            decimal price = -1m, mpg = -1m, specialtyDecimal = -1m;
            bool specialtyBoolean = false;
            VehicleModel vehicle;

            // Test for null/empty textboxes
            ValidateVehicleType();
            make = ValidateTxtMake();
            model = ValidateTxtModel();
            year = ValidateTxtYear();
            price = ValidateTxtPrice();
            numWheels = ValidateTxtNumWheels();
            mpg = ValidateTxtMPG();
            numOwners = ValidateTxtNumOwners();
            specialtyBoolean = ValidateSpecialtyBoolean();
            specialtyDecimal = ValidateSpecialtyDecimal();

            // Check the state of the flags
            if (isVehicleTypeValid && isMakeValid && isModelValid && isYearValid && isPriceValid
                && isNumWheelsValid && isMilesPerGallonValid && isNumOwnersValid
                && isSpecialtyBooleanValid && isSpecialtyDecimalValid)
            {
                // Switch between the types to create an appropriate vehicle
                switch (currentVehicleType)
                {
                    case "Car":
                        // Create a new car
                        vehicle = new CarModel(id, make, model, year, price, numWheels, mpg,
                            numOwners, specialtyBoolean, specialtyDecimal);
                        break;
                    case "Motorcycle":
                        // Create a new motorcycle
                        vehicle = new MotorcycleModel(id, make, model, year, price, numWheels,
                            mpg, numOwners, specialtyBoolean, specialtyDecimal);
                        break;
                    case "Pickup":
                        // Create a new pickup
                        vehicle = new PickupModel(id, make, model, year, price, numWheels, mpg,
                            numOwners, specialtyBoolean, specialtyDecimal);
                        break;
                    default:
                        // Create a new vehicle
                        vehicle = new VehicleModel(id, make, model, year, price, numWheels, mpg,
                            numOwners);
                        break;
                }

                // Add the vehicle to the inventory
                _storeLogic.AddVehicleToInventory(vehicle);
                // Show the user a success message
                MessageBox.Show($"The following car has been added to the inventory:\n" +
                    $"{vehicle}");

                // Clear the input fields
                rdoCar.Checked = false;
                rdoMotorcycle.Checked = false;
                rdoPickup.Checked = false;
                rdoVehicle.Checked = false;
                txtMake.Clear();
                txtModel.Clear();
                txtYear.Clear();
                txtPrice.Clear();
                txtNumWheels.Clear();
                txtMilesPerGallon.Clear();
                txtNumOwners.Clear();
                rdoTrue.Checked = false;
                rdoFalse.Checked = false;
                txtSpecial.Clear();

                // Refresh the list control
                _inventoryBindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// Event handler for the add to cart button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddToCartClickEH(object sender, EventArgs e)
        {
            // Get the selected vehicle from the inventory list
            VehicleModel vehicle = (VehicleModel)lstInventory.SelectedItem;
            // Add the vehicle to the shopping cart
            _storeLogic.AddVehicleToCart(vehicle.Id);
            // Reset the bindings for the shopping cart
            _shoppingCartBindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Event handler for the checkout button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCheckoutClickEH(object sender, EventArgs e)
        {
            // Checkout the user and save the total
            decimal total = _storeLogic.Checkout();
            // Display the total to the lblTotal with a currency format
            lblTotalCost.Text = total.ToString("C");
            // Reset the bindings for the shopping cart binding source
            _shoppingCartBindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Event handler for when the user leaves the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMakeLeaveEH(object sender, EventArgs e)
        {
            // Validate the make textbox
            ValidateTxtMake();
        }

        /// <summary>
        /// Event handler for when the user leaves the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtModelLeaveEH(object sender, EventArgs e)
        {
            // Validate the model textbox
            ValidateTxtModel();
        }

        /// <summary>
        /// Event handler for when the user leaves the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtYearLeaveEH(object sender, EventArgs e)
        {
            // Validate the year textbox
            ValidateTxtYear();
        }

        /// <summary>
        /// Event handler for when the user leaves the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPriceLeaveEH(object sender, EventArgs e)
        {
            // Validate the price textbox
            ValidateTxtPrice();
        }

        /// <summary>
        /// Event handler for when the user leaves the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtWheelsLeaveEH(object sender, EventArgs e)
        {
            // Validate the number of wheels textbox
            ValidateTxtNumWheels();
        }

        /// <summary>
        /// Event handler for when the user leaves the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMPGLeaveEH(object sender, EventArgs e)
        {
            // Validate the mpg textbox
            ValidateTxtMPG();
        }

        /// <summary>
        /// Event handler for when the user leaves the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtOwnersLeaveEH(object sender, EventArgs e)
        {
            // Validate the number of owners textbox
            ValidateTxtNumOwners();
        }

        /// <summary>
        /// Event handler for when the user leaves the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSpecialLeaveEH(object sender, EventArgs e)
        {
            // Validate the specialty textbox
            ValidateSpecialtyDecimal();
        }

        /// <summary>
        /// Validate if the type of vehicle has been selected
        /// </summary>
        private void ValidateVehicleType()
        {
            if (rdoCar.Checked || rdoMotorcycle.Checked || rdoPickup.Checked || rdoVehicle.Checked)
            {
                // Hide the error label
                lblTypeError.Visible = false;
                // Set the flag
                isVehicleTypeValid = true;
            }

            else
            {
                // Show the error label
                lblTypeError.Visible = true;
                // Set the flag
                isVehicleTypeValid = false;
            }
        }

        /// <summary>
        /// Validate if the textbox for the make is not empty
        /// </summary>
        private string ValidateTxtMake()
        {
            // Test for the null/empty textbox
            if (string.IsNullOrEmpty(txtMake.Text))
            {
                // Show the error label
                lblMakeError.Visible = true;
                // Set the flag
                isMakeValid = false;
            }

            else
            {
                // Hide the error label
                lblMakeError.Visible = false;
                // Set the flag
                isMakeValid = true;
            }

            // Return the text from the textbox
            return txtMake.Text;
        }

        /// <summary>
        /// Validate if the textbox for the model is not empty
        /// </summary>
        private string ValidateTxtModel()
        {
            // Test for the null/empty textbox
            if (string.IsNullOrEmpty(txtModel.Text))
            {
                // Show the error label
                lblModelError.Visible = true;
                // Set the flag
                isModelValid = false;
            }

            else
            {
                // Hide the error label
                lblModelError.Visible = false;
                // Set the flag
                isModelValid = true;
            }

            // Return the text from the textbox
            return txtModel.Text;
        }

        /// <summary>
        /// Validate if the textbox for the year is not empty
        /// Validate that the input is an integer
        /// </summary>
        /// <returns></returns>
        private int ValidateTxtYear()
        {
            // Declare and initialize
            int yearValue = -1;

            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtYear.Text))
            {
                // Show the error label
                lblYearError.Visible = true;
                // Set the flag
                isYearValid = false;
            }

            else
            {
                // Hide the error label
                lblYearError.Visible = false;
                // Attempt to parse the textbox value
                isYearValid = int.TryParse(txtYear.Text, out yearValue);
                // If the parse fails, show the error message
                if (!isYearValid)
                {
                    lblYearError.Visible = true;
                }
            }

            // Return the value of the year
            return yearValue;
        }

        /// <summary>
        /// Validate if the textbox for the price is not empty
        /// Validate that the input is an number
        /// </summary>
        /// <returns></returns>
        private decimal ValidateTxtPrice()
        {
            // Declare and initialize
            decimal priceValue = -1m;

            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                // Show the error label
                lblPriceError.Visible = true;
                // Set the flag
                isPriceValid = false;
            }

            else
            {
                // Hide the error label
                lblPriceError.Visible = false;
                // Attempt to parse the textbox value
                isPriceValid = decimal.TryParse(txtPrice.Text, out priceValue);
                // If the parse fails, show the error message
                if (!isPriceValid)
                {
                    lblPriceError.Visible = true;
                }
            }

            // Return the value of the year
            return priceValue;
        }

        /// <summary>
        /// Validate if the textbox for the number of wheels is not empty
        /// Validate that the input is an integer
        /// </summary>
        /// <returns></returns>
        private int ValidateTxtNumWheels()
        {
            // Declare and initialize
            int numWheelsValue = -1;

            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtNumWheels.Text))
            {
                // Show the error label
                lblNumWheelsError.Visible = true;
                // Set the flag
                isNumWheelsValid = false;
            }

            else
            {
                // Hide the error label
                lblNumWheelsError.Visible = false;
                // Attempt to parse the textbox value
                isNumWheelsValid = int.TryParse(txtNumWheels.Text, out numWheelsValue);
                // If the parse fails, show the error message
                if (!isNumWheelsValid)
                {
                    lblNumWheelsError.Visible = true;
                }
            }

            // Return the value of the year
            return numWheelsValue;
        }

        /// <summary>
        /// Validate if the textbox for the miles per gallon is not empty
        /// Validate that the input is an number
        /// </summary>
        /// <returns></returns>
        private decimal ValidateTxtMPG()
        {
            // Declare and initialize
            decimal mpgValue = -1m;

            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtMilesPerGallon.Text))
            {
                // Show the error label
                lblMilesPerGallonError.Visible = true;
                // Set the flag
                isMilesPerGallonValid = false;
            }

            else
            {
                // Hide the error label
                lblMilesPerGallonError.Visible = false;
                // Attempt to parse the textbox value
                isMilesPerGallonValid = decimal.TryParse(txtMilesPerGallon.Text, out mpgValue);
                // If the parse fails, show the error message
                if (!isMilesPerGallonValid)
                {
                    lblMilesPerGallonError.Visible = true;
                }
            }

            // Return the value of the year
            return mpgValue;
        }

        /// <summary>
        /// Validate if the textbox for the number of owners is not empty
        /// Validate that the input is an integer
        /// </summary>
        /// <returns></returns>
        private int ValidateTxtNumOwners()
        {
            // Declare and initialize
            int numOwnersValue = -1;

            // Test for a null/empty textbox
            if (string.IsNullOrEmpty(txtNumOwners.Text))
            {
                // Show the error label
                lblNumOwnersError.Visible = true;
                // Set the flag
                isNumOwnersValid = false;
            }

            else
            {
                // Hide the error label
                lblNumOwnersError.Visible = false;
                // Attempt to parse the textbox value
                isNumOwnersValid = int.TryParse(txtNumOwners.Text, out numOwnersValue);
                // If the parse fails, show the error message
                if (!isNumOwnersValid)
                {
                    lblNumOwnersError.Visible = true;
                }
            }

            // Return the value of the year
            return numOwnersValue;
        }

        /// <summary>
        /// Validate if the specialty boolean radio buttons have been selected
        /// </summary>
        /// <returns></returns>
        private bool ValidateSpecialtyBoolean()
        {
            // Check if the specialty group box is needed
            if (currentVehicleType != "Vehicle")
            {
                // Check if a radio button has been selected
                if (rdoTrue.Checked || rdoFalse.Checked)
                {
                    // Hide the error label
                    lblBoolError.Visible = false;
                    // Set the flag
                    isSpecialtyBooleanValid = true;
                }

                else
                {
                    // Show the error lable
                    lblBoolError.Visible = true;
                    // Set the flag
                    isSpecialtyBooleanValid = false;
                }
            }

            else
            {
                // Hide the error label
                lblBoolError.Visible = false;
                // Set the flag
                isSpecialtyBooleanValid = true;
            }

            // Return the value of the yes radio button
            return rdoTrue.Checked;
        }

        /// <summary>
        /// Validate if the specialty textbox is not empty
        /// Validate that the input is a number
        /// </summary>
        /// <returns></returns>
        private decimal ValidateSpecialtyDecimal()
        {
            // Declare and initialize
            decimal specialtyDecimalValue = -1m;

            // Initialize
            // Check if the specialty group box is needed
            if (currentVehicleType != "Vehicle")
            {
                // Test for a null/empty textbox
                if (string.IsNullOrEmpty(txtSpecial.Text))
                {
                    // Show the error label
                    lblDecimalError.Visible = true;
                    // Set the flag
                    isSpecialtyDecimalValid = false;
                }

                else
                {
                    // Hide the error label
                    lblDecimalError.Visible = false;
                    // Set the flag
                    isSpecialtyDecimalValid = decimal.TryParse(txtSpecial.Text, out specialtyDecimalValue);
                    // If the parse failed, show the error message
                    if (!isSpecialtyDecimalValid)
                    {
                        lblDecimalError.Visible = true;
                    }
                }
            }

            else
            {
                // Hide the error label
                lblDecimalError.Visible = false;
                // Set the flag
                isSpecialtyDecimalValid = true;
            }

            // Return the value of the specialty decimal
            return specialtyDecimalValue;
        }
    }
}
