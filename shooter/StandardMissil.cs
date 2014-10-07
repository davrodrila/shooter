using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using shooter.Interfaces;

namespace shooter
{
    class StandardMissil : IMissil
    {
        private int delay;
        
        int IMissil.Delay
        {
            get { return delay; }
        }
    }
}
