using Chess.Core;

namespace Chess.Engine
{
    class GameEngine 
    {

        public readonly Board GameBoard; 

        public GameEngine(Board gameBoard)
        {
            GameBoard = gameBoard;
        }
    }
}