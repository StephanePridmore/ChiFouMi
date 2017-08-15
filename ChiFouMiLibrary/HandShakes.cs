namespace ChiFouMiLibrary
{
    public class HandShakes
    {
        private HandShake[] _gameShakes = new HandShake[]
            {
                new HandShake(Shake.Paper, Shake.Rock),
                new HandShake(Shake.Rock, Shake.Scissors),
                new HandShake(Shake.Scissors, Shake.Paper)
            };

        public HandShake[] GameShakes
        {
            get
            {
                return _gameShakes;
            }
        }
    }
}
