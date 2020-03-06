using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods
{
    class GetScoreBoxWidth
    {
        // Calculated how far across x axis each box in the scores panel 
        // should be 
        public static Int32 GetWidths(int _titleCount, int _scoreCount)
        {
            int result = Styling.ScoresPanel.TitleMargin +
                         (_titleCount * (Styling.ScoresPanel.TitleWidth +
                         Styling.ScoresPanel.ScoreMargin)) +
                         _scoreCount * (Styling.ScoresPanel.ScoreWidth +
                         Styling.ScoresPanel.TitleMargin);
            return result;
        }
    }
}
