using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Cell
    {
        public enum State
        {
            Empty = 0,
            Wall = 1,
            Agent = 2,
            Goal = 3,
        };

        public State CellState { get; set; }
        public int X { get; }
        public int Y { get; }

        public Cell(State state)
        {
            CellState = state;

        }

        public void SetState(Cell.State state)
        {
            CellState = state;
        }

    }
}
