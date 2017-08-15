using ChiFouMiLibrary;

namespace ChiFouMiLibrary.Interfaces
{
    public interface ICommandParser
    {
        Shake Parse(string command);
    }
}