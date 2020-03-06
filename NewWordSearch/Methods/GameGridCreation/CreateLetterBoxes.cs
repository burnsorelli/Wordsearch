using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridCreation
{
    class CreateLetterBoxes
    {
        // 4) create_letters_boxes() - creates all LetterSquare objects
        // and place into 2d array [col,row]
        public static void CreateBoxes()
        {
            NonStaticClasses.LetterSquare[,] _full_array = new NonStaticClasses.LetterSquare[
                Styling.GameGrid.LettersWide,
                Styling.GameGrid.LettersHigh];
            for (Int32 row = 0; row < Styling.GameGrid.LettersWide; row++)
            {
                for (Int32 col = 0; col < Styling.GameGrid.LettersHigh; col++)
                {
                    NonStaticClasses.LetterSquare tmp_new = new NonStaticClasses.LetterSquare(col + 1, row + 1);
                    _full_array[col, row] = tmp_new;
                }
            }
            TrackerVariables.TrackedVariables.FullGrid = _full_array;
        }
    }
}
