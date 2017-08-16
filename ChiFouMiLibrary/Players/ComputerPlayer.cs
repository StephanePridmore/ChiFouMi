using System;
using ChiFouMiLibrary.Interfaces;

namespace ChiFouMiLibrary.Players
{
    public class ComputerPlayer : IPlayer
    {
        private IHandShakeGenerator _handShakeGenerator;

        public ComputerPlayer()
        {
            _handShakeGenerator = new HandShakeGenerator();
        }

        public ComputerPlayer(IHandShakeGenerator generator)
        {
            _handShakeGenerator = generator;
        }

        public Shake Play()
        {
            return _handShakeGenerator.GenerateHandShake();
        }
    }
}
