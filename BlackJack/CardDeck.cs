using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    class CardDeck
    {
        #region fields

        static List<int> deck = new List<int>();
        string[] figure = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        CardDeck o;

        #endregion fields

        #region methods

        public int getCardsLeft() { return deck.Count(); }

        protected CardDeck()
        {
            MessageBox.Show("CardDeck constructor");

        }
        
        protected string deal(int i)
        {
            return figure[deck.ElementAt(i)];

        }
        public void shuffle()
        {
            for (int j = 0; j < 4; j++)
                    for (int i = 1; i <= 13; i++) deck.Add(i);
        }

        #endregion
    }



    class Card : CardDeck
    {
        string figure;
        int value;

        Card()
        {
            MessageBox.Show("Card constructor");
            Random rnd = new Random();
            int index = rnd.Next(0, getCardsLeft() - 1);
            this.figure = deal(index);
            Console.Write(this.figure);
            

        }
           


    }
    
}


