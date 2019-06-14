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
        readonly string[] figures = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        int cardsLeft;

        #endregion fields

        #region methods

        protected int GetValue(string f)
        {
            if (f == "A") return 11;
            else if (Array.IndexOf(figures, f) > 8) return 10;
            else return Array.IndexOf(figures, f) + 1;
        }

        public int GetCardsLeft() { this.cardsLeft = deck.Count(); return deck.Count(); }

        protected CardDeck()
        {
            MessageBox.Show("CardDeck constructor");
            if (isFirstCard == false)
            {
                Shuffle();
                isFirstCard = true;
            }

        }
        
        protected string Deal(int i)
        {
            if (GetCardsLeft() > 0)
            {
                return figures[(deck.ElementAt(i)) % 13];
            }
            else
            {
                MessageBox.Show("No more cards to deal! Game over.");
                return "TheEnd";
            }
            

        }
        public void Shuffle()
        {
            for (int j = 0; j < 4; j++)
                    for (int i = 1; i <= 13; i++) deck.Add(i);
        }

        public void RemoveCard(int i)
        {
            deck.RemoveAt(i);
        }

        #endregion
    }



    class Card : CardDeck
    {
        int cardsLeft;
        string figure;
        int value;
        



        public Card()
        {
            this.cardsLeft = GetCardsLeft();
            //int value;
            //while (getCardsLeft() > 0){
                Random rnd = new Random();
                //Console.WriteLine(rnd.Next(0, (getCardsLeft() - 1)));
                int index = rnd.Next(0, GetCardsLeft() - 1);
                this.figure = Deal(index);
                this.value = GetValue(this.figure);
                
                Console.WriteLine(" " + this.figure);

                Console.WriteLine(" " + this.value);
                RemoveCard(index); //}
        }
        public int GetValue() { return this.value; }
           


    }

    class Hand {
        //public int cardsLeft() { return GetCards(); }
        public Hand() { ClearHand(); }
        List<Card> cards;
        int cardsLeft;
        
        public void Draw() {
            Card card = new Card();
            cards.Add(card);
            cards[0].GetValue();
            this.cardsLeft = card.GetCardsLeft();
                }
        public void ClearHand() { this.cards.Clear(); }
        //public GetCardsValueSum() { foreach cards.Sum}
        public List<Card> GetCards() { return this.cards; }
        public int GetCardsLeft() { return this.cardsLeft; }
   

    }

    class Player : Hand
    {
        //int cardsLeft() { return GetCards}
        int wins;
        int cardsValue;
        int cardsLeft;
        public Player() { this.wins = 0; }
        public void AddWin() { this.wins += 1; }
        public void AIdecision(int i) {

        }
        public void SetCardsValue()
        {
            int sum = 0;
            foreach (Card card in GetCards()) {
                sum += card.GetValue();
            }
            this.cardsValue = sum;
        }
        public int GetCardsValue() { return this.cardsValue; }
        void SetCardsLeft() { this.cardsLeft = GetCardsLeft(); }
    }

    class Game
    {
        int cardsleft;
        int p1CardsValue;
        int AICardsValue;
        int p1Wins;
        int AIwins;
        
        bool clickHit;
        bool clickStand;

        public void setStand(bool button) { this.clickStand = true; }
        public void setHitTrue() { this.clickHit = true; }
        public void setHitFalse() { this.clickHit = false; }
        public bool getHit() { return this.clickHit; }
        public bool getStand() { return this.clickStand; }
        public void setCardsLeft(int x) { this.cardsleft = x; }
        public int getCardsLeft() { return this.cardsleft;  }
        public void setAICardsValue(int x) { this.AICardsValue = x; }
        public int getAICardsValue() { return this.AICardsValue; }
        public void setp1CardsValue(int x) { this.p1CardsValue = x; }
        public int getp1CardsValue() { return this.p1CardsValue; }
        public void incrementP1Wins() { this.p1Wins +=1; }
        public void incrementAIWins() { this.AIwins += 1; }
        public int getp1Wins() { return p1Wins; }
        public int getAIwins() { return this.AIwins; }


        public Game() {
            this.p1Wins = 0;
            this.AIwins = 0;
            int cardsleft = 52;
            Player p1 = new Player();
            Player AI = new Player();
            this.cardsleft = p1.GetCardsLeft();
            while (cardsleft > 5)
            {
                AI.ClearHand();
                p1.ClearHand();

                AI.Draw();
                p1.Draw();
                p1.Draw();
                this.cardsleft = p1.GetCardsLeft();
                getAICardsValue();
                if(p1.GetCardsValue() == 22)
            {
                    setCardsLeft(p1.GetCardsLeft());
                    p1.AddWin();
                    incrementP1Wins();

                    p1.ClearHand();
                    AI.ClearHand();
                    MessageBox.Show("BLACKJACK!");
            }
                else {
                   while (this.clickStand == false){
                        if (getHit() == true)
                        {
                            p1.Draw();
                            if (p1.GetCardsValue() > 21) { MessageBox.Show("Bust!;"); AI.AddWin(); p1.ClearHand(); AI.ClearHand(); }
                            setHitFalse();
                            setCardsLeft(p1.GetCardsLeft());

                        }
                        


                    }

                    if (AI.GetCardsValue() == 22)
                    {
                        setCardsLeft(p1.GetCardsLeft());
                        AI.AddWin();
                        incrementAIWins();
                        p1.ClearHand();
                        AI.ClearHand();
                        MessageBox.Show("BLACKJACK!");
                        setCardsLeft(p1.GetCardsLeft());
                    }
                    else
                    {
                        while (AI.GetCardsValue() < p1.GetCardsValue())
                        {
                            AI.Draw();
                            if (AI.GetCardsValue() > 21) { MessageBox.Show("Bust!;"); p1.AddWin(); p1.ClearHand(); AI.ClearHand(); }
                            setCardsLeft(p1.GetCardsLeft());
                        }
                        if (p1.GetCardsValue() < AI.GetCardsValue()) { AI.AddWin(); incrementAIWins(); }
                    }

                }
            }

            
            
            //else:



        }

    }
}


