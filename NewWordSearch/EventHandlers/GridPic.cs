using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordSearch.EventHandlers
{
    class GridPic
    {
        // Click event on grid
        // find grid clicked and toggle selected
        // if turned on toggle other boxes, check if answer correct
        public static void grid_Click(object sender, EventArgs e)
        {
            if (TrackerVariables.TrackedVariables.ContinuePlaying == true)
            {
                Int32 _col;
                Int32 _row;
                NonStaticClasses.LetterSquare _tmpGrid;
                var mouseEventArgs = e as MouseEventArgs;
                if (mouseEventArgs != null)
                {
                    _col = mouseEventArgs.X / Styling.GameGrid.HeightAndWidthLetterSquare;
                    _row = mouseEventArgs.Y / Styling.GameGrid.HeightAndWidthLetterSquare;
                    _tmpGrid = TrackerVariables.TrackedVariables.FullGrid[_col, _row];

                    if (_tmpGrid.Selected == false)
                    {
                        _tmpGrid.Selected = true;
                        //cv.get_last_clicked();
                        Methods.GameGridUse.CheckToResetGridColours.ResetColours(TrackerVariables.TrackedVariables.FullGrid[_col, _row]);
                        if (TrackerVariables.TrackedVariables.SelectedLetters.Count > 1)
                        {
                            Methods.GameGridUse.AutoSelectLetters.AutoSelect();
                        }
                    }
                    else
                    {
                        _tmpGrid.Selected = false;
                        //cv.get_last_clicked();
                    }

                    if (TrackerVariables.TrackedVariables.SelectedLetters.Count() >= TrackerVariables.TrackedVariables.ShortestAnswerLength)
                    {
                        Methods.GameGridUse.CheckIfCorrect.Check();
                    }
                    Methods.GameGridUse.RemoveHighlightFromSquare.Remove();
                    // NOT BEST PLACE FOR THIS?
                    Methods.GameGridCreation.CreateBitmap.Create();
                }
            }

        }
    }
}
