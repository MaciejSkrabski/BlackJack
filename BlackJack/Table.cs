using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Table : Form, ITableView
    {
        public Table()
        {
            InitializeComponent();


        }

        public int CardsLeft
        {
            get { return 3; }
            set { }
        }
            
        public string CroupiersHand
        {
            set
            {

            }
            
        }

        public string PlayersHand
        {
            get
            {
                return "haba";
            }

            set
            {

            }

        }

        public int CroupiersHandValue {
            get { return 3;}
            set { }

        }

    public int PlayersHandValue
        {
            get { return 6; }

            set { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Welcome to \"Poor Man's BlackJack\" \n\tby Maciej Skrabski\nPlay against the croupier AI. \nThis is much simpler than the real blackjack, because:\n\t#1 I hate gambling\n\t#2 The idea of making a bet, even with fictional currency, disgusts me\n\t#3 Just kidding with the first two. I'm just a beginner programmer and this is but a academic task.");
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            
        }
    }
}
