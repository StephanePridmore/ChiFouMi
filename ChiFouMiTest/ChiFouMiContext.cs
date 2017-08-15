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
        private IConsole _console;

        public ChiFouMiContext()
        {
            _generator = Substitute.For<IHandShakeGenerator>();
            _console = Substitute.For<IConsole>();
            _parser = new CommandParser();
            HumanPlayer = new HumanPlayer(_parser, _console);
            ComputerPlayer = new ComputerPlayer(_generator);
        }

        public ComputerPlayer ComputerPlayer { get; set; }

        public HumanPlayer HumanPlayer { get; set; }

        public HandShake PaperShake => new HandShake(Shake.Paper, Shake.Rock);

        public HandShake RockShake => new HandShake(Shake.Rock, Shake.Scissors);

        public HandShake ScissorsShake => new HandShake(Shake.Scissors, Shake.Paper);

        public Shake ComputerPlaysPaperHandShake()
        {
            _generator.GenerateHandShake().Returns(Shake.Paper);
            return ComputerPlayer.Play();
        }

        public Shake ComputerPlaysRockHandShake()
        {
            _generator.GenerateHandShake().Returns(Shake.Rock);
            return ComputerPlayer.Play();
        }

        public Shake ComputerPlaysScissorsHandShake()
        {
            _generator.GenerateHandShake().Returns(Shake.Scissors);
            return ComputerPlayer.Play();
        }

        public Shake HumanPlaysPaperHandShake()
        {
            _console.ReadLine().Returns("p");
            return HumanPlayer.Play();
        }

        public Shake HumanPlaysRockHandShake()
        {
            _console.ReadLine().Returns("r");
            return HumanPlayer.Play();
        }

        public Shake HumanPlaysScissorsHandShake()
        {
            _console.ReadLine().Returns("s");
            return HumanPlayer.Play();
        }

        public Shake ParseCommand(string command)
        {
            return _parser.Parse(command);
        }
    }
}
