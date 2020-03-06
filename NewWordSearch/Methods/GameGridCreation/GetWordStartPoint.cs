using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridCreation
{
    class GetWordStartPoint
    {
        // 5a) find_start_point(question) - gets random start position for
        // a word and a random direction
        //     calls 5ai) check_space_for_word(row, col, direction, word)
        //     if false: 5a) find_start_point(question)
        //     if true: call 5aii) get_other_letters(row,col,dir,word) - 
        //     gets list of squares containing word
        //     if all squares in list are empty
        //     place letters in each LetterSquare.letter
        public static void FindStart(NonStaticClasses.Questions _question)
        {
            string _testWord = _question.QuestionAnswer;
            List<NonStaticClasses.LetterSquare> letter_boxes =
                new List<NonStaticClasses.LetterSquare>(); // creates list to hold test squares
            Int32 _startRow = GameStatus.Settings.Rnd.Next(Styling.GameGrid.LettersHigh);
            // random starting row
            Int32 _startCol = GameStatus.Settings.Rnd.Next(Styling.GameGrid.LettersWide);
            // random starting col
            Int32 _direction = GameStatus.Settings.Rnd.Next(4);
            // random choice of 4 directions

            if (Methods.GameGridCreation.CheckSpaceForWord.CheckSpace(
                _startRow, _startCol, _direction, _testWord) == true)
            {
                bool all_empty = true;
                letter_boxes = Methods.GameGridCreation.GetWordOtherLettersPosition.GetLetters(
                               _startRow, _startCol, _direction, _testWord);
                for (int count = 0; count < _testWord.Length; count++)
                {
                    if (letter_boxes[count].Letter != "" &&
                        letter_boxes[count].Letter !=
                            Convert.ToString(_testWord[count]))
                    {
                        all_empty = false;
                    }
                }
                if (all_empty == true)
                {
                    for (Int32 count = 0; count < _testWord.Length; count++)
                    {
                        letter_boxes[count].Letter =
                            Convert.ToString(_testWord[count]);
                        letter_boxes[count].IsPartOfAnswer = true;
                        letter_boxes[count].PartOfQuestionNumber.Add(
                                _question.QuestionNumber);
                    }
                }
                else
                {
                    FindStart(_question);
                }
            }
            else
            {
                FindStart(_question);
            }
        }
    }
}
