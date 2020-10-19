using System;
namespace TicTacToe
{
    public class Position
    {
        public int row { get; }
        public int column { get; }
        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}
