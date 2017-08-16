using ChiFouMiLibrary.Exceptions;
using ChiFouMiLibrary.Helpers;
using ChiFouMiLibrary.Interfaces;
using System;

namespace ChiFouMiLibrary
{
    public class Referee
    {
        private IPlayer _firstPlayer;
        private IPlayer _secondPlayer;

        public Referee(IPlayer firstPlayer, IPlayer secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;
        }

        public int FirstPlayerWins { get; set; }
        public int SecondPlayerWins { get; set; }

        public void StartPlaying()
        {
            OutputHelper.GameStarting();
            OutputHelper.PrintHelp();

            while (true)
            {
                try
                {
                    OutputHelper.NewGame();
                    PlayNewGame();
                    OutputHelper.GameScore(FirstPlayerWins, SecondPlayerWins);
                }
                catch (CommandException)
                {
                    OutputHelper.PrintExceptionMessage();
                    OutputHelper.PrintHelp();
                }
                catch (TimeToLeaveException)
                {
                    break;
                }
                catch (Exception)
                {
                    OutputHelper.SomethingOddHappened();
                }
            }
        }

        public void PlayNewGame()
        {
            var firstPlayerShake = HandShakeHelper.ResolveHandShakeByShake(_firstPlayer.Play());
            var secondPlayerShake = HandShakeHelper.ResolveHandShakeByShake(_secondPlayer.Play());

            if (firstPlayerShake.WinAgaints == secondPlayerShake.Shake)
            {
                FirstPlayerWins++;
                OutputHelper.Shakes(firstPlayerShake.Shake, secondPlayerShake.Shake);
                OutputHelper.PlayerWins("First");
            }
            else if (secondPlayerShake.WinAgaints == firstPlayerShake.Shake)
            {
                SecondPlayerWins++;
                OutputHelper.Shakes(firstPlayerShake.Shake, secondPlayerShake.Shake);
                OutputHelper.PlayerWins("Second");
            }
            else
            {
                OutputHelper.Draw();
            }
        }
    }
}
