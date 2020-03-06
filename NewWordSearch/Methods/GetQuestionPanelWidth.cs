using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods
{
    class GetQuestionPanelWidth
    {
        public static void GetWidth()
        {
            Styling.QuestionsPanel.WidthQuestionPanel = Styling.FormOutline.InternalPanelWidth -
                                                        2 * Styling.QuestionsPanel.MarginQuestionLeft -
                                                        (Styling.GameGrid.HeightAndWidthLetterSquare * Styling.GameGrid.LettersWide);
        }
    }
}
