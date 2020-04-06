using System;
using System.IO;

namespace Assignment1
{
    public class ReadGrid
    {
        static public Grid Read()
        {
            using var reader = new StreamReader("RobotNav-test.txt");

            var line = reader.ReadLine();
            var size = line.Split(',');
            string w = size[0].Remove(0,1);
            string r = size[1].Remove(size[1].Length - 1);
            Int32.TryParse(w, out int rows);
            Int32.TryParse(r, out int cols);

            Grid myGrid = new Grid(cols, rows);

            line = reader.ReadLine();
            var agent = line.Split(',');
            string agent1 = agent[0].Remove(0, 1);
            string agent2 = agent[1].Remove(agent[1].Length - 1);
            Int32.TryParse(agent1, out int agentx);
            Int32.TryParse(agent2, out int agenty);

            myGrid.GetCell(agentx, agenty).setState(Cell.State.Agent);


            return myGrid;
        }
    }
}
