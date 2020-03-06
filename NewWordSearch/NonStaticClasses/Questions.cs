using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace NewWordSearch.NonStaticClasses
{
    class Questions
    {
        public Int32 Score;
        public string QuestionText;
        public string QuestionAnswer;
        private bool _found;
        public Int32 QuestionNumber;
        //public static List<Questions> question_list = new List<Questions>();
        private Color _backgroundColour;
        public Label QuestionLabel = new Label();
        private bool _selected;

        ////public static Int32 min_answer_length;
        ////private Int32 count = 1;

        public Questions(string a_question_text,
                         string a_question_answer,
                         int a_count)
        {
            QuestionText = a_question_text;
            QuestionAnswer = a_question_answer;
            _found = false;
            QuestionNumber = a_count;
            _backgroundColour = Styling.QuestionsPanel.ColourQuestionUnanswered; 
            Score = GameStatus.Settings.PointsPerQuestion;
            //count++;
        }

        public bool Found
        {
            get
            {
                return _found;
            }
            set
            {
                if (!this.Found)
                {
                    this._backgroundColour = Styling.QuestionsPanel.ColourQuestionAnswered;
                    this._found = true;
                }
            }
        }

        public Color Background_colour
        {
            get
            {
                return _backgroundColour;
            }
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (_selected == false)
                {
                    _selected = true;

                }
                else
                {
                    _selected = false;
                }
            }
        }
    }
}
