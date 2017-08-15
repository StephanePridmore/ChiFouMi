using ChiFouMiLibrary;
using ChiFouMiLibrary.Interfaces;
using ChiFouMiLibrary.Parsers;
using ChiFouMiLibrary.Players;
using NSubstitute;

namespace ChiFouMiTest
{
    public class ChiFouMiContext
    {
        private IHandShakeGenerator _generator;
        private ICommandParser _parser;

        public ChiFouMiContext()
        {
            _generator = Substitute.For<IHandShakeGenerator>();
            _parser = new CommandParser();
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

        public Shake ParseCommand(string command)
        {
            return _parser.Parse(command);
        }
    }
}
