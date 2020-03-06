using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Methods.GameGridCreation
{
    class GetRandomLetterGroup
    {
        // 6a) get_random_letter_group(square) - gets a random int 
        // between 1 and 1506
        //     uses this to choose which letter group to use
        //     calls 6ai) get_random_letter(square, point_group)
        public static void Get(NonStaticClasses.LetterSquare _square)
        {
            Int32 _tmpRandom = GameStatus.Settings.Rnd.Next(1, 151);
            List<string> _chosenLetterGroup = new List<string>();
            switch (_tmpRandom)
            {
                case int n when n > 0 && n <= 60:
                    _chosenLetterGroup = Content.Letters.OnePoint;
                    break;
                case int n when n > 60 && n <= 90:
                    _chosenLetterGroup = Content.Letters.TwoPoints;
                    break;
                case int n when n > 90 && n <= 110:
                    _chosenLetterGroup = Content.Letters.ThreePoints;
                    break;
                case int n when n > 110 && n <= 125:
                    _chosenLetterGroup = Content.Letters.FourPoints;
                    break;
                case int n when n > 125 && n <= 137:
                    _chosenLetterGroup = Content.Letters.FivePoints;
                    break;
                case int n when n > 137 && n <= 145:
                    _chosenLetterGroup = Content.Letters.EightPoints;
                    break;
                case int n when n > 145:
                    _chosenLetterGroup = Content.Letters.TenPoints;
                    break;
                default:
                    break;
            }
            if (_chosenLetterGroup.Count > 0)
            {
                Methods.GameGridCreation.GetRandomLetters.Get(_square, _chosenLetterGroup);
            }
        }
    }
}
