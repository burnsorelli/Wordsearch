using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridCreation
{
    class GetWordOtherLettersPosition
    {
        // 5aii) get_other_letters(row, col, dir, word) - - finds 
        // corresponding squares for rest of word
        //       puts them in a list and Returns the list

        public static List<NonStaticClasses.LetterSquare> GetLetters(
            Int32 _startX, Int32 _startY, Int32 _direction, string _word)
        {
            List<NonStaticClasses.LetterSquare> _tmpList = new List<NonStaticClasses.LetterSquare>();
            Int32 x, y;
            for (Int32 count = 0; count < _word.Length; count++)
            {
                switch (_direction)
                {
                    case 0: // left to right
                        x = _startX + count;
                        y = _startY;
                        break;
                    case 1: // top to bottom
                        x = _startX;
                        y = _startY + count;
                        break;
                    case 2: // diagonally up
                        x = _startX + count;
                        y = _startY - count;
                        break;
                    case 3: // diagonally down
                        x = _startX + count;
                        y = _startY + count;
                        break;
                    default:
                        x = -1;
                        y = -1;
                        break;
                }
                if (x >= 0)
                {
                    _tmpList.Add(TrackerVariables.TrackedVariables.FullGrid[x, y]);
                }
            }
            return _tmpList;
        }
    }
}
