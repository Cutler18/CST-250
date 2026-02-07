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
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.DataAccessLayer;

namespace VehicleClassLibrary.Services.BusinessLogicLayer
{
    public class StoreLogic
    {
        // Declare class level variables
        private StoreDAO _storeDAO;

        /// <summary>
        /// Default constructor for the Store Logic class
        /// </summary>
        public StoreLogic()
        {
            // Initialize the DAO
            _storeDAO = new StoreDAO();

        } // End of constructor

        /// <summary>
        /// Gets the inventory from the DAO
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetInventory()
        {
            // Call the DAO to get the inventory
            return _storeDAO.GetInventory();
        } // End of GetInventory method

        /// <summary>
        /// Get the shopping cart from the DAO
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetShoppingCart()
        {
            // Call the DAO to get the shipping cart   
            return _storeDAO.GetShoppingCart();
        } // End of GetShoppingCart method

        /// <summary>
        /// Get the AddVehicleToInventory method from the DAO
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public int AddVehicleToInventory(VehicleModel vehicle)
        {
            // Call the DAO to add the vehicle to inventory
            return _storeDAO.AddVehicleToInventory(vehicle);
        } // End of AddVehicleToInventory method

        /// <summary>
        /// Get the AddVehicleToCart method from the DAO
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int AddVehicleToCart(int vehicleId)
        {
            // Call the DAO to add the vehicle to the shopping cart
            return _storeDAO.AddVehicleToCart(vehicleId);
        } // End of AddVehicleToCart method

        /// <summary>
        /// Get the WriteInventory method from the DAO
        /// </summary>
        public void WriteInventory()
        {
            // Call the DAO to write the inventory
            _storeDAO.WriteInventory();
        } // End of WriteInventory method

        /// <summary>
        /// Get the ReadInventory method from the DAO
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> ReadInventory()
        {
            // Call and return the inventory from a list pulled from the DAO
            return _storeDAO.ReadInventory();
        } // End of ReadInventory method

        /// <summary>
        /// Get the Checkout method from the DAO
        /// </summary>
        /// <returns></returns>
        public decimal Checkout()
        {
            // Call the DAO to perform the checkout operation
            return _storeDAO.Checkout();
        } // End of Checkout method
    }
}
