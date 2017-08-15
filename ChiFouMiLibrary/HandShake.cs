using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiFouMiLibrary
{
    public class HandShake
    {
        public HandShake(Shake shake, Shake winAgaints)
        {
            Shake = shake;
            WinAgaints = winAgaints;
        }

        public Shake Shake { get; set; }

        public Shake WinAgaints { get; set; }
    }
}
