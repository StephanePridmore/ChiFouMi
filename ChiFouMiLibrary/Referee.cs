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
    }
}
