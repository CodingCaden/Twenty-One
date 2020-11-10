using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Twenty_One
{
    public partial class Form1 : Form
    {
        #region Declarations
        int Dice1roll = new int();
        int Dice2roll = new int();
        int Total;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playbtn.Visible = false;

        }

        private void btn_rolldice_Click(object sender, EventArgs e)
        {
            dice1box.Visible = true;
            dice2box.Visible = true;

                if (Total < 15)
                {
                    Roll2Dice();
                }
                else if (Total > 15)
                {
                    dice2box.Visible = false;
                    Roll1Dice();
                }

                if (Total == 21)
                {
                    MessageBox.Show("You Win!");
                    playbtn.Visible = true;
                btn_rolldice.Visible = false;
                }
                else if (Total > 21)
                {
                    MessageBox.Show("You Loose!");
                    playbtn.Visible = true;
                btn_rolldice.Visible = false;
            }

        }
        public void Roll2Dice()
        {
            Random r = new Random();
            

            Dice1roll = r.Next(1, 7);

            if (Dice1roll == 1)
                dice1box.Image = dice1.Image;
            else if (Dice1roll == 2)
                dice1box.Image = dice2.Image;
            else if (Dice1roll == 3)
                dice1box.Image = dice3.Image;
            else if (Dice1roll == 4)
                dice1box.Image = dice4.Image;
            else if (Dice1roll == 5)
                dice1box.Image = dice5.Image;
            else if (Dice1roll == 6)
                dice1box.Image = dice6.Image;

            Dice2roll = r.Next(1, 7);

            if (Dice2roll == 1)
                dice2box.Image = dice1.Image;
            else if (Dice2roll == 2)
                dice2box.Image = dice2.Image;
            else if (Dice2roll == 3)
                dice2box.Image = dice3.Image;
            else if (Dice2roll == 4)
                dice2box.Image = dice4.Image;
            else if (Dice2roll == 5)
                dice2box.Image = dice5.Image;
            else if (Dice2roll == 6)
                dice2box.Image = dice6.Image;

            Total = Dice1roll + Dice2roll + Total;

        }
        private void Roll1Dice()
        {
            Random r = new Random();

            Dice1roll = r.Next(1, 7);

            if (Dice1roll == 1)
                dice1box.Image = dice1.Image;
            else if (Dice1roll == 2)
                dice1box.Image = dice2.Image;
            else if (Dice1roll == 3)
                dice1box.Image = dice3.Image;
            else if (Dice1roll == 4)
                dice1box.Image = dice4.Image;
            else if (Dice1roll == 5)
                dice1box.Image = dice5.Image;
            else if (Dice1roll == 6)
                dice1box.Image = dice6.Image;

            Total = Dice1roll + Total;
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            dice1box.Image = null;
            dice2box.Image = null;
            btn_rolldice.Visible = true;
            playbtn.Visible = false;
            Total = 0;
        }
    }
}
