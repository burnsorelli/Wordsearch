using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NewWordSearch.Styling
{
    class GameGrid
    {
        //// CONTROLS FOR LAYOUT OF GAME GRID
        //// Wordsearch variables to control size, shape etc
        public static Bitmap GridPic;
        public static PictureBox GridPicBox = new PictureBox();

        public static Int32 HeightAndWidthLetterSquare = 25;
        public static Int32 LettersWide = 14;
        public static Int32 LettersHigh = 14;
        ////private static Int32 Sanchor_x = 10;
        ////private static Int32 Sanchor_y = 10;


        //// Variables for colours of grid squares
        private static Brush _colourGridText =
            new SolidBrush(Color.Blue);
        private static Brush _colourGridBox =
            new SolidBrush(Color.White);
        private static Brush _colourGridTextHighlight =
            new SolidBrush(Color.Black);
        private static Brush _colourGridBoxHighlight =
            new SolidBrush(Color.Red);
        private static Brush _colourGridTextSelected =
            new SolidBrush(Color.White);
        private static Brush _colourGridBoxSelected =
            new SolidBrush(Color.Blue);
        private static Brush _colourGridTextFound =
            new SolidBrush(Color.White);
        private static Brush _colourGridBoxFound =
            new SolidBrush(Color.DarkGray);

        // Variable for font and grid lines
        private static Font _letterFont = new Font("Times New Roman", 12.0f);
        private static Pen _greyPen = new Pen(Color.Gray, 3);


        //// Public getters -----------------------------------------------------
        //// CONTROLS FOR LAYOUT OF GAME GRID
        //// Wordsearch variables to control size, shape etc

        ////public static Int32 anchor_x
        ////{
        ////    get => Sanchor_x;
        ////}
        ////public static Int32 anchor_y
        ////{
        ////    get => Sanchor_y;
        ////}


        //// Variables for colours of grid squares
        public static Brush ColourGridText
        {
            get => _colourGridText;
        }
        public static Brush ColourGridBox
        {
            get => _colourGridBox;
        }
        public static Brush ColourGridTextHighlight
        {
            get => _colourGridTextHighlight;
        }
        public static Brush ColourGridBoxHighlight
        {
            get => _colourGridBoxHighlight;
        }
        public static Brush ColourGridTextSelected
        {
            get => _colourGridTextSelected;
        }
        public static Brush ColourGridBoxSelected
        {
            get => _colourGridBoxSelected;
        }
        public static Brush ColourGridTextFound
        {
            get => _colourGridTextFound;
        }
        public static Brush ColourGridBoxFound
        {
            get => _colourGridBoxFound;
        }

        // Variable for font and grid lines
        public static Font LetterFont
        {
            get => _letterFont;
        }
        public static Pen GreyPen
        {
            get => _greyPen;
        }

        
        
    }
}
