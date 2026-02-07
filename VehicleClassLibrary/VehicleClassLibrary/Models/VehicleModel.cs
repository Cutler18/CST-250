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
    public class VehicleModel
    {
        // Class level properties
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int NumWheels { get; set; }
        public decimal MilesPerGallon { get; set; }
        public int NumOwners { get; set; }

        /// <summary>
        /// Default constructor for vehicle model
        /// </summary>
        public VehicleModel()
        {
            Id = 0;
            Make = "Unknown";
            Model = "Unknown";
            Year = 0;
            Price = 0m;
            NumWheels = 0;
            MilesPerGallon = 0m;
            NumOwners = 0;
        }

        /// <summary>
        /// Parameterized constructor for vehicle model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        public VehicleModel(int id, string make, string model, int year, decimal price, int numWheels, decimal milesPerGallon, int numOwners)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            NumWheels = numWheels;
            MilesPerGallon = milesPerGallon;
            NumOwners = numOwners;
        }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Print the vehicle in the following format
            // 1: 2013 Ford Fiesta with 4 wheels - $800.00
            return $"{Id}: {Year} {Make} {Model} with {NumWheels} wheels, gets {MilesPerGallon} MPG, and has had {NumOwners} owners - ${Price:C2}";
        }
    }
}
