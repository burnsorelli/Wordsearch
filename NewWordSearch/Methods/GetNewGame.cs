using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods
{
    class GetNewGame
    {
        // 1a) new_game() - calls game creation methods
        public static void NewGame()
        {
            Methods.ResetGameTrackers.ResetGame();
            Methods.GetGameQuestions.GetQuestions();
            Methods.Trackers.GetMinAnswerLength.GetLength();
            Methods.GameGridCreation.CreateLetterBoxes.CreateBoxes();
            Methods.GameGridCreation.AlterPicBoxSize.AlterSize();
            Methods.GameGridCreation.GetWordsForGrid.GetWords();
            Methods.GameGridCreation.FillEmptySquares.Fill();
            Styling.FormOutline.GetElements();
            Styling.ScoresPanel.GetElements();
            Methods.Trackers.GetTimer.Get();
            TrackerVariables.TrackedVariables.GameTimer.Start();
            Methods.GameGridCreation.CreateBitmap.Create();
        }
    }
}
