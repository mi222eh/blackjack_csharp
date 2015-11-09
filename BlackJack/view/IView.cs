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
        void addAddedCard(model.Card cardAdded);
        void DisplayGameOver(bool a_dealerIsWinner);
    }
}
