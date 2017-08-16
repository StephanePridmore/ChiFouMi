using System.Linq;

namespace ChiFouMiLibrary
{
    public static class HandShakeHelper
    {
        private static HandShake[] _gameShakes = new HandShake[]
            {
                new HandShake(Shake.Paper, Shake.Rock),
                new HandShake(Shake.Rock, Shake.Scissors),
                new HandShake(Shake.Scissors, Shake.Paper)
            };

        public static HandShake[] GameShakes
        {
            get
            {
                return _gameShakes;
            }
        }

        public static HandShake ResolveHandShakeByShake(Shake shake)
        {
            return _gameShakes.Where(x => x.Shake == shake).First();
        }
    }
}
