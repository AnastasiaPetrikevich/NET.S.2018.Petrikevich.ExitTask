using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crossword.Interfaces;

namespace Crossword
{
    public class Cross
    {
        private char[,] solvedCross;
        private ICrossFieldGenerator fieldGenerator;
        private ICrossSolver crossSolver;
        private List<string> words;
        public Cross(IEnumerable<string> words, ICrossFieldGenerator fieldGenerator, ICrossSolver crossSolver)
        {
            if (fieldGenerator == null || crossSolver == null)
            {
                throw new ArgumentNullException("One of arguments is null");
            }

            this.crossSolver = crossSolver;
            this.fieldGenerator = fieldGenerator;
            this.words = words.ToList();
        }

        public void Solve()
        {
            crossSolver.SolveCross(fieldGenerator.CreateCrosswordField(),words);
        }
    }
}
