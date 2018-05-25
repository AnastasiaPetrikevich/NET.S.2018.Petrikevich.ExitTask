using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossword.Interfaces
{
    public interface ICrossSolver
    {
        char[,] SolveCross(char[,] matrix, IEnumerable<string> words);
    }
}
