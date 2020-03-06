using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridCreation
{
    class FillEmptySquares
    {
        // 6) fill_empty_squares() - for every square in the array if empty 
        //    call 6a) get_random_letter_group(square) 
        public static void Fill()
        {
            foreach (var _grid in TrackerVariables.TrackedVariables.FullGrid)
            {
                if (_grid.Letter == "")
                {
                    Methods.GameGridCreation.GetRandomLetterGroup.Get(_grid);
                }
            }
        }
    }
}
