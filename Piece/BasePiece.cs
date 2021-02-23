namespace Chess.Piece
{
    public abstract class BasePiece
    {
        public readonly Color PieceColor;
        BasePiece(Color color)
        {
            this.PieceColor = color;
        }
    }
}