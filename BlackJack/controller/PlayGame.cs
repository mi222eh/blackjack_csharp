using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackJack.model;

namespace BlackJack.controller
{
    class PlayGame: ISubject
    {
        private view.IView _view;

        public bool Play(model.Game a_game, view.IView a_view)
        {
            
            a_view.DisplayWelcomeMessage();
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            int input = a_view.GetInput();

            if (input == (int)view.Controls.NewGame)
            {
                _view = a_view;
                a_game.addSubject(this);
                a_game.NewGame();
                
            }
            else if (input == (int)view.Controls.Hit)
            {
                a_game.Hit();
            }
            else if (input == (int)view.Controls.Stand)
            {
                a_game.Stand();
            }

            return input != (int)view.Controls.Quit;
        }

        public void recieveNewCard(Card card)
        {
            _view.addAddedCard(card);
        }
    }
}
