using Chess.Core;
using Chess.Model;

namespace Chess.Engine
{
    class GameMove
    {
        public readonly Player Player;
        public readonly (int,int) From;
        public readonly (int,int) To;
        public readonly Piece Piece;
        public readonly Piece Taken;

        public GameMove(Player player, (int,int) to, (int,int) from, Piece piece, Piece taken = null)
        {
            Player = player;
            To = to;
            From = from;
            Piece = piece;
            Taken = taken;
        }
    }
}
