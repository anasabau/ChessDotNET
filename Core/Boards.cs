using Chess.Piece;

namespace Chess.Core
{
    class Board 
    {
         public const  uint WIDTH = 8;
         public const uint HEIGHT = 8;

        private readonly BasePiece[][] Pieces = new BasePiece[WIDTH][];


        public Board()
        {
            InitializeBoard();
        }

        //Initialize Game board for a new game
        private void InitializeBoard()
        {
            for(uint i = 0; i < WIDTH; ++i)
            {
                Pieces[i] = new BasePiece[HEIGHT];
            }
        }
    }
}