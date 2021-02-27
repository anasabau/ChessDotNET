using Chess.Model;

namespace Chess.Core 
{
    class Square 
    {
        public Piece Piece;
        public Color Color {get;}

        Square(Color color)
        {
            Color = color;
        }
    }
}