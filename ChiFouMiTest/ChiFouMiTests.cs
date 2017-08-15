using ChiFouMiLibrary;
using NFluent;
using NUnit.Framework;
using System;

namespace ChiFouMiTest
{
    class ChiFouMiTests
    {
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
    }
}
