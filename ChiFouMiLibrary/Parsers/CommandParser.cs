using System;
using ChiFouMiLibrary.Exceptions;
using ChiFouMiLibrary.Interfaces;

namespace ChiFouMiLibrary.Parsers
{
    public class CommandParser : ICommandParser
    {
        public Shake Parse(string command)
        {
            throw new CommandException();
        }
    }
}
