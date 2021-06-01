using Chess.Model;

namespace Chess.Core
{
    class Board 
    {
         public const  uint WIDTH = 8;
         public const uint HEIGHT = 8;

        private readonly Square[][] Pieces = new Square[WIDTH][];


        public Board()
        {
            InitializeBoard();
        }

        //Initialize Game board for a new game
        private void InitializeBoard()
        {
        }
    }
}