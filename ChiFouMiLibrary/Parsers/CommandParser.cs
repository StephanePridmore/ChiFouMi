using System;
using ChiFouMiLibrary.Exceptions;
using ChiFouMiLibrary.Interfaces;

namespace ChiFouMiLibrary.Parsers
{
    public class CommandParser : ICommandParser
    {
        public Shake Parse(string command)
        {
            if (command.ToUpper().Equals("S"))
            {
                return Shake.Scissors;
            }
            else if (command.ToUpper().Equals("P"))
            {
                return Shake.Paper;
            }
            else if (command.ToUpper().Equals("R"))
            {
                return Shake.Rock;
            }
            else
            {
                throw new CommandException("Unrecognized command");
            }
        }
    }
}
