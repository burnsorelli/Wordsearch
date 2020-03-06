using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWordSearch.TrackerVariables
{
    class TrackedVariables
    {
        // VARIABLES KEEPING TRACK OF GAME STATE

        public static int ShortestAnswerLength;
        // variable to trigger check for answer method
        public static bool ContinuePlaying = true;
        // to pause the ability to click squares
        // Scores variables
        public static int CorrectQuestions = 0;
        public static int GameScore = 0;
        public static int CurrentRound = 1;
        // Timer variables
        public static Timer GameTimer = new Timer();
        public static int TimeLeft = GameStatus.Settings.TimePerRound;
        // Keeps track of temporarily created labels and panels per round
        public static List<Label> LabelsPerRound = new List<Label>();
        public static List<Panel> PanelList = new List<Panel>();

        public static NonStaticClasses.Questions ChosenQuestion;

        public static List<NonStaticClasses.Questions> QuestionList = new List<NonStaticClasses.Questions>();

        public static List<NonStaticClasses.LetterSquare> SelectedLetters = new List<NonStaticClasses.LetterSquare>();

        public static NonStaticClasses.LetterSquare LastClickedLetter;

        public static NonStaticClasses.LetterSquare[,] FullGrid;

        public static Label SelectedQuestion = new Label();

        //// Questions settings
        //public static int height_questions; 
        //public static int width_question_panel;


        // Active bank of questions and current list
        public static Dictionary<string, string> QuestionListBank =
            new Dictionary<string, string>(Content.Questions.PermanentQuestionList);
        public static Dictionary<string, string> ActiveQuestionList =
            new Dictionary<string, string>();
    }
}
