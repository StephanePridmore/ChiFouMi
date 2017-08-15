using ChiFouMiLibrary;
using ChiFouMiLibrary.Interfaces;
using ChiFouMiLibrary.Players;
using NSubstitute;

namespace ChiFouMiTest
{
    public class ChiFouMiContext
    {
        private IHandShakeGenerator _generator;

        public ChiFouMiContext()
        {
            _generator = Substitute.For<IHandShakeGenerator>();
            ComputerPlayer = new ComputerPlayer(_generator);
        }

        public ComputerPlayer ComputerPlayer { get; set; }

        public HandShake PaperShake => new HandShake(Shake.Paper, Shake.Rock);

        public HandShake RockShake => new HandShake(Shake.Rock, Shake.Scissors);

        public HandShake ScissorsShake => new HandShake(Shake.Scissors, Shake.Paper);

        public Shake PlayPaperHandShake()
        {
            _generator.GenerateHandShake().Returns(Shake.Paper);
            return ComputerPlayer.Play();
        }

        public Shake PlayRockHandShake()
        {
            _generator.GenerateHandShake().Returns(Shake.Rock);
            return ComputerPlayer.Play();
        }

        public Shake PlayScissorsHandShake()
        {
            _generator.GenerateHandShake().Returns(Shake.Scissors);
            return ComputerPlayer.Play();
        }
    }
}
