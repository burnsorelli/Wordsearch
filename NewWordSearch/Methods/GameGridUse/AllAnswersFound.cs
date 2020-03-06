using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordSearch.Methods.GameGridUse
{
    class AllAnswersFound
    {
        // When all answers found
        // Offers chance to play again if yes
        // increase round call increase_diffculty()
        // start new game new_game()
        // else game over
        public static void AllFound()
        {
            TrackerVariables.TrackedVariables.GameTimer.Stop();
            string _message = "Congratulations!!! You found all the answers." +
                " Your score is: " + TrackerVariables.TrackedVariables.GameScore;
            MessageBox.Show(_message);
            TrackerVariables.TrackedVariables.ContinuePlaying = false;
            string _replayMessage = "Would you like to play again?";
            string _title = "Continue?";
            MessageBoxButtons _buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(
                _replayMessage, _title, _buttons);
            if (result == DialogResult.Yes)
            {
                TrackerVariables.TrackedVariables.CurrentRound++;
                Methods.ChangeDifficulty.Increase();
                TrackerVariables.TrackedVariables.TimeLeft = GameStatus.Settings.TimePerRound;
                Methods.GetNewGame.NewGame();
            }
            else
            {
                //MessageBox.Close();
                // game over
            }
        }
    }
}
