using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    enum Controls
    {
        NewGame = 'p',
        Hit = 'h',
        Stand = 's',
        Quit = 'q'
    }
    interface IView
    {
        void DisplayWelcomeMessage();
        int GetInput();
        
        void DisplayCard(model.Card a_card);
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void addObserver(model.util.CardAddedObserver ob);
        
        void DisplayGameOver(bool a_dealerIsWinner);
    }
}
