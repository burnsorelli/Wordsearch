using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods
{
    class PopulateHelpControls
    {
        public static void GetControls()
        {
            //TrackerVariables.TrackedVariables.SelectedQuestion.Text = TrackerVariables.TrackedVariables.ChosenQuestion.QuestionText;
            Styling.HelpPanel.SelectedQuestionLabel.Text = TrackerVariables.TrackedVariables.ChosenQuestion.QuestionText;
            Styling.HelpPanel.SelectedAnswer.Text = "";
        }
    }
}
