using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NewWordSearch.Styling
{
    class WholeForm
    {
        //// Whole form settings ------------------------------------------------
        public static Form TheForm;
        private static int _widthForm = 800;
        private static int _heightForm = 600;
        ////private static int form_border = 5;
        private static Size _formSize = new Size(_widthForm, _heightForm);
        ////private static int inner_form_width;

        //// Form styling
        public static Size FormSize
        {
            get => _formSize;
        }

        ////-------- 1) form_attrs - sets size of form --------------------------
        public static void GetElements()
        {
            Styling.WholeForm.TheForm.Size = Styling.WholeForm.FormSize;
            //inner_form_width = tmp_form.ClientRectangle.Width;
        }

    }
}
