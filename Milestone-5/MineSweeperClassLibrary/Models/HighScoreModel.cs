/*
 * Jacob Cutler
 * CST-250
 * 03/01/2026
 * Minesweeper Project
 * Milestone 5
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClassLibrary.Models
{
    public class HighScoreModel
    {
        public string Name { get; private set; }
        public int Score { get; private set; }
        public string Difficulty { get; private set; }
        public string TimeElapse { get; private set; }
        public DateTime Date { get; private set; }

        public HighScoreModel(string name, int score, string difficulty, string timeElapse, DateTime date)
        {
            Name = name;
            Score = score;
            Date = date;
            Difficulty = difficulty;
            TimeElapse = timeElapse;
            Date = date;
        }
    }
}
