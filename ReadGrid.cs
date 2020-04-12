using System;
using System.IO;

namespace Assignment1
{
    public class ReadGrid
    {
        static public Grid Read()
        {
            using var reader = new StreamReader("TestCases/RobotNav-test.txt");

            var line = reader.ReadLine();
            line = Sanitise(line);
            var size = line.Split(',');    
            Int32.TryParse(size[0], out int rows);
            Int32.TryParse(size[1], out int cols);

            Grid myGrid = new Grid(cols, rows);

            line = reader.ReadLine();
            line = Sanitise(line);
            var agent = line.Split(',');       
            Int32.TryParse(agent[0], out int agentx);
            Int32.TryParse(agent[1], out int agenty);

            myGrid.GetCell(agentx, agenty).SetState(Cell.State.Agent);

            line = reader.ReadLine();
            var goals = line.Split('|');

            for (int i = 0; i < goals.Length; i++)
            {
                goals[i] = Sanitise(goals[i]);
                var goal = goals[i].Split(',');
                Int32.TryParse(goal[0], out int goalx);
                Int32.TryParse(goal[1], out int goaly);


                myGrid.GetCell(goalx, goaly).SetState(Cell.State.Goal);
            }

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                line = Sanitise(line);
                var wall = line.Split(',');

                Int32.TryParse(wall[0], out int wallx);
                Int32.TryParse(wall[1], out int wally);
                Int32.TryParse(wall[2], out int wallw);
                Int32.TryParse(wall[3], out int wallh);

                for(int i = 0; i < wallh; i++)
                {
                    for(int j = 0; j < wallw; j++)
                    {
                        myGrid.GetCell(wallx + j, wally + i).SetState(Cell.State.Wall);
                    }
                }
            }

            return myGrid;
        }
        private static string Sanitise(string var)
        {
            var = var.Replace(" ", string.Empty);
            var = var.Replace("(", string.Empty);
            var = var.Replace(")", string.Empty);
            var = var.Replace("[", string.Empty);
            var = var.Replace("]", string.Empty);

            return var;
        }
    }
}
