namespace Tdd.Exercise7
{
    public class Round
    {
        public Winner Play(IPlayer player1, IPlayer player2)
        {
            var hand1 = player1.RevealHand();
            var hand2 = player2.RevealHand();

            switch (hand1)
            {
                case Hand.Paper:
                    switch (hand2)
                    {
                        case Hand.Scissors:
                            return Winner.Player2;
                        case Hand.Rock:
                            return Winner.Player1;
                    }
                    break;
                case Hand.Rock:
                    switch (hand2)
                    {
                        case Hand.Paper:
                            return Winner.Player2;
                        case Hand.Scissors:
                            return Winner.Player1;
                    }
                    break;
                case Hand.Scissors:
                    switch (hand2)
                    {
                        case Hand.Rock:
                            return Winner.Player2;
                        case Hand.Paper:
                            return Winner.Player1;
                    }
                    break;
            }

            return Winner.None;
        }
    }
}