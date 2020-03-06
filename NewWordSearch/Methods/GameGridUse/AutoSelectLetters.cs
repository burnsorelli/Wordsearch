using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridUse
{
    class AutoSelectLetters
    {
        // Turn on all the grids between the clicked grid and the others
        // in same row, column or diag
        public static void AutoSelect()
        {
            // Find the highest and lowest row or col first of last clicked
            // and one before
            NonStaticClasses.LetterSquare _firstClick = TrackerVariables.TrackedVariables.SelectedLetters[
                                       TrackerVariables.TrackedVariables.SelectedLetters.Count - 2];
            NonStaticClasses.LetterSquare _secondClick = TrackerVariables.TrackedVariables.SelectedLetters[
                                        TrackerVariables.TrackedVariables.SelectedLetters.Count - 1];

            Int32 _startX = TrackerVariables.TrackedVariables.SelectedLetters.Min(x => x.Col) - 1;
            Int32 _endX = TrackerVariables.TrackedVariables.SelectedLetters.Max(x => x.Col) - 1;
            Int32 _startY = TrackerVariables.TrackedVariables.SelectedLetters.Min(y => y.Row - 1);
            Int32 _endY = TrackerVariables.TrackedVariables.SelectedLetters.Max(y => y.Row - 1);

            if (_startX == _endX) // Vertical 
            {
                for (int _start = _startY + 1; _start < _endY; _start++)
                {
                    if (TrackerVariables.TrackedVariables.FullGrid[_startX, _start].Selected ==
                            false)
                    {
                        TrackerVariables.TrackedVariables.FullGrid[_startX, _start].Selected =
                            false;
                    }
                }
            }
            else if (_startY == _endY) // Horizontal
            {
                for (int _start = _startX + 1; _start < _endX; _start++)
                {
                    if (TrackerVariables.TrackedVariables.FullGrid[_start, _startY].Selected ==
                            false)
                    {
                        TrackerVariables.TrackedVariables.FullGrid[_start, _startY].Selected =
                            true;
                    }
                }
            }
            else
            {
                // Diagonal
                // Get gradient
                // IS THIS CALCULATING A DECIMAL??
                float _gradient = (_firstClick.Col - _secondClick.Col) /
                                 (_firstClick.Row - _secondClick.Row);
                if (_gradient == 1) // Diagonally down
                {
                    for (int _increase = 1;
                         _increase < _endX - _startX;
                         _increase++)
                    {
                        if (TrackerVariables.TrackedVariables.FullGrid[(_startX + _increase),
                            (_startY + _increase)].Selected == false)
                        {
                            TrackerVariables.TrackedVariables.FullGrid[(_startX + _increase),
                                (_startY + _increase)].Selected = true;
                        }
                    }
                }
                else
                {
                    for (int _increase = 1;
                         _increase < _endX - _startX;
                         _increase++)
                    {
                        if (TrackerVariables.TrackedVariables.FullGrid[(_startX + _increase),
                            (_endY - _increase)].Selected == false)
                        {
                            TrackerVariables.TrackedVariables.FullGrid[(_startX + _increase),
                                (_endY - _increase)].Selected = true;
                        }
                    }
                }
            }
            // Remove the last clicked square from list and add again 
            // so it is the last clicked
            TrackerVariables.TrackedVariables.SelectedLetters.Remove(_secondClick);
            TrackerVariables.TrackedVariables.SelectedLetters.Add(_secondClick);

        }
    }
}
