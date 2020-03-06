using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridUse
{
    class GetSquareColour
    {
        // WHEN TO TURN OFF THE SELECTED
        public static void GetColours(NonStaticClasses.LetterSquare _lettersquare)
        {
            if (_lettersquare.Highlight == true)
            {
                _lettersquare.BackgroundColour = Styling.GameGrid.ColourGridBoxHighlight;
                _lettersquare.TextColour = Styling.GameGrid.ColourGridTextHighlight;
            }
            else if (_lettersquare.Selected == true)
            {
                _lettersquare.BackgroundColour = Styling.GameGrid.ColourGridBoxSelected;
                _lettersquare.TextColour = Styling.GameGrid.ColourGridTextSelected;
            }
            else if (_lettersquare.Found)
            {
                _lettersquare.BackgroundColour = Styling.GameGrid.ColourGridBoxFound;
                _lettersquare.TextColour = Styling.GameGrid.ColourGridTextFound;
            }
            else
            {
                _lettersquare.BackgroundColour = Styling.GameGrid.ColourGridBox;
                _lettersquare.TextColour = Styling.GameGrid.ColourGridText;
            }
        }
    }
}
