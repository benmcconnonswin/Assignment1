using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Grid
    {
        public int Rows { get; }
        public int Columns { get; }
        private List<List<Cell>> Cells { get; }

        public Grid(int cols, int rows)
        {          
            Columns = cols;
            Rows = rows;

            Cells = new List<List<Cell>>();

            for(int i = 0; i < Columns; i++)
            {
                //Creates a list of row cells to be added to the Cells list
                List<Cell> rowCells = new List<Cell>();
                for (int j = 0; j < Rows; j++)
                {
                    rowCells.Add(new Cell(Cell.State.Empty));
                }
                Cells.Add(rowCells);
            }       
        }

        public Cell GetCell(int row, int col)
        {
            return Cells[row][col];
        }

        /// <summary>
        /// Displays the grid in console
        /// </summary>
        /// <returns>A string storing a visual of the grid</returns>
        public string ConsoleGrid()
        {
            string result = "";

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    switch(GetCell(j, i).CellState)
                    {
                        case Cell.State.Wall:
                            result += "X";
                            break;
                        case Cell.State.Empty:
                            result += "O";
                            break;
                        case Cell.State.Agent:
                            result += "A";
                            break;
                        case Cell.State.Goal:
                            result += "G";
                            break;
                    }
                    result += " ";
                }
                result += "\n";
            }


            return result;
        }
    }
}
