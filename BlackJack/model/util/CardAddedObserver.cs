using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.util
{
    class CardAddedObserver
    {
        Card cardAdded;

        public void setCardIsAdded(Card c)
        {
            cardAdded = c;
        }

        public bool isCardAdded(Card c)
        {
            if (cardAdded != null)
            {
                if ((c.GetColor() == cardAdded.GetColor()) && (c.GetValue() == cardAdded.GetValue()))
                {
                    cardAdded = null;
                    return true;
                }
            }
            
            return false;
        }
    }
}
