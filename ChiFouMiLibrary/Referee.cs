using ChiFouMiLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
