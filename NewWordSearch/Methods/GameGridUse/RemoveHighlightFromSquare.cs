using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridUse
{
    class RemoveHighlightFromSquare
    {
        // Goes through grid if any are highlighted then they are turned off
        // calles create_bitmap_grid to update picture display
        public static void Remove()
        {
            foreach (var _grid in TrackerVariables.TrackedVariables.FullGrid)
            {
                if (_grid.Highlight == true)
                {
                    _grid.Highlight = false;
                }
            }
            Methods.GameGridCreation.CreateBitmap.Create();
        }
    }
}
