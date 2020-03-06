using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NewWordSearch.Styling
{
    class FormOutline
    {
        //// panel variables - general ------------------------------------------
        private static Int32 _anchorX = 50;
        private static Int32 _anchorY = 10;
        //private static int Spanel_width = width_form;
        private static int _marginBetweenPanels = 0;
        private static int _internalPanelWidth;

        //// Top panel - scores, timer etc --------------------------------------
        public static Panel ScoresPanel = new Panel();
        private static Color _scorePanelColour = Color.LightBlue;
        private static Int32 _scoresPanelHeight = 40;

        //// game container panel -----------------------------------------------
        //// game container panel
        public static Panel GamePanel = new Panel();
        private static Color _gamePanelColour = Color.LightGreen;
        private static int _gamePanelPaddingTop = 5;
        private static int _gamePanelPaddingLeft = 5;

        //// Questions panel container
        public static Panel QuestionPanel = new Panel();

        // Bottom panel - chosen question and reveal buttons ------------------
        // Selected Question Panel
        public static Panel HelpPanel = new Panel();
        private static int _helpPanelHeight = 80;
        private static Color _helpPanelColour = Color.Aqua;

        //// panel variables - general ------------------------------------------
        public static Int32 AnchorX
        {
            get => _anchorX;
        }
        public static Int32 AnchorY
        {
            get => _anchorY;
        }
        //public static int panel_width
        //{
        //    get => Spanel_width;
        //}
        public static int MarginBetweenPanels
        {
            get => _marginBetweenPanels;
        }

        public static int InternalPanelWidth
        {
            get => _internalPanelWidth;
            set => _internalPanelWidth = value;
        }
        //// Top panel - scores, timer etc --------------------------------------
        public static Color ScorePanelColour
        {
            get => _scorePanelColour;
        }
        public static Int32 ScoresPanelHeight
        {
            get => _scoresPanelHeight;
        }

        //// game container panel -----------------------------------------------
        public static Color GamePanelColour
        {
            get => _gamePanelColour;
        }
        public static int GamePanelPaddingTop
        {
            get => _gamePanelPaddingTop;
        }

        public static int GamePanelPaddingLeft
        {
            get => _gamePanelPaddingLeft;
        }

        // Help Panel --------------------------------------------
        public static int HelpPanelHeight
        {
            get => _helpPanelHeight;
        }

        public static Color HelpPanelColour
        {
            get => _helpPanelColour;
        }

        // positions and sizes 4 panels
        // 1 - score_panel = score, round and timer panel across top
        // 2 - game_panel = hold the picture box and the question_panel
        // 3 - question_panel = to right of grid holding questions/clues
        // 4 - selected_panel = across bottom to for buttons for reveal
        public static void GetElements()
        {
            //int form_inner_width = tmp_form.ClientRectangle.Width;
            //StylingGeneral.Sinternal_panel_width = 
            //    form_inner_width - (2 * anchor_x); 
            //StylingGeneral.outer_container_panel.Size = 
            //    new Size(StylingGeneral.internal_panel_width,)

            ScoresPanel.Size = new Size(InternalPanelWidth, ScoresPanelHeight);
            ScoresPanel.Location =
                new Point(AnchorX, AnchorY);
            ScoresPanel.BackColor = ScorePanelColour;
            // I hope this is the correct panel to add to
            Styling.WholeForm.TheForm.Controls.Add(ScoresPanel);
            TrackerVariables.TrackedVariables.PanelList.Add(ScoresPanel);

            Int32 _totalGridHeight = Styling.GameGrid.LettersHigh * Styling.GameGrid.HeightAndWidthLetterSquare;
            Int32 _totalGridWidth = Styling.QuestionsPanel.MarginQuestionLeft + Styling.GameGrid.HeightAndWidthLetterSquare * Styling.GameGrid.LettersWide + 200;
            Int32 _tmpGamePanelHeight = _totalGridHeight + MarginBetweenPanels + HelpPanelHeight;
            GamePanel.Size = new Size(InternalPanelWidth, _tmpGamePanelHeight);
            //game_panel.Size = new Size(panel_width, game_panel_height);
            GamePanel.Location =
                new Point(AnchorX,
                          AnchorY +
                          ScoresPanelHeight +
                          MarginBetweenPanels);
            GamePanel.BackColor = GamePanelColour;

            Styling.WholeForm.TheForm.Controls.Add(GamePanel);
            TrackerVariables.TrackedVariables.PanelList.Add(GamePanel);


            QuestionPanel.Size =
                new Size(Styling.QuestionsPanel.WidthQuestionPanel,
                         _totalGridHeight);
            QuestionPanel.Location =
                new Point(Styling.QuestionsPanel.MarginQuestionLeft +
                          Styling.GameGrid.HeightAndWidthLetterSquare *
                          Styling.GameGrid.LettersWide,
                          GamePanelPaddingTop);
            QuestionPanel.BackColor = HelpPanelColour;
            GamePanel.Controls.Add(QuestionPanel);
            //Styling.WholeForm.TheForm.Controls.Add(QuestionPanel);
            //HelpPanel.Controls.Add(QuestionPanel);
            TrackerVariables.TrackedVariables.PanelList.Add(QuestionPanel);




            HelpPanel.Size =
                new Size(InternalPanelWidth, HelpPanelHeight);
            HelpPanel.Location =
                new Point(0,
                          _totalGridHeight +
                          MarginBetweenPanels +
                          2 * GamePanelPaddingTop);
            HelpPanel.BackColor = HelpPanelColour;
            HelpPanel.Hide();
            GamePanel.Controls.Add(
                    HelpPanel);
            TrackerVariables.TrackedVariables.PanelList.Add(HelpPanel);
            //Styling.GameGrid.GridPicBox.Click += new EventHandler(EventHandlers.GridPic.grid_Click);
        }
    }
}
