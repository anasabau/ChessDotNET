namespace Chess.Core
{
    class Player 
    {
        public bool IsInChess {get; set;} = false;
        public readonly Color PlayerColor;
        Player(Color color)
        {
            this.PlayerColor = color;
        }
    }
}