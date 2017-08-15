using ChiFouMiLibrary.Interfaces;
using System;

namespace ChiFouMiLibrary
{
    public class ConsoleWrapper : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
