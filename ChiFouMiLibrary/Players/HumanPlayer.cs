using System;
using ChiFouMiLibrary.Interfaces;
using ChiFouMiLibrary.Parsers;

namespace ChiFouMiLibrary.Players
{
    public class HumanPlayer : IPlayer
    {
        private ICommandParser _parser;

        public HumanPlayer(ICommandParser parser)
        {
            _parser = parser;
        }

        public Shake Play()
        {
            return _parser.Parse(Console.ReadLine());
        }
    }
}
