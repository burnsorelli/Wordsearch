using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.Trackers
{
    class GetLastClicked
    {
        // Only called from LetterSquare when grid is selected or not
        // Might not be needed
        public static void GetLast()
        {
            var _letterList = TrackerVariables.TrackedVariables.SelectedLetters;
            //var _lastLetter = TrackerVariables.TrackedVariables.LastClickedLetter;
            if (_letterList.Count > 1)
            {
                TrackerVariables.TrackedVariables.LastClickedLetter = _letterList[_letterList.Count - 2];
            }
            else if (_letterList.Count == 1)
            {
                TrackerVariables.TrackedVariables.LastClickedLetter = _letterList[0];
            }
            else
            {
                TrackerVariables.TrackedVariables.LastClickedLetter = null;
            }
        }
    }
}
