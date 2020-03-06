using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.Trackers
{
    class GetMinAnswerLength
    {
        // 3) get_min_answer_length() - gets shortest answer length to 
        // trigger check_correct
        public static void GetLength()
        {
            Int32 min = 0;
            foreach (NonStaticClasses.Questions _question in TrackerVariables.TrackedVariables.QuestionList)
            {
                if (min == 0 || _question.QuestionAnswer.Length < min)
                {
                    min = _question.QuestionAnswer.Length;
                }
            }
            TrackerVariables.TrackedVariables.ShortestAnswerLength = min;
        }
    }
}
