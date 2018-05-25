using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CrossSolver.Structures;
using Crossword.Interfaces;

namespace CrossSolver
{
    public class Solver : ICrossSolver
    {
        private List<FoundWordInfo> foundWords;
        public Solver()
        {
      
            foundWords = new List<FoundWordInfo>();
        }

        public char[,] SolveCross(char[,] matrix, IEnumerable<string> words)
        {
            if (matrix == null || words == null || !words.Any())
            {
                throw new ArgumentException("Invalid arguments");
            }

            FindWords(matrix);
            
            return null;
        }

        private void FindWords(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < (matrix.Length/matrix.GetLength(0)); j++)
                {
                    if (matrix[i, j] == '_')
                    {
                        var word = FindWord(matrix,i, j, out j);
                        if (word != null)
                        {
                            foundWords.Add((FoundWordInfo)word);
                        }
                    }
                }
            }
        }

        private FoundWordInfo? FindWord(char[,] matrix,int i, int j, out int newJ)
        {
            if (i != 0 && matrix[i - 1, j] == '_')
            {
                newJ = j;
                return null;
            }

            if (j + 1 == matrix.GetLength(0) || matrix[i, j + 1] == '*')
            {
                newJ = j;
                int k = i;
                while (matrix[k,j] !='*')
                {
                    if(k == matrix.Length / matrix.GetLength(0) - 1) break;
                    
                    k++;
                }
                return new FoundWordInfo(i,j,k-1,j);
            }
            else
            {
                int k = j;
                while (matrix[i,k] != '*')
                {
                    if(k == matrix.GetLength(0) - 1 ) break;
                    
                    k++;
                }
                newJ = k;
                return new FoundWordInfo(i,j,i,k-1);
            }
        }
    }
}
