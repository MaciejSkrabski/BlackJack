namespace BlackJack
{
    partial class Form1
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
            this.hit = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
            this.labelYourHand = new System.Windows.Forms.Label();
            this.labelCroupiersHand = new System.Windows.Forms.Label();
            this.labelCardsLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hit
            // 
            this.hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hit.Location = new System.Drawing.Point(688, 312);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(100, 60);
            this.hit.TabIndex = 0;
            this.hit.Text = "Hit";
            this.hit.UseVisualStyleBackColor = true;
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
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // labelYourHand
            // 
            this.labelYourHand.AutoSize = true;
            this.labelYourHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelYourHand.Location = new System.Drawing.Point(12, 407);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCardsLeft);
            this.Controls.Add(this.labelCroupiersHand);
            this.Controls.Add(this.labelYourHand);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.hit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.Label labelYourHand;
        private System.Windows.Forms.Label labelCroupiersHand;
        private System.Windows.Forms.Label labelCardsLeft;
    }
}

