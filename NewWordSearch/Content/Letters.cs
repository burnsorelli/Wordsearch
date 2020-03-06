using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordSearch.Content
{
    class Letters
    {
        // Scrabble score groups for letters
        private static List<string> _onePoint = new List<string> {
            "a", "e", "i", "l", "n", "o", "r", "s", "t", "u" };
        private static List<string> _twoPoints = new List<string> {
            "d", "g" };
        private static List<string> _threePoints = new List<string> {
            "b", "c", "m", "p" };
        private static List<string> _fourPoints = new List<string> {
            "f", "h", "v", "w", "y" };
        private static List<string> _fivePoints = new List<string> {
            "k" };
        private static List<string> _eightPoints = new List<string> {
            "j", "x" };
        private static List<string> _tenPoints = new List<string> {
            "q", "z" };

        // Scrabble score groups for letters
        public static List<string> OnePoint
        {
            get => _onePoint;
        }
        public static List<string> TwoPoints
        {
            get => _twoPoints;
        }
        public static List<string> ThreePoints
        {
            get => _threePoints;
        }
        public static List<string> FourPoints
        {
            get => _fourPoints;
        }
        public static List<string> FivePoints
        {
            get => _fivePoints;
        }
        public static List<string> EightPoints
        {
            get => _eightPoints;
        }
        public static List<string> TenPoints
        {
            get => _tenPoints;
        }

    }
}
