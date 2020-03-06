using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridUse
{
    class CheckToResetGridColours
    {
        // checks all currently selected squares to makes sures they are in 
        // the same row, col or diagonal as the currently clicked square, 
        // if they are not they are reset back to original style
        // PROBLEM AS THIS IS HARDCODED!?!?
        // if they are then they are added to temp list and this list 
        // becomes the selected_list
        // NEW Way - only compare with the last clicked square
        // if in same row, column or diagonal then this is the only 
        // acceptible grids any selected_list not in that row deselected
        public static void ResetColours(NonStaticClasses.LetterSquare _grid)
        {
            double tmp_x_direction;
            double tmp_y_direction;
            double tmp_gradient;


            if (TrackerVariables.TrackedVariables.SelectedLetters.Count > 1)
            {
                // get most recent last click now
                // cv.get_last_clicked();
                tmp_x_direction = TrackerVariables.TrackedVariables.LastClickedLetter.Col - _grid.Col;
                tmp_y_direction = TrackerVariables.TrackedVariables.LastClickedLetter.Row - _grid.Row;
                if (tmp_x_direction == 0)
                {
                    // Vertical
                    foreach (NonStaticClasses.LetterSquare _grid2 in TrackerVariables.TrackedVariables.SelectedLetters.ToList())
                    {
                        //if ((grid.col - test_grid.col != 0) && 
                        //    grid.found == false)
                        if (_grid2.Col - _grid.Col != 0)
                        {
                            _grid2.Selected = false;
                        }
                    }
                }
                else if (tmp_y_direction == 0)
                {
                    // Horizontal
                    foreach (NonStaticClasses.LetterSquare _grid3 in TrackerVariables.TrackedVariables.SelectedLetters.ToList())
                    {
                        if ((_grid3.Row - _grid.Row != 0) &&
                            _grid3.Found == false)
                        {
                            _grid3.Selected = false;
                        }
                    }
                }
                else
                {
                    tmp_gradient = tmp_x_direction / tmp_y_direction;
                    if (tmp_gradient == 1 || tmp_gradient == -1)
                    {
                        // Diagonal down?
                        foreach (NonStaticClasses.LetterSquare _grid4 in TrackerVariables.TrackedVariables.SelectedLetters.ToList())
                        {
                            if (_grid4.Col == _grid.Col &&
                                _grid4.Row == _grid.Row)
                            {
                                // Ignore if its comparing itself
                                break;
                            }
                            else if (_grid4.Col - _grid.Col == 0 ^
                                     _grid4.Row - _grid.Row == 0)
                            {
                                // if in same row or same column (NOT BOTH)
                                _grid4.Selected = false;
                            }
                            // Convert to double as will not calculate decimals
                            // otherwise
                            else if (
                                (Convert.ToDouble(_grid4.Col) - _grid.Col) /
                                (_grid4.Row - _grid.Row) != tmp_gradient)
                            {
                                // if not in diagonal
                                _grid4.Selected = false;
                            }
                        }
                    }
                    else
                    {
                        // Not in same line, diag or column
                        foreach (NonStaticClasses.LetterSquare _grid5 in TrackerVariables.TrackedVariables.SelectedLetters.ToList())
                        {
                            _grid5.Selected = false;
                            // does this turn them all off including the 
                            // clicked one
                        }
                    }
                }
            }
        }
    }
}
