using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NewWordSearch.NonStaticClasses
{
    class LetterSquare
    {
        private string _letter;
        private bool _selected;
        public bool IsPartOfAnswer;
        // set when question is placed in cv.Find_start_point
        public List<Int32> PartOfQuestionNumber = new List<int>();
        // set when question is placed in cv.Find_start_point
        public Int32 Col;
        public Int32 Row;
        public Int32 Xcoord;
        public Int32 Ycoord;
        public Rectangle LetterRectangle;
        //public static LetterSquare[,] full_grid;
        //public static List<LetterSquare> selected_list =
        //    new List<LetterSquare>();
        //public static LetterSquare last_clicked_square;
        public bool Found;
        private bool _highlight;
        private Brush _backgroundColour;
        private Brush _textColour;

        public LetterSquare(Int32 a_col, Int32 a_row)
        {
            _letter = "";
            IsPartOfAnswer = false;
            Col = a_col;
            Row = a_row;
            GetCoords();
            GetRectangle();
            Found = false;
            _highlight = false;
            _backgroundColour = Styling.GameGrid.ColourGridBox;
            _textColour = Styling.GameGrid.ColourGridText;
        }

        public bool Highlight
        {
            get
            {
                return _highlight;
            }
            set
            {
                if (_highlight == false)
                {
                    _highlight = true;
                }
                else
                {
                    _highlight = false;
                }
                Methods.GameGridUse.GetSquareColour.GetColours(this);
            }
        }

        public string Letter
        {
            get
            {
                return _letter;
            }
            set
            {
                _letter = value.ToUpper();

            }
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (Selected)
                {
                    _selected = false;
                    TrackerVariables.TrackedVariables.SelectedLetters.Remove(this);
                }

                else if (!Selected)
                {
                    _selected = true;
                    TrackerVariables.TrackedVariables.SelectedLetters.Add(this);
                }
                Methods.Trackers.GetLastClicked.GetLast();
                Methods.GameGridUse.GetSquareColour.GetColours(this);
            }
        }

        public Brush TextColour
        {
            get { return _textColour; }
            set { _textColour = value; }
        }

        public Brush BackgroundColour
        {
            get { return _backgroundColour; }
            set { _backgroundColour = value; }
        }


        public void GetCoords()
        {
            this.Xcoord =
                this.Col * Styling.GameGrid.HeightAndWidthLetterSquare -
                Styling.GameGrid.HeightAndWidthLetterSquare;
            this.Ycoord =
                this.Row * Styling.GameGrid.HeightAndWidthLetterSquare -
                Styling.GameGrid.HeightAndWidthLetterSquare;
        }

        public void GetRectangle()
        {
            Rectangle tmp_rectangle = new Rectangle(this.Xcoord, this.Ycoord,
                Styling.GameGrid.HeightAndWidthLetterSquare,
                Styling.GameGrid.HeightAndWidthLetterSquare);
            LetterRectangle = tmp_rectangle;
        }
    }
}
