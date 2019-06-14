using System;
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

            this.view.H += View_H;
            this.view.S += View_S;
            





        }

        public Presenter()
        {
        }

        private void View_S()
        {
            throw new NotImplementedException();
        }

        private void View_H()
        {
            throw new NotImplementedException();
        }
    }
}
