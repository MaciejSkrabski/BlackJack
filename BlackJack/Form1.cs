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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to \"Poor Man's BlackJack\" \n\tby Maciej Skrabski\nPlay against the croupier AI. \nThis is much simpler than the real blackjack, because:\n\t#1 I hate gambling\n\t#2 The idea of making a bet, even with fictional currency, disgusts me\n\t#3 Just kidding with the first two. I'm just a beginner programmer and this is but a academic task.");
        }

        private void stand_Click(object sender, EventArgs e)
        {
            Card haba = new Card();
            haba.shuffle();
        }
    }
}
