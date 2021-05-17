using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TicTacToe");
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
            game.Choice();
        }
    }
}