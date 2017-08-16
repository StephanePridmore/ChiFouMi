using ChiFouMiLibrary.Helpers;
using ChiFouMiLibrary.Interfaces;

namespace ChiFouMiLibrary
{
    public class Referee
    {
        private IPlayer _firstPlayer;
        private IPlayer _secondPlayer;

        public Referee(IPlayer firstPlayer, IPlayer secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;
        }

        public int FirstPlayerWins { get; set; }
        public int SecondPlayerWins { get; set; }

        public void PlayNewGame()
        {
            var firstPlayerShake = HandShakeHelper.ResolveHandShakeByShake(_firstPlayer.Play());
            var secondPlayerShake = HandShakeHelper.ResolveHandShakeByShake(_secondPlayer.Play());

            if (firstPlayerShake.WinAgaints == secondPlayerShake.Shake)
            {
                FirstPlayerWins++;
            }
            else if (secondPlayerShake.WinAgaints == firstPlayerShake.Shake)
            {
                SecondPlayerWins++;
            }
        }
    }
}
