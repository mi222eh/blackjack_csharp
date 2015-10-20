using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class Soft17 : IHitStrategy
    {
        private const int g_hitLimit = 17;
        public bool DoHit(Player a_dealer)
        {
            bool aceExist = false;
            bool hit = false;
            int score = a_dealer.CalcScore();
            IEnumerable<Card> cards = a_dealer.GetHand();
            foreach(Card c in cards){
                if(c.GetValue() == Card.Value.Ace){
                    aceExist = true;
                }
            }
            if(score < g_hitLimit){
                hit = true;
            }
            else if(aceExist && score == g_hitLimit){
                hit = true;
            }
            return hit;
        }
    }
}
