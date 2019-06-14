using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    interface ITableView
    {
        int CardsLeft { get; }

        string CroupiersHand { set; }
        string PlayersHand { set; }
        int CroupiersHandValue { get; set; }
        int PlayersHandValue { get; set; }
        event Action H;
        event Action S;

    }
}
