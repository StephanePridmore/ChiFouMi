using ChiFouMiLibrary;

namespace ChiFouMiTest
{
    public class ChiFouMiContext
    {
        public HandShake PaperShake => new HandShake(Shake.Paper, Shake.Rock);

        public HandShake RockShake => new HandShake(Shake.Rock, Shake.Scissors);

        public HandShake ScissorsShake => new HandShake(Shake.Scissors, Shake.Paper);
    }
}
