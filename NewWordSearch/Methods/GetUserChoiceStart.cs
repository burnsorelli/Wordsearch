using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordSearch.Methods
{
    class GetUserChoiceStart
    {
        
        public static void GetChoice()
        {
            bool _startGame = Controls.GetEntryMessageBox.GetMBox();
            if (_startGame)
            {
                Methods.GetNewGame.NewGame();
            }
            else
            {
                Application.Exit();
            }
        }
        

    }
}
