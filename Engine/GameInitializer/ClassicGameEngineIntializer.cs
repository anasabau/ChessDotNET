using Chess.Core;
using Chess.Model;

namespace Chess.Engine {

    class ClassicGameEngineIntializer : IGameInitializer
    {
        private Square[][] GameBoard;

        public Square[][] Initialize()
        {
            this.CleanBoard().SetPawns()
                             .SetRooks()
                             .SetBishops()
                             .SetKnights()
                             .SetQueens()
                             .SetKings();

            return GameBoard;
        }

        private ClassicGameEngineIntializer SetPawns() 
        {            
            for(int i = 0; i <= 8; i++)
            {
                // initialize black pawns
                GameBoard[1][i].Piece = new Piece(Color.Black, PieceType.Pawn);

                //initialize white pawn
                GameBoard[6][i].Piece = new Piece(Color.White, PieceType.Pawn);
            }
            return this;
        }

        private ClassicGameEngineIntializer CleanBoard() 
        {
            for(int i = 0; i < 8; i ++) GameBoard[i] = new Square[8];

            return this;
        }

        private ClassicGameEngineIntializer SetRooks() 
        {
            // black
            GameBoard[0][0].Piece = new Piece(Color.Black, PieceType.Rook);
            GameBoard[0][7].Piece = new Piece(Color.Black, PieceType.Rook);

            //white 
            GameBoard[7][0].Piece = new Piece(Color.White, PieceType.Rook);
            GameBoard[7][7].Piece = new Piece(Color.White, PieceType.Rook);

            return this;
        }

        private ClassicGameEngineIntializer SetKnights() 
        {
            // black
            GameBoard[0][1].Piece = new Piece(Color.Black, PieceType.Knight);
            GameBoard[0][6].Piece = new Piece(Color.Black, PieceType.Knight);

            //white 
            GameBoard[7][1].Piece = new Piece(Color.White, PieceType.Knight);
            GameBoard[7][6].Piece = new Piece(Color.White, PieceType.Knight);

            return this;
        }

        private ClassicGameEngineIntializer SetBishops() 
        {
            // black
            GameBoard[0][2].Piece = new Piece(Color.Black, PieceType.Bishop);
            GameBoard[0][5].Piece = new Piece(Color.Black, PieceType.Bishop);

            //white 
            GameBoard[7][2].Piece = new Piece(Color.White, PieceType.Bishop);
            GameBoard[7][5].Piece = new Piece(Color.White, PieceType.Bishop);

            return this;
        }

        private ClassicGameEngineIntializer SetQueens() 
        {
            // black
            GameBoard[0][3].Piece = new Piece(Color.Black, PieceType.Queen);

            //white 
            GameBoard[7][3].Piece = new Piece(Color.White, PieceType.Bishop);

            return this;
        }

        private ClassicGameEngineIntializer SetKings() 
        {
            // black
            GameBoard[0][4].Piece = new Piece(Color.Black, PieceType.King);

            //white 
            GameBoard[7][4].Piece = new Piece(Color.White, PieceType.King);

            return this;
        }
    }
}