using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IWinRule
    {
        bool IsDealerWinner(Dealer m_dealer, Player a_player, int g_maxScore);
    }
}
