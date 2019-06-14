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

        protected CardDeck()
        {


            MessageBox.Show("CardDeck");

        }

        static List<int> deck = new List<int>();

        string[] figure = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public void shuffle()
        {
            for (int j = 0; j < 4; j++)
                    for (int i = 1; i <= 13; i++) deck.Add(i);
            deck.ForEach(Console.WriteLine);
        }
    }



        class Card : CardDeck
        {
            public Card() { MessageBox.Show("Card"); }
            string figure;
            int value;

//      Random rnd = new Random();
// int index = rnd.Next(0, deck.Count() - 1);

    }
    
}


