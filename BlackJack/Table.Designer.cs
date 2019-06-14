namespace BlackJack
{
    partial class Table
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hit = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
            this.labelYourHand = new System.Windows.Forms.Label();
            this.labelCroupiersHand = new System.Windows.Forms.Label();
            this.labelCardsLeft = new System.Windows.Forms.Label();
            this.croupiersHandValue = new System.Windows.Forms.Label();
            this.playersHandValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hit
            // 
            this.Hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Hit.Location = new System.Drawing.Point(688, 312);
            this.Hit.Name = "hit";
            this.Hit.Size = new System.Drawing.Size(100, 60);
            this.Hit.TabIndex = 0;
            this.Hit.Text = "Hit";
            this.Hit.UseVisualStyleBackColor = true;
            this.Hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // stand
            // 
            this.stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.stand.Location = new System.Drawing.Point(688, 378);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(100, 60);
            this.stand.TabIndex = 1;
            this.stand.Text = "Stand";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Click += new System.EventHandler(this.Stand_Click);
            // 
            // labelYourHand
            // 
            this.labelYourHand.AutoSize = true;
            this.labelYourHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelYourHand.Location = new System.Drawing.Point(78, 407);
            this.labelYourHand.Name = "labelYourHand";
            this.labelYourHand.Size = new System.Drawing.Size(151, 31);
            this.labelYourHand.TabIndex = 2;
            this.labelYourHand.Text = "Your Hand:";
            // 
            // labelCroupiersHand
            // 
            this.labelCroupiersHand.AutoSize = true;
            this.labelCroupiersHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelCroupiersHand.Location = new System.Drawing.Point(12, 9);
            this.labelCroupiersHand.Name = "labelCroupiersHand";
            this.labelCroupiersHand.Size = new System.Drawing.Size(217, 31);
            this.labelCroupiersHand.TabIndex = 3;
            this.labelCroupiersHand.Text = "Croupier\'s Hand:";
            // 
            // labelCardsLeft
            // 
            this.labelCardsLeft.AutoSize = true;
            this.labelCardsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelCardsLeft.Location = new System.Drawing.Point(571, 158);
            this.labelCardsLeft.Name = "labelCardsLeft";
            this.labelCardsLeft.Size = new System.Drawing.Size(148, 31);
            this.labelCardsLeft.TabIndex = 4;
            this.labelCardsLeft.Text = "Cards Left:";
            // 
            // croupiersHandValue
            // 
            this.croupiersHandValue.AutoSize = true;
            this.croupiersHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.croupiersHandValue.Location = new System.Drawing.Point(138, 40);
            this.croupiersHandValue.Name = "croupiersHandValue";
            this.croupiersHandValue.Size = new System.Drawing.Size(91, 31);
            this.croupiersHandValue.TabIndex = 5;
            this.croupiersHandValue.Text = "Value:";
            // 
            // playersHandValue
            // 
            this.playersHandValue.AutoSize = true;
            this.playersHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.playersHandValue.Location = new System.Drawing.Point(138, 376);
            this.playersHandValue.Name = "playersHandValue";
            this.playersHandValue.Size = new System.Drawing.Size(91, 31);
            this.playersHandValue.TabIndex = 6;
            this.playersHandValue.Text = "Value:";
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playersHandValue);
            this.Controls.Add(this.croupiersHandValue);
            this.Controls.Add(this.labelCardsLeft);
            this.Controls.Add(this.labelCroupiersHand);
            this.Controls.Add(this.labelYourHand);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.Hit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Table";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hit;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.Label labelYourHand;
        private System.Windows.Forms.Label labelCroupiersHand;
        private System.Windows.Forms.Label labelCardsLeft;
        private System.Windows.Forms.Label croupiersHandValue;
        private System.Windows.Forms.Label playersHandValue;
    }
}

