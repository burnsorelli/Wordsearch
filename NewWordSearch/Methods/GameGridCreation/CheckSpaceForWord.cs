using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridCreation
{
    class CheckSpaceForWord
    {
        // 5ai) check_space_for_word(row, col, dir, word) - checks if
        // enough space
        //      if enough space and all squares empty Return true; 
        // else Return false;
        public static bool CheckSpace(
            Int32 _startX, Int32 _startY, Int32 _direction, string _word)
        {
            switch (_direction)
            {
                case 0:  // left to right
                    if (_startX + _word.Length <= Styling.GameGrid.LettersWide)
                    { return true; }
                    else { return false; }
                case 1: // top to bottom
                    if (_startY + _word.Length <= Styling.GameGrid.LettersHigh)
                    { return true; }
                    else { return false; }
                case 2: // diagonally up
                    if ((_startX + _word.Length <= Styling.GameGrid.LettersWide)
                        && (_startY - _word.Length >= 1))
                    { return true; }
                    else { return false; }
                case 3: // diagonally down
                    if ((_startX + _word.Length <=
                        Styling.GameGrid.LettersWide) &&
                        (_startY + _word.Length <=
                        Styling.GameGrid.LettersHigh))
                    { return true; }
                    else { return false; }
                default: { return false; }
            }
        }
    }
}
