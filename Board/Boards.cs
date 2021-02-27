using Chess.Piece;

namespace Chess
{
    class ChessBoard 
    {
         public const  uint WIDTH = 8;
         public const uint HEIGHT = 8;

        private readonly BasePiece[][] Board = new BasePiece[WIDTH][];


        public ChessBoard()
        {
            InitializeBoard();
        }

        //Initialize Game board for a new game
        private void InitializeBoard()
        {
            for(uint i = 0; i < WIDTH; ++i)
            {
                Board[i] = new BasePiece[HEIGHT];
            }
        }
    }
}