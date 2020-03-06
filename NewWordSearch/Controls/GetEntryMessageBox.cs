using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordSearch.Controls
{
    class GetEntryMessageBox
    {

        public static bool GetMBox()
        {
            var _result = MessageBox.Show(
                Styling.EntryScreen.MessageString,
                Styling.EntryScreen.Title,
                Styling.EntryScreen.BoxButtons
                );
            if(_result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
