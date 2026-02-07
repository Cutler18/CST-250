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
    public class PickupModel : VehicleModel
    {
        // Class level properties
        public bool HasBedCover { get; set; }
        public decimal BedSize { get; set; }

        /// <summary>
        /// Base constructor for the Pickup Model class
        /// </summary>
        public PickupModel()
        {
            HasBedCover = false;
            BedSize = 0m;
        }

        /// <summary>
        /// Parameterized constructor for the Pickup Model class
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        /// <param name="hasBedCover"></param>
        /// <param name="bedSize"></param>
        public PickupModel(int id, string make, string model, int year, decimal price, int numWheels, decimal milesPerGallon, int numOwners, bool hasBedCover, decimal bedSize)
            : base(id, make, model, year, price, numWheels, milesPerGallon, numOwners)
        {
            HasBedCover = hasBedCover;
            BedSize = bedSize;
        }

        public override string ToString()
        {
            // Use a ternary operator (in-line if) to get the convertible string
            string hasBedCover = HasBedCover ? "with" : "without";

            // Print the car in the following format
            // 1: 2019 Dodge Cummins with 4 wheels and a 8.3 cubic bed trunk with(out) a bed cover - $47000.00
            return $"{Id}: {Year} {Make} {Model} with {NumWheels} wheels and a {BedSize} cubic foot trunk {hasBedCover} a bed cover, gets {MilesPerGallon} MPG, and has had {NumOwners} owners - ${Price:C2}";
        }
    }
}
