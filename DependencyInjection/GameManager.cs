﻿namespace DependencyInjection
{
    public class GameManager
    {
        private IPlayer _player1;
        private IPlayer _player2;

        public GameManager(IPlayer player1, IPlayer player2) 
        {
            _player1 = player1;
            _player2 = player2;
        }
        public RoundResult PlayRound()
        {
            Choice p1 = _player1.GetChoice();
            Choice p2 = _player2.GetChoice();

            Console.WriteLine($"Player1 picks {p1.ToString()} and Player2 picks {p2.ToString()}");
            if(p1 == p2)
            {
                return RoundResult.Draw;
            }

            if (p1 == Choice.Rock && p2 == Choice.Scissors ||
                p1 == Choice.Paper && p2 == Choice.Rock ||
                p1 == Choice.Scissors && p2 == Choice.Paper) 
            {
                return RoundResult.Player1Win;
            }

            return RoundResult.Player2Win;
        }
    }

    public enum Choice
    {
        Rock, 
        Paper, 
        Scissors
    }

    public enum RoundResult
    {
        Player1Win, 
        Player2Win,
        Draw
    }
}
