using ChiFouMiLibrary;
using ChiFouMiLibrary.Exceptions;
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
            Check.That(HandShakeHelper.GameShakes.Count()).Equals(3);
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
        public void ShouldGeneratePaperHandShakeWhenComputerPlays()
        {
            Check.That(Context.ComputerPlaysPaperHandShake()).Equals(Shake.Paper);
        }

        [Test]
        public void ShouldGenerateRockHandShakeWhenComputerPlays()
        {
            Check.That(Context.ComputerPlaysRockHandShake()).Equals(Shake.Rock);
        }

        [Test]
        public void ShouldGenerateScissorsHandShakeWhenComputerPlays()
        {
            Check.That(Context.ComputerPlaysScissorsHandShake()).Equals(Shake.Scissors);
        }

        [Test]
        public void ShouldGeneratePaperHandShakeWhenHumanPlays()
        {
            Check.That(Context.HumanPlaysPaperHandShake()).Equals(Shake.Paper);
        }

        [Test]
        public void ShouldGenerateRockHandShakeWhenHumanPlays()
        {
            Check.That(Context.HumanPlaysRockHandShake()).Equals(Shake.Rock);
        }

        [Test]
        public void ShouldGenerateScissorsHandShakeWhenHumanPlays()
        {
            Check.That(Context.HumanPlaysScissorsHandShake()).Equals(Shake.Scissors);
        }

        [Test]
        public void ShouldReturnScissorsWhenCommandIsR()
        {
            Check.That(Context.ParseCommand("R")).Equals(Shake.Rock);
        }

        [Test]
        public void ShouldReturnPaperWhenCommandIsP()
        {
            Check.That(Context.ParseCommand("P")).Equals(Shake.Paper);
        }

        [Test]
        public void ShouldReturnRockWhenCommandIsS()
        {
            Check.That(Context.ParseCommand("S")).Equals(Shake.Scissors);
        }

        [Test]
        public void ShouldThrowAnExceptionWhenCommandIsSomethingElse()
        {
            Check.ThatCode(() => { return new CommandParser().Parse("W"); }).Throws<CommandException>();
        }

        [Test]
        public void ShouldPlayerWinsAreEqualToZeroWhenGameStarts()
        {
            Check.That(Context.CheckThatWinsAreEqualToZeroWhenGameStarts()).Equals(true);
        }

        [Test]
        public void ShouldFirstPlayerWinWhenPlayIsRockVsScissors()
        {
            // Act
            Context.Play(Shake.Rock, Shake.Scissors);

            // Assert
            Check.That(Context.Referee.FirstPlayerWins).Equals(1);
            Check.That(Context.Referee.SecondPlayerWins).Equals(0);
        }

        [Test]
        public void ShouldSecondPlayerWinWhenPlayIsPaperVsScissors()
        {
            // Act
            Context.Play(Shake.Paper, Shake.Scissors);

            // Assert
            Check.That(Context.Referee.FirstPlayerWins).Equals(0);
            Check.That(Context.Referee.SecondPlayerWins).Equals(1);
        }

        [Test]
        public void ShouldNoPlayerWinWhenPlayIsPaperVsPaper()
        {
            // Act
            Context.Play(Shake.Paper, Shake.Paper);

            // Assert
            Check.That(Context.Referee.FirstPlayerWins).Equals(0);
            Check.That(Context.Referee.SecondPlayerWins).Equals(0);
        }

        [Test]
        public void ShouldFirstPlayerWinThreeToZero()
        {
            // Act
            Context.Play(Shake.Paper, Shake.Rock);
            Context.Play(Shake.Paper, Shake.Rock);
            Context.Play(Shake.Scissors, Shake.Paper);

            // Assert
            Check.That(Context.Referee.FirstPlayerWins).Equals(3);
            Check.That(Context.Referee.SecondPlayerWins).Equals(0);
        }

        [Test]
        public void ShouldThrowATimeToLeaveExceptionWhenCommandIsQ()
        {
            // Act
            Context.InsertQuitCommand();

            // Assert
            Check.ThatCode(() => { Context.Referee.PlayNewGame(); }).Throws<TimeToLeaveException>();
        }
    }
}
