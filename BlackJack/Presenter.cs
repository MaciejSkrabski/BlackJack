﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Presenter
    {
        ITableView view;
        Game game;

        public Presenter(ITableView view, Game game)

        {
            this.view = view;
            this.game = game;

            this.view.H += this.game.getHit();






        }
        

    }
}
