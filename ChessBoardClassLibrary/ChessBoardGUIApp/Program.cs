/*
 * Jacob Cutler
 * CST - 250
 * 02/08/2026
 * Chess Board Project
 * Activity 2
 */

using System;
using System.Windows.Forms;

namespace ChessBoardGUIApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmChessBoard());
        }
    }
}