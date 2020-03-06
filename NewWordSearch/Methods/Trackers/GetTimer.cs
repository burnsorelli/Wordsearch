using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.Trackers
{
    class GetTimer
    {
        // sets timer interval to 1 second and enables
        public static void Get()
        {
            TrackerVariables.TrackedVariables.GameTimer.Interval = 1000;
            TrackerVariables.TrackedVariables.GameTimer.Enabled = true;
            TrackerVariables.TrackedVariables.GameTimer.Tick += new EventHandler(EventHandlers.TimerTick.timer_Tick);
        }
    }
}
