/*
 * Jacob Cutler
 * CST250
 * 02/01/2026
 * Vehicle Class Library
 * Activity 1
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using VehicleClassLibrary.Models;

namespace VehicleClassLibrary.Services.DataAccessLayer
{
    public class StoreDAO
    {
        // CarModel list for the stores inventory
        private List<VehicleModel> _inventory;
        // CarModel list for the users shipping cart
        private List<VehicleModel> _shoppingCart;
        // The directory for the inventory test file
        private string _fileDirectory = "Data";
        // The name of the inventory text file
        private string _textFile = "inventory.txt";
        // The full path to the text file
        private string _filePath;
        
        /// <summary>
        /// Default constructor for StoreDAO class
        /// </summary>
        public StoreDAO()
        {
            // Initialize the vehicle model lists
            _inventory = new List<VehicleModel>();
            _shoppingCart = new List<VehicleModel>();

            // Set up the file to the inventory text file
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fileDirectory, _textFile);
        } // End of constructor

        /// <summary>
        /// Try to parse an integer and return 0 for any exception if thrown
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private int ParseInteger(string input)
        {
            try
            {
                // Parse the input and return
                return int.Parse(input);
            }
            catch (Exception ex)
            {
                // Return 0
                return 0;
            }
        } // End of ParseInteger

        /// <summary>
        /// Try to parse a decimal and return 0 for any exception if thrown
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private decimal ParseDecimal(string input)
        {
            try
            {
                // Parse the input and return
                return decimal.Parse(input);
            }
            catch (Exception ex)
            {
                // Return 0
                return 0m;
            }
        } // End ParseDecimal

        /// <summary>
        /// Try to parse a boolean and return false if an exception is thrown
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool ParseBoolean(string input)
        {
            try
            {
                // Parse the input and return
                return bool.Parse(input);
            }
            catch (Exception ex)
            {
                // Return false
                return false;
            }
        } // End of ParseBoolean

        /// <summary>
        /// Get a list of vehicles in the inventory
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetInventory()
        {
            // Return the inventory list
            return _inventory;
        } // End of GetInventory

        /// <summary>
        /// Get a list of vehicles in the users shopping cart
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetShoppingCart()
        {
            //Return the shopping cart list
            return _shoppingCart;
        } // End of GetShoppingCart

        /// <summary>
        /// Add a new vehicle to the inventory
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public int AddVehicleToInventory(VehicleModel vehicle)
        {
            // Set the id for the new vehicle
            vehicle.Id = _inventory.Count + 1;

            //  the vehicle to the inventory list
            _inventory.Add(vehicle);

            // Return the id of the new vehicle
            return vehicle.Id;
        } // End of AddVehicleToInventory

        /// <summary>
        /// Add a vehicle to the shopping cart based on the vehicle id
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int AddVehicleToCart(int vehicleId)
        {
            // Loop through the inventory to find the correct vehicle
            for (int i = 0; i < _inventory.Count; i++)
            {
                // Check if the inventory vehicle id matches the parameter
                if (_inventory[i].Id == vehicleId)
                {
                    // If so, add the vehicle to the shopping cart
                    _shoppingCart.Add(_inventory[i]);
                }
            }

            return _shoppingCart.Count;
        } // End of AddVehicleToCart

        /// <summary>
        /// Write the inventory to a text file
        /// </summary>
        /// <returns></returns>
        public bool WriteInventory()
        {
            // Check if the directory exists
            if (!Directory.Exists(_fileDirectory))
            {
                // If the directory does not exist, create it
                Directory.CreateDirectory(_fileDirectory);
            }

            // Catch any exeptions with the stream writer
            try
            {
                // Create the stream writer to write the file
                using (StreamWriter writer = new StreamWriter(_filePath))
                {
                    // Loop through the inventory list
                    foreach (VehicleModel vehicle in _inventory)
                    {
                        Type vehicleType = vehicle.GetType();
                        switch (vehicleType.Name)
                        {
                            case "CarModel":
                                // Cast the vehicle to a car
                                CarModel car = (CarModel)vehicle;
                                // Write the car to the file
                                writer.WriteLine($"Car, {car.Make}, {car.Model}, {car.Year}, {car.Price}, {car.NumWheels}, " +
                                    $"{car.MilesPerGallon}, {car.NumOwners}, {car.IsConvertible}, {car.TrunkSize}");
                                break;

                            case "MotorcycleModel":
                                // Cast the vehicle to a motorcycle
                                MotorcycleModel motorcycle = (MotorcycleModel)vehicle;
                                // Write the motorcycle to the file
                                writer.WriteLine($"Motorcycle, {motorcycle.Make}, {motorcycle.Model}, {motorcycle.Year}" +
                                    $"{motorcycle.Price}, {motorcycle.NumWheels}, {motorcycle.MilesPerGallon}, {motorcycle.NumOwners}," +
                                    $"{motorcycle.HasSideCar}, {motorcycle.SeatHeight}");
                                break;

                            case "PickupModel":
                                // Cast the vehicle to a pickup
                                PickupModel pickup = (PickupModel)vehicle;
                                // Write the motorcycle to the file
                                writer.WriteLine($"Pickup, {pickup.Make}, {pickup.Model}, {pickup.Year}," +
                                    $"{pickup.Price}, {pickup.NumWheels}, {pickup.MilesPerGallon}, " +
                                    $"{pickup.NumOwners}, {pickup.HasBedCover}, {pickup.BedSize}");
                                break;

                            default:
                                // Write the vehicle to the file
                                writer.WriteLine($"Vehicle, {vehicle.Make}, {vehicle.Model}, {vehicle.Year}," +
                                    $"{vehicle.Price}, {vehicle.NumWheels}, {vehicle.MilesPerGallon}, {vehicle.NumOwners}");
                                break;
                        }
                    }
                }

                // Return true if all the data was saved to the file
                return true;
            }
            catch (Exception)
            {
                // Return false if an exeption was thrown
                return false;
            }
        } // End of WriteInventory

        /// <summary>
        /// Read the list of vehicles from a text file
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> ReadInventory()
        {
            // Declare and initialize
            string? line = "";
            string[] parts = [];
            string make = "", model = "";
            int year = 0, numWheels = 0, numOwners = 0 ;
            decimal price = 0m, milesPerGallon = 0m;
            // Specialty vehicle variables
            bool isConvertible = false, hasSideCar = false, hasBedCover = false;
            decimal trunkSize = 0m, seatHeight = 0m, bedSize = 0m;

            // Catch any exception with the stream reader
            try
            {
                // Check if the file exists
                if (File.Exists(_filePath))
                {
                    // Create a StreamReader to read the file
                    using (StreamReader reader = new StreamReader(_filePath))
                    {
                        // Read each line in the file
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Split the line on a comma-space
                            // Create a string array to put all the separate vehicle parts into
                            parts = line.Split(", ");

                            // Use the parts array to get the common data (make, model, year, price, numWheels)
                            make = parts[1];
                            model = parts[2];
                            // Parse the year of the vehicle
                            year = ParseInteger(parts[3]);
                            // Parse the price of the vehicle
                            price = ParseDecimal(parts[4]);
                            // Parse the numWheels of the vehicle
                            numWheels = ParseInteger(parts[5]);
                            // Parse the milesPerGallon of the vehicle
                            milesPerGallon = ParseDecimal(parts[6]);
                            // Parse the numOwners of the vehicle
                            numOwners = ParseInteger(parts[7]);

                            // Use the first piece of the data to create a switch for the specfic model
                            switch (parts[0])
                            {
                                case "Car":
                                    // Parse the convertible status for the car
                                    isConvertible = ParseBoolean(parts[8]);
                                    // Parse the trunk size
                                    trunkSize = ParseDecimal(parts[9]);
                                    // Create a new car using the read properties
                                    CarModel car = new CarModel(0, make, model, year, price, numWheels,
                                        milesPerGallon, numOwners, isConvertible, trunkSize);
                                    // Add the car to the inventory
                                    AddVehicleToInventory(car);
                                    break;

                                case "Motorcycle":
                                    // Parse the side car status for the motorcycle
                                    hasSideCar = ParseBoolean(parts[8]);
                                    // Parse the seat height
                                    seatHeight = ParseDecimal(parts[9]);
                                    // Create a new motocycle using the read properties
                                    MotorcycleModel motorcycle = new MotorcycleModel(0, make, model, year,
                                        price, numWheels, milesPerGallon, numOwners, hasSideCar, seatHeight);
                                    // Add the motorcycle to the inventory
                                    AddVehicleToInventory(motorcycle);
                                    break;

                                case "Pickup":
                                    // Parse the bed cover status for the pickup
                                    hasBedCover = ParseBoolean(parts[8]);
                                    // Parse the bed size
                                    bedSize = ParseDecimal(parts[9]);
                                    // Create a new pickup using the read properties
                                    PickupModel pickup = new PickupModel(0, make, model, year, price,
                                        numWheels, milesPerGallon, numOwners, hasBedCover, bedSize);
                                    // Add the pickup to the inventory
                                    AddVehicleToInventory(pickup);
                                    break;

                                default:
                                    // Create a new vehicle using the read properties
                                    VehicleModel vehicle = new VehicleModel(0, make, model, year, price,
                                        numWheels, milesPerGallon, numOwners);
                                    // Add the vehicle to the inventory
                                    AddVehicleToInventory(vehicle);
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Return the inventory list as is
                return _inventory;
            }
            // Return the inventory list
            return _inventory;
        } // End of ReadInventory

        /// <summary>
        /// Get the total of the users shopping cart and clear the cart
        /// </summary>
        /// <returns></returns>
        public decimal Checkout()
        {
            // Set up a variable to keep track of the carts total
            decimal total = 0m;

            // Loop through each vehicle in the shoppingCart
            foreach (VehicleModel vehicle in _shoppingCart)
            {
                // Add the vehicl price to the total variable
                total += vehicle.Price;
            }

            // Clear the cart
            _shoppingCart.Clear();

            // Return the carts total
            return total;
        } // End of Checkout

        
    }
}
