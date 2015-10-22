using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BlackJack.view.pauseHands
{
    class PauseHands : IPauseHands
    {
        private const int sleepTime = 1000;
        public void pause()
        {
            Thread.Sleep(sleepTime);
        }
    }
}
