using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using shooter.Interfaces;

namespace shooter
{
    class EmptyMissil : IMissil
    {
        private int delay = 0;
        public int IMissil.Delay
        {
            get { return delay; }
        }
    }
}
