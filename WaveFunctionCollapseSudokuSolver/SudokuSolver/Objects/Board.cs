using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Objects
{
    public class Board
    {
        public int BoardSize { get; set; } // BoardSize n = n x n grid
        public Cell[,] Cells { get; set; } // 2D array of cells

        public Board(int boardSize)
        {
            this.BoardSize = boardSize;
            this.Cells = InitCells(boardSize);
        }

        private static Cell[,] InitCells(int boardSize)
        {
            Cell[,] cells = new Cell[boardSize, boardSize];

            for(int i = 0; i < boardSize; i++)
            {
                for(int j = 0; j < boardSize; j++)
                {
                    cells[i, j] = new Cell((i, j), boardSize);
                }
            }

            return cells;
        }
    }
}
