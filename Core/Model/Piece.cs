using Chess.Exception;

namespace Chess.Model
{
    // Piece is the base, abstarct class for all concrete pieces
    public class Piece
    { 
        public readonly Color Color;

        public readonly PieceType Type;
        protected Piece(Color color, PieceType type)
        {
            Color = color;
            Type = type;
        }


    }
}