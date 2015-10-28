﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class PlayerWinnerRule : IWinRule
    {
        

        public bool IsDealerWinner(Dealer m_dealer, Player a_player, int g_maxScore)
        {
            if (a_player.CalcScore() > g_maxScore)
            {
                return true;
            }
            else if (m_dealer.CalcScore() > g_maxScore)
            {
                return false;
            }
            return m_dealer.CalcScore() > a_player.CalcScore();
        }
    }
}
