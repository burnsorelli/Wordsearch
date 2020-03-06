using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods
{
    class GetGameQuestions
    {
        // 2) get_questions() - gets question objects from question_list 
        // dictionary
        // randomly gets number questions from list
        // deletes from list so not repeated in future rounds
        // NEEDS A WAY OF NOT RUNNING OUT OF QUESTIONS TO CHOOSE FROM
        public static void GetQuestions()
        {
            for (int questions = 0;
                questions < GameStatus.Settings.CurrentQuestionsPerPuzzle;
                questions++)
            {
                while (true)
                {
                    Int32 element =
                        GameStatus.Settings.Rnd.Next(TrackerVariables.TrackedVariables.QuestionListBank.Count);
                    var _randomQuestion =
                        TrackerVariables.TrackedVariables.QuestionListBank.ElementAt(element);
                    // if too big for grid choose again
                    if (_randomQuestion.Value.Length <=
                            Styling.GameGrid.LettersWide ||
                        _randomQuestion.Value.Length <=
                            Styling.GameGrid.LettersHigh)
                    {
                        TrackerVariables.TrackedVariables.ActiveQuestionList.Add(_randomQuestion.Key, _randomQuestion.Value);
                        TrackerVariables.TrackedVariables.QuestionListBank.Remove(_randomQuestion.Key);
                        break;
                    }
                }
            }
            int _count = 1;
            foreach (var _value in TrackerVariables.TrackedVariables.ActiveQuestionList)
            {
                NonStaticClasses.Questions _tmpNew = new NonStaticClasses.Questions(
                                            _value.Key,
                                            _value.Value,
                                            _count);
                TrackerVariables.TrackedVariables.QuestionList.Add(_tmpNew);
                _count++;
            }
            TrackerVariables.TrackedVariables.CorrectQuestions = GameStatus.Settings.AnswersCorrectStartRound;
            
        }
    }
}
