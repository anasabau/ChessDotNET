using Chess.Model;

namespace Chess.Core 
{
    class Square 
    {
        public Piece Piece {get; set;}
        public Color Color {get;}

        public readonly int Age;
        Square(Color color)
        {
            Color = color;
        }

        Square(Color color, Piece piece) : this(color)
        {
            Piece = piece;
        }
    }
}