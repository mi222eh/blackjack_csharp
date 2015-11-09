using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    interface IObserver
    {
        void cardAdded(model.Card card);
        void addSubject(ISubject sub);
    }
}
