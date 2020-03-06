using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridCreation
{
    class GetRandomLetters
    {
        // 6ai) get_random_letter(square, point_group) - gets a random
        // letter from the chosen group
        //      adds this letters to square.letter
        public static void Get(
            NonStaticClasses.LetterSquare _square, List<string> _letterGroup)
        {
            Int32 tmp_random = GameStatus.Settings.Rnd.Next(_letterGroup.Count);
            _square.Letter = _letterGroup[tmp_random];
        }
    }
}
