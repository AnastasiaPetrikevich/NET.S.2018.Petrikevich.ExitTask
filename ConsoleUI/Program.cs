using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossFieldGenerator;
using CrossSolver;
using Crossword;
using Crossword = Crossword.Cross;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Cross crossword = new Cross("перелом,подвывих,закрытый,ушиб,шина,вывих,открытый".Split(','), new FieldGenerator(), new Solver());
            crossword.Solve();
        }
    }
}
