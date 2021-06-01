using Chess.Engine;
using Chess.Model;

namespace Chess.Core
{
    class Board 
    {
        private readonly Square[][] Pieces ;
        public Board(IGameInitializer gameInitializer)
        {
            Pieces = gameInitializer.Initialize();
        }
    }
}