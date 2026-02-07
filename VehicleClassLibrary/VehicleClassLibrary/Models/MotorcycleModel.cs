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

namespace VehicleClassLibrary.Models
{
    public class MotorcycleModel : VehicleModel
    {
        // Class level properties
        public bool HasSideCar { get; set; }
        public decimal SeatHeight { get; set; } // In Inches

        /// <summary>
        /// Base constructor for the Motorcycle Model class
        /// </summary>
        public MotorcycleModel()
        {
            HasSideCar = false;
            SeatHeight = 0m;
        }

        /// <summary>
        /// Parameterized constructor for the Motorcycle Model class
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        /// <param name="hasSideCar"></param>
        /// <param name="seatHeight"></param>
        /// <param name="milesPerGallon"></param>
        public MotorcycleModel(int id, string make, string model, int year, decimal price, int numWheels, decimal milesPerGallon, int numOwners, bool hasSideCar, decimal seatHeight)
            : base(id, make, model, year, price, numWheels, milesPerGallon, numOwners)
        {
            HasSideCar = hasSideCar;
            SeatHeight = seatHeight;
        }

        public override string ToString()
        {
            // Use a ternary operator (in-line if) to get the sidecar string
            string sidecar = HasSideCar ? "with" : "without";

            // Print the motorcycle in the following format
            // 1: 2015 Yamaha Bolt with 2 wheels and a 44.1 inch seat with(out) a sidecar - $8000.00
            return $"{Id}: {Year} {Make} {Model} with {NumWheels} wheels and a {SeatHeight} inch seat {sidecar} a sidecar, gets {MilesPerGallon} MPG, and has had {NumOwners} owners - ${Price:C2}";
        }
    }
}
