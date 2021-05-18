using System;
using System.Collections.Generic;
using System.Text;
using Tetris_Factory.Figures;

namespace Tetris_Factory
{
    public static class TetrisFigureFactory

    {
        public static IFigure GetFigure(string figureType)
        {
            if (figureType == "1")
            {
                return new LineFigure();
            }//Line
            if (figureType == "2")
            {
                return new TFigure();
            }//T
            if (figureType == "3")
            {
                return new JFigure();
            }//J
            if (figureType == "4")
            {
                return new LFigure();
            }//L
            if (figureType == "5")
            {
                return new SquareFigure();
            }//Square
            if (figureType == "6")
            {
                return new ShadowFigure();
            }//Shadow
            if (figureType == "7")
            {
                return new HorizontalLineFigure();
            }
            if (figureType == "8")
            {
                return new FlippedOverTFigure();
            }
            if (figureType == "9")
            {
                return new FlippedOverJFigure();
            }
            if (figureType == "10")
            {
                return new FlippedOverLFigure();
            }
            if (figureType == "11")
            {
                return new HorizontalShadowFigure();
            }
            return null;
        }
    }
}
