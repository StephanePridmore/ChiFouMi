using ChiFouMiLibrary.Interfaces;
using System;

namespace ChiFouMiLibrary.Helpers
{
    public static class OutputHelper
    {
        public static void PrintHelp()
        {
            Console.WriteLine("Commands are :");
            Console.WriteLine("r => Rock");
            Console.WriteLine("p => Paper");
            Console.WriteLine("s => Scissors");
            Console.WriteLine("q => quit");
            Console.WriteLine();
        }

        public static void Shakes(Shake firstPlayer, Shake secondPlayer)
        {
            Console.WriteLine($"{firstPlayer} vs {secondPlayer}");
        }

        public static void PlayerWins(string player)
        {
            Console.WriteLine($"{player} wins!!!");
        }

        public static void Draw()
        {
            Console.WriteLine($"Draw.. Sorry no winners this time.");
        }

        public static void NewGame()
        {
            Console.WriteLine($"Play!");
        }

        public static void GameStarting()
        {
            Console.WriteLine($"Welcome to Rock, Paper, Scissors!!");
            Console.WriteLine();
        }
        
        public static void GameScore(int firstPlayerScore, int secondPlayerScore)
        {
            Console.WriteLine($"First player has {firstPlayerScore}");
            Console.WriteLine($"Second player has {secondPlayerScore}");
            Console.WriteLine(); 
        }
        
        public static void SomethingOddHappened()
        {
            Console.WriteLine($"An unexpected error occured...");
            Console.WriteLine($"Never mind :) continue playing");
            Console.WriteLine();
        }

        public static void PrintExceptionMessage()
        {
            Console.WriteLine("Unrecognized command!! ");
            Console.WriteLine();
        }
    }
}
