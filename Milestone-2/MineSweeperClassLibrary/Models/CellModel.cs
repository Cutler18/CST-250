using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClassLibrary.Models
{
    public class CellModel
    {
        // Class level properties
        public int Row { get; private set; }
        public int Column { get; private set; }
        public bool IsMine { get; set; }
        public bool IsRevealed { get; set; }
        public bool IsFlagged { get; set; }
        public bool IsReward { get; set; }
        public bool IsDiffused { get; set; }

        /// <summary>
        /// Default constructor for CellModel
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public CellModel(int row, int column)
        {
            // Initialize the properties for the model
            Row = row;
            Column = column;

            // Set the default value of the properties
            IsMine = false;
            IsRevealed = false;
            IsFlagged = false;
            IsReward = false;
            IsDiffused = false;
        }
    }
}
