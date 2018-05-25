using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crossword.Interfaces;

namespace CrossFieldGenerator
{
    public class FieldGenerator : ICrossFieldGenerator
    {
        public char[,] CreateCrosswordField()
        {
            char[,] CrosswordField = new char[11,11];
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    CrosswordField[i, j] = '*';
                    if (i == 0 && j > 1 && j < 9)
                        CrosswordField[i, j] = '_';
                    if (i == 4 && j > 2 && j < 11)
                        CrosswordField[i, j] = '_';
                    if (i == 7 && j > -1 && j < 9)
                        CrosswordField[i, j] = '_';
                    if (i == 9 && j > 1 && j < 6)
                        CrosswordField[i, j] = '_';
                    if (j == 1 && i > 3 && i < 8)
                        CrosswordField[i, j] = '_';
                    if (j == 4 && i > 5 && i < 11)
                        CrosswordField[i, j] = '_';
                    if (j == 7 && i > -1 && i < 8)
                        CrosswordField[i, j] = '_';
                }

            }
            return CrosswordField;
        }
    }
}
