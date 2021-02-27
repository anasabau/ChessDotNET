namespace Chess.Exception
{
    class InvalidMoveException : System.Exception
    {
        public InvalidMoveException(string message) : base(message) {}
    }
}