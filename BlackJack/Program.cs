using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            model.util.CardAddedObserver ob = new model.util.CardAddedObserver();
            model.Game g = new model.Game();
            view.IView v = new view.SwedishView(); // new view.SwedishView();
            controller.PlayGame ctrl = new controller.PlayGame();

            g.attachObserver(ob);
            v.addObserver(ob);

            while (ctrl.Play(g, v));
        }
    }
}
