using Chess.Core;

namespace Chess.Engine
{
    interface IGameInitializer
    {
        Square[][] Initialize();
    }
}