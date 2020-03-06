using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods
{
    class GetFormInternalWidth
    {
        public static void GetWidth()
        {
            int _formInnerWidth = Styling.WholeForm.TheForm.ClientRectangle.Width;
            Styling.FormOutline.InternalPanelWidth = _formInnerWidth - (2 * Styling.FormOutline.AnchorX);
        }
    }
}
