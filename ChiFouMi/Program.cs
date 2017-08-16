using ChiFouMiLibrary;
using ChiFouMiLibrary.Parsers;
using ChiFouMiLibrary.Players;

namespace ChiFouMi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Referee(
                new ComputerPlayer(), 
                new HumanPlayer()
            ).StartPlaying();
        }
    }
}
