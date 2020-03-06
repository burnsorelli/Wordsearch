using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordSearch.Methods
{
    class ResetGameTrackers
    {
        // removes all dynamically added labels at start of new round
        // clears lists labels_per_round and active_questions
        // removes dynamically created panels
        public static void ResetGame()
        {
            foreach (var _label in TrackerVariables.TrackedVariables.LabelsPerRound)
            {
                Styling.FormOutline.GamePanel.Controls.Remove(_label);
                Styling.FormOutline.QuestionPanel.Controls.Remove(_label);
            }
            TrackerVariables.TrackedVariables.LabelsPerRound.Clear(); // clear labels list
            TrackerVariables.TrackedVariables.ActiveQuestionList.Clear(); // clear question list
            foreach (var _panel in TrackerVariables.TrackedVariables.PanelList)
            {
                Styling.WholeForm.TheForm.Controls.Remove(_panel);
            }
            TrackerVariables.TrackedVariables.ContinuePlaying = true; // turns game on
            TrackerVariables.TrackedVariables.QuestionList.Clear(); 
            TrackerVariables.TrackedVariables.PanelList.Clear();
            Styling.FormOutline.GamePanel.Controls.Remove(
                Styling.GameGrid.GridPicBox);
            Methods.RemoveEventHandlers.RemoveAllHandlers(Styling.GameGrid.GridPicBox);
        }
    }
}
