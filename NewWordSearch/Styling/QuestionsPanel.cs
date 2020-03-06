using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace NewWordSearch.Styling
{
    class QuestionsPanel
    {
        //// Questions panel container
        //private static Questions Schosen_question; // should be public???
        //private static Color Squestion_panel_colour = Color.Khaki;

        //// variables for colours of questions panel
        private static Color _colourQuestionUnanswered = Color.White;
        private static Color _colourQuestionAnswered = Color.Gold;

        //// Questions settings
        private static Int32 _heightQuestions; // should be public???
        private static Int32 _widthQuestionPanel; // should be public???
        private static Int32 _marginQuestionBottom = 5;
        private static Int32 _marginQuestionLeft = 5;

        //// Questions settings
        //public static Int32 height_questions;
        //public static Int32 width_question_panel;
        //// Public getters -----------------------------------------------------

        //// Questions panel container
        //public static Questions chosen_question
        //{
        //    get => Schosen_question;
        //}
        //public static Color question_panel_colour
        //{
        //    get => Squestion_panel_colour;
        //}

        // variables for colours of questions panel
        public static Color ColourQuestionUnanswered
        {
            get => _colourQuestionUnanswered;
        }
        public static Color ColourQuestionAnswered
        {
            get => _colourQuestionAnswered;
        }

        //// Questions settings
        public static Int32 HeightQuestions
        {
            get => _heightQuestions;
            set => _heightQuestions = value;
        }
        public static int WidthQuestionPanel
        {
            get => _widthQuestionPanel;
            set => _widthQuestionPanel = value;
        }
        public static Int32 MarginQuestionBottom
        {
            get => _marginQuestionBottom;
        }
        public static Int32 MarginQuestionLeft
        {
            get => _marginQuestionLeft;
        }

        // 5b) add_questions(Form1) - create a label for each question and 
        // adds controls label added to question.label - so it can be changed
        // during game
        // SHOULD THIS HAPPEN WHEN THE QUESTION OBJECTS ARE CREATED?!?!?
        // SHOULD THIS HAPPEN OUTSIDE OF THIS METHOD TO BE MORE TRANSPARENT?!?
        public static void GetElements()
        {
            Methods.GetQuestionPanelWidth.GetWidth();
            Int32 _totalGridHeight =
                Styling.GameGrid.LettersHigh * Styling.GameGrid.HeightAndWidthLetterSquare;
            Int32 _totalMargins = Styling.QuestionsPanel.MarginQuestionBottom *
                                  (TrackerVariables.TrackedVariables.QuestionList.Count - 1);
            Styling.QuestionsPanel.HeightQuestions = (_totalGridHeight - _totalMargins) /
                                                     TrackerVariables.TrackedVariables.QuestionList.Count;
            Int32 _count = 1;
            foreach (NonStaticClasses.Questions _question in TrackerVariables.TrackedVariables.QuestionList)
            {
                Label _tmpLabel = new Label();
                _tmpLabel.AutoSize = false;
                _tmpLabel.BackColor = _question.Background_colour;
                _tmpLabel.Height = Styling.QuestionsPanel.HeightQuestions;
                _tmpLabel.Width = Styling.QuestionsPanel.WidthQuestionPanel - 2 * (Styling.QuestionsPanel.MarginQuestionLeft);
                _tmpLabel.Location =
                    new Point(
                        Styling.QuestionsPanel.MarginQuestionLeft,
                        (_count * (Styling.QuestionsPanel.HeightQuestions +
                                   Styling.QuestionsPanel.MarginQuestionBottom)) -
                                  (Styling.QuestionsPanel.HeightQuestions +
                                   Styling.QuestionsPanel.MarginQuestionBottom));
                _tmpLabel.Text = _question.QuestionText;
                _tmpLabel.Name = "lbl" + _count;
                _tmpLabel.Click += new System.EventHandler(EventHandlers.QuestionLabel.question_Click);
                Styling.FormOutline.QuestionPanel.Controls.Add(_tmpLabel);
                _question.QuestionLabel = _tmpLabel;
                TrackerVariables.TrackedVariables.LabelsPerRound.Add(_tmpLabel);
                _count++;
            }

        }
    }
}
