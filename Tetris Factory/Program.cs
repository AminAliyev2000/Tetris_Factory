using System;

namespace Tetris_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine
                    (@"Choose your option:
1.Line Figure
2.T Figure
3.J Figure
4.L Figure
5.Square Figure
6.Shadow Figure
7.Horizontal  Line Figure
8.Flipped Over  T  Figure
9.Flipped Over  J  Figure
10.Flipped Over L  Figure
11.Horizontal Shadow Figure");
            Console.Write("Enter your option:");
            string option=Console.ReadLine();
            IFigure figure = TetrisFigureFactory.GetFigure(option);
            Console.Clear();
            figure.ShowFigure();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
            }
        }
    }
}
