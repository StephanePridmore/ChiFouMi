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
    }
}
