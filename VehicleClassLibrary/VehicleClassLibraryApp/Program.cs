// See https://aka.ms/new-console-template for more information
/*
 * Jacob Cutler
 * CST250
 * 02/01/2026
 * Vehicle Class Library
 * Activity 1
 * */

//------------------------------------------------
// Start of the Main Method
//------------------------------------------------

// Print a welcome message to the user

using System.ComponentModel;
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BusinessLogicLayer;

Console.WriteLine("Welcome to the Vehicle Shop: To begin, please create a selection" +
    " of vehicles and add them to the inventory. Once the inventory is populated," +
    " you can proceed by adding vehicles to your cart. Finally, when you're ready to" +
    " complete your purchase, proceed to the checkout where your total bill well be" +
    " calculated.");

// Call the control loop method to manage the program running
ControlLoop();

// Read an integer input from user
static int ReadChoice()
{
    // Declare and initialize
    string? input = "";
    int choice = -1;

    // Loop until the user enters a valid integer
    while (choice == -1)
    {
        // Print the users options
        Console.WriteLine("Choose an action: \n0) Quit \n1) Print the inventory" +
            "\n2) Print the shopping cart \n3) Create a vehicle \n4) Add a vehicle" +
            " to the shopping cart \n5) Checkout \n6) Save inventory to a text file" +
            "\n7) Load inventory from a text file \nInput: ");

        // Read the user input from the console
        input = Console.ReadLine();

        // Make sure the user entered a value
        if (!string.IsNullOrEmpty(input))
        {
            try
            {
                // Parse the input from the user to the choice variable
                choice = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a valid number. The number entered" +
                    " was either too small or too large.");
            }
            catch (Exception exp)
            {
                Console.WriteLine("There was an exception " + exp + ". Please try again.");
            }
        }
    }
    // Return the users input
    return choice;
}

//------------------------------------------------
// End of the Main Method
//------------------------------------------------

