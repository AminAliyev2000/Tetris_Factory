using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris_Factory
{
    public  class ShadowFigure:IFigure
    {
        public ShadowFigure()
        {
            FigureName = "Shadow Figure";
            Red = 0;
            Green = 55;
            Blue = 55;
            FillFigure();
        }
        public string FigureName { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public string[,] FormArray { get; set; } = new string[4, 4];

        public void FillFigure()
        {
            FormArray[0, 0] = " ";
            FormArray[0, 1] = " ";
            FormArray[0, 2] = " ";
            FormArray[0, 3] = " ";
            FormArray[1, 0] = " ";
            FormArray[1, 1] = " ";
            FormArray[1, 2] = "1";
            FormArray[1, 3] = "1";
            FormArray[2, 0] = "1";
            FormArray[2, 1] = "1";
            FormArray[2, 2] = " ";
            FormArray[2, 3] = " ";
            FormArray[3, 0] = " ";
            FormArray[3, 1] = " ";
            FormArray[3, 2] = " ";
            FormArray[3, 3] = " ";

        }

        public void ShowFigure()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Figure Name:{FigureName}");
            Console.WriteLine($"Figure Color (RGB):{Red},{Green},{Blue}");
            Console.WriteLine($"Figure Form is:\n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Console.Write("{0}", FormArray[i, j]);
                }
                Console.WriteLine();

            }
            Console.ResetColor();



        }
    }
}
