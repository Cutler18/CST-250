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
    public class CarModel : VehicleModel
    {
        // Class level properties
        public bool IsConvertible { get; set; }
        public decimal TrunkSize { get; set; }

        /// <summary>
        /// Base constructor for the Car Model class
        /// </summary>
        public CarModel()
        {
            IsConvertible = false;
            TrunkSize = 0m;
        }

        /// <summary>
        /// Parameterized constructor for the Car Model class
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        /// <param name="isConvertible"></param>
        /// <param name="trunkSize"></param>
        public CarModel(int id, string make, string model, int year, decimal price, int numWheels, decimal milesPerGallon, int numOwners, bool isConvertible, decimal trunkSize)
            : base(id, make, model, year, price, numWheels, milesPerGallon, numOwners)
        {
            IsConvertible = isConvertible;
            TrunkSize = trunkSize;
        }

        public override string ToString()
        {
            // Use a ternary operator (in-line if) to get the convertible string
            string convertible = IsConvertible ? "with" : "without";

            // Print the car in the following format
            // 1: 2019 Jeep Wrangler with 4 wheels and a 14.7 cubic foot trunk with(out) a convertible top - $27000.00
            return $"{Id}: {Year} {Make} {Model} with {NumWheels} wheels and a {TrunkSize} cubic foot trunk {convertible} a convertible top, gets {MilesPerGallon} MPG, and has had {NumOwners} owners - ${Price:C2}";
        }
    }
}
