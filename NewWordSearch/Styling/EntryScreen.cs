using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordSearch.Styling
{
    class EntryScreen
    {
        private static MessageBoxButtons _boxButtons = MessageBoxButtons.YesNo;
        private static string _messageString = "Click 'OK' to begin game";
        private static string _title = "Start";

        public static MessageBoxButtons BoxButtons
        {
            get => _boxButtons;
        }
        public static string MessageString
        {
            get => _messageString;
        }
        public static string Title
        {
            get => _title;
        }
    }
}
