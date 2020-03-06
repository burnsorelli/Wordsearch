using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.EventHandlers
{
    class ShowAnswerButton
    {
        // On button click display chosen_question answer in selected_answer
        // text
        // Make score for this question 0

        public static void show_Click(object sender, EventArgs e)
        {
            Styling.HelpPanel.SelectedAnswer.Text = TrackerVariables.TrackedVariables.ChosenQuestion.QuestionAnswer;
            TrackerVariables.TrackedVariables.ChosenQuestion.Score = 0;

        }
    }
}
