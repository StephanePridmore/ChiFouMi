using System;
using System.Runtime.Serialization;
using ChiFouMiLibrary.Exceptions;
using ChiFouMiLibrary.Interfaces;

namespace ChiFouMiLibrary.Parsers
{
    public class CommandParser : ICommandParser
    {
        public Shake Parse(string command)
        {
            switch (command.ToUpper())
            {
                case "S":
                    return Shake.Scissors;
                case "P":
                    return Shake.Paper;
                case "R":
                    return Shake.Rock;
                case "Q":
                    throw new TimeToLeaveException("Time to stop and go back to work");
                default:
                    throw new CommandException("Unrecognized command");
            }
        }
    }
}
