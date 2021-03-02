using Chess.Exception;

namespace Chess.Model
{
    // Piece is the base, abstarct class for all concrete pieces
    public abstract class Piece
    { 
        public readonly Color Color;
        protected Piece(Color color)
        {
            Color = color;
        }

        // only determines if a move can be made by a certain piece
        // it doesn't mean that a valid move is also permited in all concrete circumstances
        // that is determined by game engine
        public abstract bool IsValidMove(uint x, uint y);
    }
}