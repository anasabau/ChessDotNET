namespace Chess.Piece
{
    public abstract class BasePiece
    {
        private protected (uint,uint) Position;
        public readonly PieceColor Color;
        protected BasePiece(PieceColor color)
        {
            Color = color;
        }

        public abstract bool IsValidMove(uint x, uint y);

        public (uint,uint)  Move(uint x, uint y)
        {
            if ( x > ChessBoard.HEIGHT || y > ChessBoard.WIDTH)
            {
                throw new Chess.Exception.OutsideOfBoardException($"Cannot move {this.GetType().Name} at {x},{y}; Outside the board");
            }
            if (IsValidMove(x,y)) 
            {
                this.Position.Item1 = x;
                this.Position.Item2 = y;
                return (x,y);
            }
            throw new Chess.Exception.InvalidMoveException($"Moving {this.GetType().Name} from {Position.Item1},{Position.Item2} to {x},{y} is not valid");
        }
    }
}