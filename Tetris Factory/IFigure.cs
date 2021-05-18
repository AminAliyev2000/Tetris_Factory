using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris_Factory
{
    public interface IFigure
    {
        public string FigureName { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        string[,] FormArray { get; set; }
        void FillFigure();
        void ShowFigure();
    }
}
