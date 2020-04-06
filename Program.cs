using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Program
    {
        static void Main()
        {

            //myGrid.GetCell(0, 0).setState(Cell.State.Wall);
            //myGrid.GetCell(0, 1).setState(Cell.State.Wall);
            //myGrid.GetCell(8, 8).setState(Cell.State.Wall);
            //myGrid.GetCell(7, 3).setState(Cell.State.Goal);
            //myGrid.GetCell(4, 3).setState(Cell.State.Agent);

            Grid myGrid = ReadGrid.Read();
            Console.WriteLine("Rows: " + myGrid.Rows.ToString() + " Columns: " + myGrid.Columns.ToString());

            Console.WriteLine(myGrid.ConsoleGrid());
        }
    }
}
