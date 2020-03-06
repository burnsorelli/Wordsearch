using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordSearch.EventHandlers
{
    class QuestionLabel
    {
        // When click on question remove any currently highlighted squares
        // Calls to populate_selected_controls - to connect selected_question
        // to button controls
        // Shows the selected_panel displaying buttons
        public static void question_Click(object sender, EventArgs e)
        {
            Label _questionLabel = (Label)sender;
            Methods.GameGridUse.RemoveHighlightFromSquare.Remove();
            foreach (var _question in TrackerVariables.TrackedVariables.QuestionList)
            {
                if (_question.QuestionLabel == _questionLabel)
                {
                    TrackerVariables.TrackedVariables.ChosenQuestion = _question;
                }
            }
            if (TrackerVariables.TrackedVariables.ChosenQuestion != null)
            {
                Styling.FormOutline.HelpPanel.Hide();
                Methods.PopulateHelpControls.GetControls();
                Styling.FormOutline.HelpPanel.Show();
            }
        }
    }
}
