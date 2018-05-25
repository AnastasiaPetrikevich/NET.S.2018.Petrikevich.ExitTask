using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossSolver.Structures
{
    internal struct FoundWordInfo
    {
        internal int startI;
        internal int startJ;
        internal int endI;
        internal int endJ;

        public FoundWordInfo(int startI,int startJ, int endI,int endJ)
        {
            this.startI = startI;
            this.startJ = startJ;
            this.endI = endI;
            this.endJ = endJ;
        }
    }
}
