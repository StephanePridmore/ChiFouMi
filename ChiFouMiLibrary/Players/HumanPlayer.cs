using System;
using ChiFouMiLibrary.Interfaces;
using ChiFouMiLibrary.Parsers;

namespace ChiFouMiLibrary.Players
{
    public class HumanPlayer : IPlayer
    {
        private ICommandParser _parser;
        private IConsole _console;

        public HumanPlayer()
        {
            _parser = new CommandParser();
            _console = new ConsoleWrapper();
        }

        public HumanPlayer(ICommandParser parser, IConsole console)
        {
            _parser = parser;
            _console = console;
        }

        public Shake Play()
        {
            return _parser.Parse(_console.ReadLine());
        }
    }
}
