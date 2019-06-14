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
        static Boolean isFirstCard = false;
        static List<int> deck = new List<int>();
        string[] figures = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        #endregion fields

        #region methods

        public int getCardsLeft() { return deck.Count(); }

        protected CardDeck()
        {
            MessageBox.Show("CardDeck constructor");
            if (isFirstCard == false)
            {
                shuffle();
                isFirstCard = true;
            }

        }
        
        protected string deal(int i)
        {
            return figures[deck.ElementAt(i)];

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

        public Card()
        {
            MessageBox.Show("Card constructor");
            Random rnd = new Random();
            Console.WriteLine(getCardsLeft());
            int index = rnd.Next(0, ((getCardsLeft())-1));
            this.figure = deal(index);
            Console.Write(this.figure);
            

        }
           


    }
    
}


