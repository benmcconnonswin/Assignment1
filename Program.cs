using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Program
    {
        static void Main()
        {
            Grid myGrid = ReadGrid.Read();
            Search mySearch = new Search(myGrid);

            Console.WriteLine("Rows: " + myGrid.Rows.ToString() + " Columns: " + myGrid.Columns.ToString());
            Console.WriteLine(mySearch.Grid.ConsoleGrid());

            mySearch.Move("right");
            mySearch.Move("down");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("right");
            mySearch.Move("down");
            mySearch.Move("down");
            mySearch.Move("down");
            mySearch.Move("down");
            Console.WriteLine(mySearch.Grid.ConsoleGrid());


        }
    }
}
