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

        public Board(int boardSize, int[,] startingState = null, int startingStateEmptyVal = 0)
        {
            this.BoardSize = boardSize;

            if (startingState == null || IsValidStartingStateFormat(boardSize, startingState, startingStateEmptyVal))
            {
                InitCells(boardSize, startingState)
            }
            else
            {
                throw new Exception("Starting board not in the correct format");
            }
            
        }

        private static Cell[,] InitCells(int boardSize, int[,] startingState)
        {
            Cell[,] cells = new Cell[boardSize, boardSize];

            for(int i = 0; i < boardSize; i++)
            {
                for(int j = 0; j < boardSize; j++)
                {
                    int startingVal = startingState != null ? startingState[i, j] : 0;

                    cells[i, j] = new Cell((i, j), boardSize, startingVal);
                }
            }

            return cells;
        }

        private static bool IsValidStartingStateFormat(int boardSize, int[,] startingState, int emptyVal)
        {
            int xDim = startingState.GetLength(0);
            int yDim = startingState.GetLength(1);
            
            if (xDim <= 0 || xDim > boardSize || yDim <= 0 || yDim > boardSize)
            {
                // validate dimensions
                return false;
            }

            for(int i = 0; i < xDim; i++)
            {
                for(int j = 0; j < yDim; i++)
                {
                    int val = startingState[i, j];

                    if (val > boardSize || !(val <= 0 && val != emptyVal))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
