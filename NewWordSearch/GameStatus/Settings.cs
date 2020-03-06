using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.GameStatus
{
    class Settings
    {
        // GAME SETTINGS


        private static Int32 _timePerRound = 600; // Time per round
        private static Int32 _startQuestionsPerPuzzle = 20;
        // number of questions
        private static int _answersCorrectStartRound = 0;
        public static int CurrentQuestionsPerPuzzle =
            _startQuestionsPerPuzzle;

        private static Int32 _pointsPerQuestion = 5; // points per question

        // Increase difficulty

        private static int _difficultyIncrease = 1;

        // Increase size of game grid

        private static int _increaseWidth = 1;
        private static int _increaseHeight = 1;

        // entry screen variables
        private static string _startMessage = "Click 'Ok' to begin game";
        private static string _title = "Start";

        // Random variable
        public static Random Rnd = new Random();

        // Public getters -----------------------------------------------------

        // GAME SETTINGS


        public static Int32 TimePerRound
        {
            get => _timePerRound;
        }
        public static Int32 StartQuestionsPerPuzzle
        {
            get => _startQuestionsPerPuzzle;

        }
        public static Int32 PointsPerQuestion
        {
            get => _pointsPerQuestion;
        }

        // entry screen variables
        public static string StartMessage
        {
            get => _startMessage;
        }
        public static string Title
        {
            get => _title;
        }
        public static int DifficultyIncrease
        {
            get => _difficultyIncrease;
        }

        public static int IncreaseWidth
        {
            get => _increaseWidth;
        }
        public static int IncreaseHeight
        {
            get => _increaseHeight;
        }
        public static int AnswersCorrectStartRound
        {
            get => _answersCorrectStartRound;
        }
    }
}
