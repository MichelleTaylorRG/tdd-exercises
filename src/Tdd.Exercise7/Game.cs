using System.Collections.Generic;
using System.Linq;

namespace Tdd.Exercise7
{
    public class Game
    {
        private readonly Round _round;

        public Game(Round round)
        {
            _round = round;
        }

        public GameResult Play(IPlayer player1, IPlayer player2)
        {
            var roundCount = 0;

            while (roundCount < 3 || (player1.Wins == player2.Wins))
            {
                roundCount++;

                var winner = _round.Play(player1, player2);
                switch (winner)
                {
                    case Winner.Player1:
                        player1.Wins++;
                        break;
                    case Winner.Player2:
                        player2.Wins++;
                        break;
                }
            }

            var winningPlayer = player1.Wins > player2.Wins ? player1 : player2;

            return new GameResult(roundCount, winningPlayer);
        }
    }
}