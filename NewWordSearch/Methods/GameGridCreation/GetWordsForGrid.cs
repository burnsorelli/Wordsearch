using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridCreation
{
    class GetWordsForGrid
    {
        // 5) get_all_words(Form1) - for each question use 5a) 
        // find_start_point(obj question)
        // after all questions call 5b) add_questions(Form1)
        public static void GetWords()
        {
            foreach (NonStaticClasses.Questions _question in TrackerVariables.TrackedVariables.QuestionList)
            {
                Methods.GameGridCreation.GetWordStartPoint.FindStart(_question);
            }
            Styling.QuestionsPanel.GetElements();
        }
    }
}
