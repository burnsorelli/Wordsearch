using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NewWordSearch.Styling
{
    class HelpPanel
    {
        public static Label SelectedQuestionLabel = new Label();
        //// get question label
        public static Button ShowAnswerButton = new Button();
        //// get show answer button
        public static Label SelectedAnswer = new Label();
        //// get show answer label
        public static Button RevealLocationButton = new Button();
        //// get reveal location button
        //// Bottom panel - chosen question and reveal buttons ------------------
        //// chosen question
        private static Size _questionLabelSize = new Size(200, 50);
        private static Point _questionLabelLocation = new Point(5, 5);
        private static Color _questionColour = Color.Gainsboro;
        //// show answer button
        private static string _showAnswerText = "Show answer: ";
        private static Size _showAnswerSize = new Size(90, 20);
        private static Point _showAnswerLocation = new Point(225, 5);
        //// selected answer textbox
        private static Size _selectedAnswerSize = new Size(90, 20);
        private static Point _selectedAnswerLocation = new Point(225, 30);
        private static Color _selectedAnswerColour = Color.White;
        //// reveal location button
        private static string _revealLocationText = "Show location: ";
        private static Size _revealLocationSize = new Size(120, 45);
        private static Point _revealLocationLocation = new Point(320, 5);



        //// Public getters -----------------------------------------------------
        //// chosen question
        public static Size QuestionLabelSize
        {
            get => _questionLabelSize;
        }

        public static Point QuestionLabelLocation
        {
            get => _questionLabelLocation;
        }

        public static Color QuestionColour
        {
            get => _questionColour;
        }
        //// show answer button
        public static string ShowAnswerText
        {
            get => _showAnswerText;
        }

        public static Size ShowAnswerSize
        {
            get => _showAnswerSize;
        }

        public static Point ShowAnswerLocation
        {
            get => _showAnswerLocation;
        }
        //// selected answer textbox


        public static Size SelectedAnswerSize
        {
            get => _selectedAnswerSize;
        }

        public static Point SelectedAnswerLocation
        {
            get => _selectedAnswerLocation;
        }

        public static Color SelectedAnswerColour
        {
            get => _selectedAnswerColour;
        }
        // reveal location button


        public static string RevealLocationText
        {
            get => _revealLocationText;
        }

        public static Size RevealLocationSize
        {
            get => _revealLocationSize;
        }

        public static Point RevealLocationLocation
        {
            get => _revealLocationLocation;
        }

        //// Functions ----------------------------------------------------------

        ////-------- 2) get_selected_controls - creates question details box ----
        public static void GetElements()

        {
            // get question label
            SelectedQuestionLabel.Location = QuestionLabelLocation;
            SelectedQuestionLabel.Size = QuestionLabelSize;
            SelectedQuestionLabel.BackColor = QuestionColour;
            Styling.FormOutline.HelpPanel.Controls.Add(SelectedQuestionLabel);

            // get show answer button
            ShowAnswerButton.Text = ShowAnswerText;
            ShowAnswerButton.Size = ShowAnswerSize;
            ShowAnswerButton.Location = ShowAnswerLocation;
            ShowAnswerButton.Click +=
                new System.EventHandler(EventHandlers.ShowAnswerButton.show_Click);
            Styling.FormOutline.HelpPanel.Controls.Add(ShowAnswerButton);

            // get show answer label
            SelectedAnswer.Size = SelectedAnswerSize;
            SelectedAnswer.Location = SelectedAnswerLocation;
            SelectedAnswer.BackColor = SelectedAnswerColour;
            Styling.FormOutline.HelpPanel.Controls.Add(SelectedAnswer);

            // get reveal location button
            RevealLocationButton.Text = RevealLocationText;
            RevealLocationButton.Size = RevealLocationSize;
            RevealLocationButton.Location = RevealLocationLocation;
            RevealLocationButton.Click +=
                new System.EventHandler(EventHandlers.RevealLocationButton.reveal_Click);
            Styling.FormOutline.HelpPanel.Controls.Add(RevealLocationButton);

        }
    }
}
