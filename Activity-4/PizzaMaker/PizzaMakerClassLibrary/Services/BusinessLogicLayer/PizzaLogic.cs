/*
 * Jacob Cutler
 * CST-250
 * 02/22/2026
 * Pizza Maker
 * Activity 4
 */

using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaMakerClassLibrary.Services.BusinessLogicLayer
{
    public class PizzaLogic
    {
        // Declare class level variables
        private PizzaDAO _pizzaDAO;

        /// <summary>
        /// Default constructor for PizzaLogic
        /// </summary>
        public PizzaLogic()
        {
            // Intitialize the pizza DAO object
            _pizzaDAO = new PizzaDAO();
        }

        /// <summary>
        /// Add a new pizza to the current order
        /// </summary>
        /// <param name="newPizza"></param>
        /// <returns></returns>
        public (bool isValidPizza, int pizzaInOrder) AddPizzaToOrder(PizzaModel newPizza)
        {
            // Declare and intialize
            int pizzas = -1;

            // Check if the pizza order is valid
            if (newPizza.ClientName != null && newPizza.Ingredients != null && newPizza.Crust != null
                && newPizza.PizzaBoxColor != null && newPizza.DeliveryTime != null)
            {
                // Call the DAO AddPizzaToOrder
                pizzas = _pizzaDAO.AddPizzaToOrder(newPizza);
                // Return the pizza variable
                return (true, pizzas);
            }
            // If the order is not valid
            else
            {
                // Return invalid
                return (false, pizzas);
            }
        }

        /// <summary>
        /// Get the list of pizzas in the current order
        /// </summary>
        /// <returns></returns>
        public List<PizzaModel> GetPizzaOrder()
        {
            // Get and return GetPizzaOrder from the DAO
            return _pizzaDAO.GetPizzaOrder();
        }

        /// <summary>
        /// Write the pizza order to a text file
        /// </summary>
        /// <returns></returns>
        public bool WriteOrderToFile()
        {
            // Get and return WriteOrderToFile from the DAO
            return _pizzaDAO.WriteOrderToFile();
        }
    }
}
