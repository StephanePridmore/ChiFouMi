using ChiFouMiLibrary.Interfaces;
using System;

namespace ChiFouMiLibrary
{
    public class HandShakeGenerator : IHandShakeGenerator
    {
        public Shake GenerateHandShake()
        {
            var random = new Random();
            var choice = random.Next(0, 2);

            if (choice == 0)
                return Shake.Paper;
            else if (choice == 1)
                return Shake.Rock;
            else
                return Shake.Scissors;
        }
    }
}
