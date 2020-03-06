using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods
{
    class ChangeDifficulty
    {
        // Increases difficulty each round by adding another question
        // every 5 rounds increases size of puzzle
        public static void Increase()
        {
            if (Convert.ToDouble(TrackerVariables.TrackedVariables.CurrentRound) % 5 == 0)
            {
                Styling.GameGrid.LettersHigh += GameStatus.Settings.IncreaseHeight;
                // increase size of puzzle
                Styling.GameGrid.LettersWide += GameStatus.Settings.IncreaseWidth;
            }
            //time_per_round -= 10; // decrease time
            GameStatus.Settings.CurrentQuestionsPerPuzzle += GameStatus.Settings.DifficultyIncrease;
            // increase number of words in puzzle
        }
    }
}
