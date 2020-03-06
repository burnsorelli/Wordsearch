using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.EventHandlers
{
    class RevealLocationButton
    {
        // Go through grid, if they have chosen_question question number in
        // their list of 
        // Part_of_question_number answers - highlight those grids
        // Call create_bitmap_grid() to update picture
        public static void reveal_Click(object sender, EventArgs e)
        {
            foreach (var _grid in TrackerVariables.TrackedVariables.FullGrid)
            {
                if (_grid.PartOfQuestionNumber.Contains(
                    TrackerVariables.TrackedVariables.ChosenQuestion.QuestionNumber))
                {
                    _grid.Highlight = true;
                }
            }
            Methods.GameGridCreation.CreateBitmap.Create();
        }
    }
}