// Control the car store loop
static void ControlLoop()
{
    // Create an instance of the store logic class
    StoreLogic storeLogic = new StoreLogic();
    // Declare and initialize other variables
    int choice = -1, id = 0, year = 0, numWheels = 0, numOwners = 0;
    string make = "", model = "";
    decimal price = 0m, total = 0m, milesPerGallon = 0m;
    // Specialty vehicle variables
    bool isConvertible = false, hasBedCover = false, hasSideCar = false;
    decimal trunkSize = 0m, bedSize = 0m, seatHeight = 0m;
    List<VehicleModel> vehicleList = new List<VehicleModel>();
    VehicleModel vehicle = new VehicleModel();

    // Continue the loop until the user enters 0
    while (choice != 0)
    {
        try
        {
            // Get the input from the user
            choice = ReadChoice();

            // Use the users choice to switch between the options
            switch (choice)
            {
                // Quit
                case 0:
                    Console.WriteLine("Have a great day!");
                    break;
                // Print the inventory
                case 1:
                    // Get the inventory list from storeLogic
                    vehicleList = storeLogic.GetInventory();
                    // Print a title for the list
                    Console.WriteLine("Inventory: ");
                    // Loop through the inventory list
                    foreach (VehicleModel inventoryVehicle in vehicleList)
                    {
                        // Print each vehicle from the inventory
                        Console.WriteLine(inventoryVehicle);
                    }
                    Console.WriteLine();
                    break;
                // Print the shopping cart
                case 2:
                    // Get the shopping cart list from storeLogic
                    vehicleList = storeLogic.GetShoppingCart();
                    // Print a title for the list
                    Console.WriteLine("Shopping Cart: ");
                    // Loop through the shopping cart list
                    foreach (VehicleModel shoppingCartVehicle in vehicleList)
                    {
                        // Print each vehicle from the shopping cart
                        Console.WriteLine(shoppingCartVehicle);
                    }
                    Console.WriteLine();
                    break;
                // Create a vehicle
                case 3:
                    // Read the type of vehicle
                    Console.Write("Enter 1 to create a car, 2 to create a motorcycle, 3 to create a pickup" +
                        ", or 4 to create a different vehicle: ");
                    try
                    {
                        choice = int.Parse(Console.ReadLine());

                        if (choice >= 1 && choice <= 4)
                        {
                            // Get the common properties for the vehicle
                            // Read in the make of the vehicle
                            Console.Write("Enter the make of the vehicle: ");
                            make = Console.ReadLine();
                            // Read the model of the vehicle
                            Console.Write("Enter the model of the vehicle: ");
                            model = Console.ReadLine();
                            // Read the year of the vehicle
                            Console.Write("Enter the year of the vehicle: ");
                            year = int.Parse(Console.ReadLine());
                            // Read the price of the vehicle
                            Console.Write("Enter the price of the vehicle: ");
                            price = decimal.Parse(Console.ReadLine());
                            // Read the number of wheels on the vehicle
                            Console.Write("Enter the number of wheels on the vehicle: ");
                            numWheels = int.Parse(Console.ReadLine());
                            // Read the amount of miles per gallon of the vehicle
                            Console.Write("Enter the miles per gallon of the vehicle: ");
                            milesPerGallon = decimal.Parse(Console.ReadLine());
                            // Read the number of owners of the vehicle
                            Console.Write("Enter the number of owners the vehicle has had: ");
                            numOwners = int.Parse(Console.ReadLine());

                            // Switch statement to read the vehicle specific properties
                            switch (choice)
                            {
                                // Car
                                case 1:
                                    // Read the convertible status for the car
                                    Console.Write("Enter if the car is a convertible (True/False): ");
                                    isConvertible = bool.Parse(Console.ReadLine());
                                    // Read the trunk size of the car
                                    Console.Write("Enter the trunk size of the car in cubic feet: ");
                                    trunkSize = decimal.Parse(Console.ReadLine());
                                    // Create a new car
                                    vehicle = new CarModel(id, make, model, year, price, numWheels, milesPerGallon, numOwners, isConvertible, trunkSize);
                                    break;
                                // Motorcycle
                                case 2:
                                    // Read the side car status for the motorcycle
                                    Console.Write("Enter if the motorcycle has a side car (True/False): ");
                                    hasSideCar = bool.Parse(Console.ReadLine());
                                    // Read the motorcycle seat height
                                    Console.Write("Enter the seat height for the motorcycle in inces: ");
                                    seatHeight = decimal.Parse(Console.ReadLine());
                                    // Create a new motorcycle
                                    vehicle = new MotorcycleModel(id, make, model, year, price, numWheels, milesPerGallon, numOwners, hasSideCar,
                                        seatHeight);
                                    break;
                                // Pickup
                                case 3:
                                    // Read the pickup bed cover status for the pickup
                                    Console.Write("Enter if the pickup has a bed cover (True/False): ");
                                    hasBedCover = bool.Parse(Console.ReadLine());
                                    // Read the bed size of the truck
                                    Console.Write("Enter the bed size in cubic feet: ");
                                    bedSize = decimal.Parse(Console.ReadLine());
                                    // Create a new pickup
                                    vehicle = new PickupModel(id, make, model, year, price, numWheels, milesPerGallon, numOwners, hasBedCover, bedSize);
                                    break;
                                // Vehicle
                                case 4:
                                    // Create a new vehicle
                                    vehicle = new VehicleModel(id, make, model, year, price, numWheels, milesPerGallon, numOwners);
                                    break;
                                // Default
                                default:
                                    Console.WriteLine("Invalid Input");
                                    break;
                            }
                            // Add the vehicle to the inventory
                            storeLogic.AddVehicleToInventory(vehicle);
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    break;
                // Add a vehicle to the shopping cart
                case 4:
                    // Get the id of the vehicle from the user
                    Console.Write("Enter the id of the vehicle you want to buy: ");
                    id = int.Parse(Console.ReadLine());
                    // Add the vehicle to the shopping cart
                    storeLogic.AddVehicleToCart(id);
                    Console.WriteLine();
                    break;
                // Checkout
                case 5:
                    // Checkout the user
                    total = storeLogic.Checkout();
                    // Print the total from the checkout method
                    Console.WriteLine("Your total is: " + total);
                    Console.WriteLine();
                    break;
                // Save inventory to a text file
                case 6:
                    // Use the business logic layer to write the inventory to the file
                    storeLogic.WriteInventory();
                    // Print out a success message
                    Console.WriteLine("The inventory has been saved to the text file");
                    Console.WriteLine();
                    break;
                // Load inventory from a text file
                case 7:
                    // Use the business layer to read the invetory from the file
                    storeLogic.ReadInventory();
                    // Print out a success message
                    Console.WriteLine("The inventory has beed read from the text file");
                    Console.WriteLine();
                    break;
                // Other input
                default:
                    Console.WriteLine("Invalid Choice");
                    Console.WriteLine();
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid Input");
        }
    }
} // End of ControlLoop method
