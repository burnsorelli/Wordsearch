using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NewWordSearch.Methods.GameGridCreation
{
    class AlterPicBoxSize
    {
        // Changes size of picture box and adds as control
        public static void AlterSize()
        {
            Styling.GameGrid.GridPicBox.Size = new Size(Styling.GameGrid.HeightAndWidthLetterSquare * Styling.GameGrid.LettersWide,
                                                        Styling.GameGrid.HeightAndWidthLetterSquare * Styling.GameGrid.LettersHigh);
            Styling.GameGrid.GridPicBox.Location = new Point(Styling.FormOutline.GamePanelPaddingLeft,
                                                             Styling.FormOutline.GamePanelPaddingTop);
            Styling.GameGrid.GridPicBox.Click += new EventHandler(EventHandlers.GridPic.grid_Click);

            Styling.FormOutline.GamePanel.Controls.Add(Styling.GameGrid.GridPicBox);
        }
    }
}
