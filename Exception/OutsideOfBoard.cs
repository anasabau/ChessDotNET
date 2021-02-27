
namespace Chess.Exception
{
    public class OutsideOfBoardException : System.Exception
    {
        public OutsideOfBoardException(string message) : base(message){}
    }
}