using System;
using Chess.Core;

namespace Chess.Engine
{
    class GameEngine 
    {
        private readonly IGameInitializer GameInitializer;
        public readonly Board GameBoard; 

        private Player CurrentPlayer = Player.White;

        private PlayerInfo White = new PlayerInfo();
        private PlayerInfo Black = new PlayerInfo();

        public GameEngine(IGameInitializer gameInitializer)
        {
            this.GameInitializer = gameInitializer;
            GameBoard = new Board(gameInitializer);
        }


        private void StartGame()
        {

        }


        private GameMove PlayTurn()
        {
            Console.WriteLine($" {CurrentPlayer}'s turn (make a move) From: ");
            var from = Console.ReadLine();
            Console.WriteLine($" {CurrentPlayer}'s turn (make a move) To: ");
            var to = Console.ReadLine();

          //TODO  new GameMove { From = from, }
        }


        public (int,int) ParseInputToMove(string move)
        {
            if(move.Length != 2)
            {
                // TODO invalidmove
            } 
            char letter = move[0];
            char digit = move[1];
            if(!Char.IsLetter(letter))
            {
                //TODO: Invalid move
            }

            if(!Char.IsDigit(digit))
            {
                //TODO Invalid move
            }
            return ('a' - letter, //TODO int.Parse(digit) );
        }
    }
}