using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordSearch.EventHandlers
{
    class TimerTick
    {
        // Every second time_left reduced by 1
        // If hits zero game is ended
        public static void timer_Tick(object sender, EventArgs e)
        {
            if (TrackerVariables.TrackedVariables.TimeLeft > 0)
            {
                TrackerVariables.TrackedVariables.TimeLeft -= 1;
                Styling.ScoresPanel.TimerLabel.Text = Convert.ToString(TrackerVariables.TrackedVariables.TimeLeft);
                
            }
            else
            {
                // game over; stop time, stop play ability, show message
                TrackerVariables.TrackedVariables.GameTimer.Stop();
                TrackerVariables.TrackedVariables.ContinuePlaying = false;
                string message = "Out of Time";
                MessageBox.Show(message);
            }
        }
    }
}
