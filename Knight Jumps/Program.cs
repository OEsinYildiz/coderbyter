using System;
using System.Collections.Generic;

namespace Knight_Jumps
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "(2 8)";

            var arr = str.Trim('(',')').Split(' ');
            int x = Convert.ToInt32(arr[0]);
            int y = Convert.ToInt32(arr[1]);
            //Board.CreateBord();
            //Cell[,] board = Board.TheGrid;
            Cell cell = new Cell(x,y);
            //var currentCell = cell.Position = true;
            //TODO: Konum ve doluluk bilgisini dictionary içerisinde yazabilirsin
            Cell[] knight = new Knight().Moves;
           
           var result = Knight.IsInTheBoard(cell, knight);
           Console.WriteLine(result);
        }
    }

    /*public class Board
    {
        public static Cell[,] TheGrid { get; set; }

        /*internal static void CreateBord()
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    TheGrid = new Cell[i, j];
                }
            }
        }#1#
    }*/

    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        //public bool Position { get; set; }

        public Cell(int x, int y)
        {
            Row = x;
            Column = y;
        }
    }

    public class Knight
    {
        public Cell[] Moves = new Cell[]
        {
            new Cell(1, 2),
            new(2, 1),
            new(1, -2),
            new(-2, 1),
            new(2, -1),
            new(-1, 2),
            new(-1, -2),
            new(-2, -1),
        };

        internal static int IsInTheBoard(Cell cell, Cell[] knight)
        {
            
            int count = 0;
            for (int i = 0; i <knight.Length ; i++)
            {
               //var test = board[cell.Row + knight[i].Row, cell.Column + knight[i].Column];
               var insideRow= 1 <= cell.Row + knight[i].Row && cell.Row + knight[i].Row <= 8;
               var insideCol= 1 <= cell.Column + knight[i].Column && cell.Column + knight[i].Column <= 8;
               if (insideCol && insideRow)
               {
                   count++;
               }
            }

            return count;

        }
    }
}