using Chess.Model;

namespace Chess.Core
{
    class Board 
    {
         public const  uint WIDTH = 8;
         public const uint HEIGHT = 8;

        private readonly Piece[][] Pieces = new Piece[WIDTH][];


        public Board()
        {
            InitializeBoard();
        }

        //Initialize Game board for a new game
        private void InitializeBoard()
        {
            for(uint i = 0; i < WIDTH; ++i)
            {
                Pieces[i] = new Piece[HEIGHT];
            }
        }
    }
}