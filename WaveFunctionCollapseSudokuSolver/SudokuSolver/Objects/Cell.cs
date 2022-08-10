using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace SudokuSolver.Objects
{
    public class Cell
    {
        public (int, int) Position { get; }
        public bool IsCollapsed { get; set; }
        public int? Value { get; set; }
        public List<int> PossibleValues { get; set; }


        public Cell((int, int) position, int boardSize)
        {
            this.Position = position;
            this.PossibleValues = Enumerable.Range(1, boardSize).ToList(); // Init possible values to all values
            this.Value = null; // Init value to null as only gets value once collapsed
        }
    }
}
