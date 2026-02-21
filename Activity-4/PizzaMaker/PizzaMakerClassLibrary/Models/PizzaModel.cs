/*
 * Jacob Cutler
 * CST-250
 * 02/22/2026
 * Pizza Maker
 * Activity 4
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PizzaMakerClassLibrary.Models
{
    public class PizzaModel
    {
        public string ClientName { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> StrangeAddOns { get; set; }
        public string Crust { get; set; }
        public int SauceQty { get; set; }
        public int CheeseQty { get; set; }
        public DateTime DeliveryTime { get; set; }
        public Color PizzaBoxColor { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Default constructor for Pizza Model
        /// </summary>
        public PizzaModel()
        {
            // Declare the default properties
            ClientName = "Unknown";
            Ingredients = new List<string>();
            StrangeAddOns = new List<string>();
            Crust = "Unknown";
            SauceQty = 0;
            CheeseQty = 0;
            DeliveryTime = DateTime.Now;
            PizzaBoxColor = Color.White;
            Price = 15m;
        }
    }
}
