using ChiFouMiLibrary;
using ChiFouMiLibrary.Parsers;
using NFluent;
using NUnit.Framework;
using System;

namespace ChiFouMiTest
{
    class ChiFouMiTests
    {
        public ChiFouMiContext Context;

        [SetUp]
        public void Setup()
        {
            Context = new ChiFouMiContext();
        }

        [Test]
        public void ShouldShakeValueEqualRockPaperScissors()
        {
            Check.That(Enum.GetNames(typeof(Shake))).ContainsExactly("Rock", "Paper", "Scissors");
        }

        [Test]
        public void ShouldGameShakesHaveThreeHandShakes()
        {
            Check.That(new HandShakes().GameShakes.Count()).Equals(3);
        }

        [Test]
        public void ShouldPaperShakeWinAgaintsRock()
        {
            Check.That(Context.PaperShake.WinAgaints).Equals(Shake.Rock);
        }

        [Test]
        public void ShouldRockShakeWinAgaintsScissors()
        {
            Check.That(Context.RockShake.WinAgaints).Equals(Shake.Scissors);
        }

        [Test]
        public void ShouldScissorsShakeWinAgaintsPaper()
        {
            Check.That(Context.ScissorsShake.WinAgaints).Equals(Shake.Paper);
        }

        [Test]
        public void ShouldGeneratePaperHandShake()
        {
            Check.That(Context.PlayPaperHandShake()).Equals(Shake.Paper);
        }

        [Test]
        public void ShouldGenerateRockHandShake()
        {
            Check.That(Context.PlayRockHandShake()).Equals(Shake.Rock);
        }

        [Test]
        public void ShouldGenerateScissorsHandShake()
        {
            Check.That(Context.PlayScissorsHandShake()).Equals(Shake.Scissors);
        }

        [Test]
        public void ShouldReturnScissorsWhenCommandIsS()
        {
            Check.That(Context.ParseCommand("R")).Equals(Shake.Rock);
        }

        [Test]
        public void ShouldReturnPaperWhenCommandIsP()
        {
            Check.That(Context.ParseCommand("P")).Equals(Shake.Paper);
        }

        [Test]
        public void ShouldReturnRockWhenCommandIsR()
        {
            Check.That(Context.ParseCommand("S")).Equals(Shake.Scissors);
        }
    }
}
