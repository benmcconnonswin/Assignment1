using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Search
    {
        public Grid Grid { get; }
        public int[] AgentCoords { get; }
        public bool FoundGoal;

        public Search(Grid myGrid)
        {
            Grid = myGrid;
            AgentCoords = Grid.GetAgent();
            FoundGoal = false;
        }

        public bool CanMove(string direction)
        {
            int row = AgentCoords[0];
            int col = AgentCoords[1];

            switch (direction)
            {
                case "up":
                    col--;
                    break;
                case "down":
                    col++;
                    break;
                case "left":
                    row--;
                    break;
                case "right":
                    row++;
                    break;
                default:
                    return false;
            }

            if (row < 0 || row >= Grid.Columns || col < 0 || col >= Grid.Rows)
            {
                return false;
            }

            if (Grid.GetCell(row,col).CellState == Cell.State.Wall)
            {
                return false;
            }

            if (Grid.GetCell(row, col).CellState == Cell.State.Goal)
            {
                Grid.GetCell(row, col).SetState(Cell.State.Empty);
                Grid.GetCell(AgentCoords[0], AgentCoords[1]).SetState(Cell.State.Agent);

                FoundGoal = true;
            }

                return true;

        }

        public void Execute()
        {
            Move("right");
            Move("right");  
        }

        public void Move(string direction)
        {
            if (FoundGoal)
            {
                return;
            }

            if (CanMove(direction))
            {
                switch (direction)
                {
                    case "up":
                        Grid.SwapCell(Grid.GetCell(AgentCoords[0], AgentCoords[1]), Grid.GetCell(AgentCoords[0], AgentCoords[1] - 1));
                        AgentCoords[1] --;
                        break;
                    case "down":
                        Grid.SwapCell(Grid.GetCell(AgentCoords[0], AgentCoords[1]), Grid.GetCell(AgentCoords[0], AgentCoords[1] + 1));
                        AgentCoords[1]++;
                        break;
                    case "left":
                        Grid.SwapCell(Grid.GetCell(AgentCoords[0], AgentCoords[1]) , Grid.GetCell(AgentCoords[0] - 1, AgentCoords[1]));
                        AgentCoords[0]--;
                        break;
                    case "right":
                        Grid.SwapCell(Grid.GetCell(AgentCoords[0], AgentCoords[1]), Grid.GetCell(AgentCoords[0] + 1, AgentCoords[1]));
                        AgentCoords[0]++;
                        break;
                }
            }
        }
    }
}
