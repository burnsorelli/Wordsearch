using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NewWordSearch.Methods.GameGridCreation
{
    class CreateBitmap
    {
        // Draws a grid of all objects in LetterSquare.full_grid
        // colour, text etc taken from object properties
        public static void Create()
        {
            Styling.GameGrid.GridPic =
                new Bitmap(Styling.GameGrid.HeightAndWidthLetterSquare *
                           Styling.GameGrid.LettersWide,
                           Styling.GameGrid.HeightAndWidthLetterSquare *
                           Styling.GameGrid.LettersHigh);
            Graphics _gridPicGraphics =
                Graphics.FromImage(Styling.GameGrid.GridPic);
            foreach (NonStaticClasses.LetterSquare _grid in TrackerVariables.TrackedVariables.FullGrid)
            {
                _gridPicGraphics.DrawRectangle(
                    Styling.GameGrid.GreyPen, _grid.LetterRectangle);
                _gridPicGraphics.FillRectangle(
                    _grid.BackgroundColour, _grid.LetterRectangle);
                StringFormat _sf = new StringFormat();
                _sf.LineAlignment = StringAlignment.Center;
                _sf.Alignment = StringAlignment.Center;
                _gridPicGraphics.DrawString(
                            _grid.Letter,
                            Styling.GameGrid.LetterFont,
                            _grid.TextColour,
                            _grid.LetterRectangle,
                            _sf);
            }
            Styling.GameGrid.GridPicBox.Image = Styling.GameGrid.GridPic;

        }
    }
}
