using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NewWordSearch.Styling
{
    class ScoresPanel
    {
        //// Title labels
        public static Label ScoreTitleLabel = new Label();
        public static Label RoundTitleLabel = new Label();
        public static Label TimerTitleLabel = new Label();

        //// Score labels
        public static Label ScoreLabel = new Label();
        public static Label RoundLabel = new Label();
        public static Label TimerLabel = new Label();

        private static Int32 _marginScoreTop;

        //// General Score & Title label variables
        private static Int32 _scoreLabelHeight = 14;

        //// Title labels
        private static Int32 _titleWidth = 80;
        private static Int32 _titleMargin = 20;

        //// Score labels
        private static Int32 _scoreWidth = 30;
        private static Int32 _scoreMargin = 5;

        // Top panel - scores, timer etc --------------------------------------
        private static Color _scoreRoundTimerTitlesBackground =
            Color.White;
        private static Color _scoreRoundTimerResultBackground =
            Color.White;



        //// Public getters -----------------------------------------------------
        //// General Score & Title label variables
        public static int MarginScoreTop
        {
            get => _marginScoreTop;
            set => _marginScoreTop = value;
        }
        public static Int32 ScoreLabelHeight
        {
            get => _scoreLabelHeight;
        }
        //// Title labels
        public static Int32 TitleWidth
        {
            get => _titleWidth;
        }
        public static Int32 TitleMargin
        {
            get => _titleMargin;
        }
        //// Score labels
        public static Int32 ScoreWidth
        {
            get => _scoreWidth;
        }
        public static Int32 ScoreMargin
        {
            get => _scoreMargin;
        }
        // Top panel - scores, timer etc
        public static Color ScoreRoundTimerTitlesBackground
        {
            get => _scoreRoundTimerTitlesBackground;
        }
        public static Color ScoreRoundTimerResultBackground
        {
            get => _scoreRoundTimerResultBackground;
        }

        //// Functions ----------------------------------------------------------

        //// positions and sizes 2 labels each for score, round and timer for
        //// decription and actual amount
        public static void GetElements()
        {
            MarginScoreTop = (Styling.FormOutline.ScoresPanelHeight - ScoreLabelHeight) / 2;
            int _titleCount = 0;
            int _scoreCount = 0;
            ScoreTitleLabel.Size = new Size(TitleWidth, ScoreLabelHeight);
            ScoreTitleLabel.Location = new Point(Methods.GetScoreBoxWidth.GetWidths(_titleCount, _scoreCount),
                                                 MarginScoreTop);

            ScoreTitleLabel.Text = "Score:";
            ScoreTitleLabel.BackColor = ScoreRoundTimerTitlesBackground;

            _titleCount += 1;

            ScoreLabel.Size = new Size(ScoreWidth, ScoreLabelHeight);
            ScoreLabel.Location = new Point(Methods.GetScoreBoxWidth.GetWidths(_titleCount, _scoreCount),
                                            MarginScoreTop);
            ScoreLabel.BackColor = ScoreRoundTimerResultBackground;
            ScoreLabel.Text = Convert.ToString(TrackerVariables.TrackedVariables.GameScore);

            _scoreCount += 1;

            RoundTitleLabel.Size =
                new Size(TitleWidth, ScoreLabelHeight);
            RoundTitleLabel.Location =
                new Point(Methods.GetScoreBoxWidth.GetWidths(_titleCount, _scoreCount),
                          MarginScoreTop);
            RoundTitleLabel.Text = "Round:";
            RoundTitleLabel.BackColor = ScoreRoundTimerTitlesBackground;

            _titleCount += 1;

            RoundLabel.Size =
                new Size(ScoreWidth, ScoreLabelHeight);
            RoundLabel.Location =
                new Point(Methods.GetScoreBoxWidth.GetWidths(_titleCount, _scoreCount),
                          MarginScoreTop);
            RoundLabel.BackColor = ScoreRoundTimerResultBackground;
            RoundLabel.Text =
                Convert.ToString(TrackerVariables.TrackedVariables.CurrentRound);

            _scoreCount += 1;

            TimerTitleLabel.Size =
                new Size(TitleWidth, ScoreLabelHeight);
            TimerTitleLabel.Location =
                new Point(Methods.GetScoreBoxWidth.GetWidths(_titleCount, _scoreCount),
                          MarginScoreTop);
            TimerTitleLabel.Text = "Seconds left:";
            TimerTitleLabel.BackColor = ScoreRoundTimerTitlesBackground;

            _titleCount += 1;

            TimerLabel.Size =
                new Size(ScoreWidth, ScoreLabelHeight);
            TimerLabel.Location =
                new Point(Methods.GetScoreBoxWidth.GetWidths(_titleCount, _scoreCount),
                          MarginScoreTop);
            TimerLabel.BackColor = ScoreRoundTimerResultBackground;

            _scoreCount += 1;



            TrackerVariables.TrackedVariables.LabelsPerRound.Add(ScoreTitleLabel);
            TrackerVariables.TrackedVariables.LabelsPerRound.Add(ScoreLabel);
            TrackerVariables.TrackedVariables.LabelsPerRound.Add(RoundTitleLabel);
            TrackerVariables.TrackedVariables.LabelsPerRound.Add(RoundLabel);
            TrackerVariables.TrackedVariables.LabelsPerRound.Add(TimerTitleLabel);
            TrackerVariables.TrackedVariables.LabelsPerRound.Add(TimerLabel);

            Styling.FormOutline.ScoresPanel.Controls.Add(ScoreTitleLabel);
            Styling.FormOutline.ScoresPanel.Controls.Add(ScoreLabel);
            Styling.FormOutline.ScoresPanel.Controls.Add(RoundTitleLabel);
            Styling.FormOutline.ScoresPanel.Controls.Add(RoundLabel);
            Styling.FormOutline.ScoresPanel.Controls.Add(TimerTitleLabel);
            Styling.FormOutline.ScoresPanel.Controls.Add(TimerLabel);
        }
    }
}
