﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class InternationalNewGameStrategy : INewGameStrategy
    {

        public bool NewGame(Dealer a_dealer, Player a_player)
        {
            //Card c;

            a_dealer.GetShowDeal(a_player, true);
            a_dealer.GetShowDeal(a_dealer, true);
            a_dealer.GetShowDeal(a_player, true);

            /*
            c = a_deck.GetCard();
            c.Show(true);
            a_player.DealCard(c);

            c = a_deck.GetCard();
            c.Show(true);
            a_dealer.DealCard(c);

            c = a_deck.GetCard();
            c.Show(true);
            a_player.DealCard(c);
             */ 

            return true;
        }
    }
}
