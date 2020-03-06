using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridUse
{
    class CheckIfAllCorrect
    {
        public static void Check()
        {
            if (TrackerVariables.TrackedVariables.CorrectQuestions == GameStatus.Settings.CurrentQuestionsPerPuzzle)
            {
                Methods.GameGridUse.AllAnswersFound.AllFound();
            }
            //// Check to see if all answers are found 
            //   if (GameTracker.correct_questions ==
            //       GameSettings.current_questions_per_puzzle)
            //   {
            //       all_answers_found();
        }
    }
}

