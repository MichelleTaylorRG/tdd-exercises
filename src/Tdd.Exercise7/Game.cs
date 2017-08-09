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
            var wins = new Dictionary<IPlayer, int>
            {
                {player1, 0},
                {player2, 0},
            };

            var roundCount = 0;

            while (roundCount < 3 || wins.Values.Distinct().Count() == 1)
            {
                roundCount++;

                var winner = _round.Play(player1, player2);
                switch (winner)
                {
                    case Winner.Player1:
                        wins[player1]++;
                        break;
                    case Winner.Player2:
                        wins[player2]++;
                        break;
                }
            }

            var winningPlayer = wins.OrderByDescending(pair => pair.Value).First().Key;

            return new GameResult(roundCount, winningPlayer);
        }
    }
}