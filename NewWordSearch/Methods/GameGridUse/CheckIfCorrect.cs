using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridUse
{
    class CheckIfCorrect
    {
        public static void Check()
        {
            //var _tmpTestList = TrackerVariables.TrackedVariables.QuestionList;
            bool _allAnswers = true;
            bool _allSameAnswer = true;
            Int32 _answer = 0;

            foreach (NonStaticClasses.LetterSquare _grid in TrackerVariables.TrackedVariables.SelectedLetters)
            {
                // checks if all the selected squares contain part of answer
                if (_grid.IsPartOfAnswer == false)
                {
                    _allAnswers = false;
                }
            }
            if (_allAnswers)
            {
                // Find a square with only one answer to check against
                for (int _count = 0;
                     _count < TrackerVariables.TrackedVariables.SelectedLetters.Count;
                     _count++)
                {
                    if (
                        TrackerVariables.TrackedVariables.SelectedLetters[_count].PartOfQuestionNumber.Count == 1)
                    {
                        _answer = TrackerVariables.TrackedVariables.SelectedLetters[_count].PartOfQuestionNumber[0];
                        break;
                    }
                }

                foreach (NonStaticClasses.LetterSquare _grid in TrackerVariables.TrackedVariables.SelectedLetters)
                {
                    // Checks if all the squares belong to the same answer
                    if (!_grid.PartOfQuestionNumber.Contains(_answer))
                    {
                        _allSameAnswer = false;
                    }
                }
            }
            if (_allSameAnswer && _allAnswers)
            {
                foreach (NonStaticClasses.Questions _question in TrackerVariables.TrackedVariables.QuestionList)
                {
                    if (_question.QuestionNumber == _answer &&
                        _question.QuestionAnswer.Length ==
                            TrackerVariables.TrackedVariables.SelectedLetters.Count() &&
                        _question.Found == false)
                    {
                        _question.Found = true;
                        _question.QuestionLabel.BackColor = _question.Background_colour;
                        foreach (NonStaticClasses.LetterSquare _grid in
                                 TrackerVariables.TrackedVariables.SelectedLetters.ToList())
                        {
                            _grid.Found = true;
                            _grid.Selected = true;
                        }
                        TrackerVariables.TrackedVariables.GameScore += _question.Score;
                        // increase score if correct
                        Styling.ScoresPanel.ScoreLabel.Text = Convert.ToString(TrackerVariables.TrackedVariables.GameScore);
                        // update scores
                        TrackerVariables.TrackedVariables.CorrectQuestions += 1;
                        // increase number of correct answers
                        // check out whether all answers are found
                        Methods.GameGridCreation.CreateBitmap.Create();
                    }
                }

            }

            Methods.GameGridUse.CheckIfAllCorrect.Check();
            //    // Check to see if all answers are found 
            //    // MOVED TO CHECKALLCORRECT.CS
            //    if (GameTracker.correct_questions ==
            //        GameSettings.current_questions_per_puzzle)
            //    {
            //        all_answers_found();
            //    }
            //}
        }
    }
}
