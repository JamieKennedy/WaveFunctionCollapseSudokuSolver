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


        public Cell((int, int) position, int boardSize, int initialValue = 0)
        {
            this.Position = position;
                        
            if(initialValue > 0) 
            {
                // Has initial value provided
                this.PossibleValues = new List<int>();
            }
            else
            {
                this.PossibleValues = Enumerable.Range(1, boardSize).ToList(); // All possible values
            }

            this.Value = initialValue > 0 ? initialValue : null; 
        }
    }
}
