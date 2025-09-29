using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        int boruhizi = 8;
        int gravity = 8;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Kus.Top += gravity;
            BoruAlt.Left -= boruhizi;
            BoruUst.Left -= boruhizi;
            ScoreText.Text = "" + score;
            if(BoruAlt.Left<-150)
            {
                BoruAlt.Left = 700;
                score++;
            }
            if(BoruUst.Left<-150)
            {
                BoruUst.Left = 700;
            }
            if(Kus.Bounds.IntersectsWith(BoruAlt.Bounds)||Kus.Bounds.IntersectsWith(BoruUst.Bounds)||Kus.Bounds.IntersectsWith(Zemin.Bounds))
            {
                endGame();
            }
            if(score>5)
            {
                boruhizi = 12;
            }
            if (score > 10)
            {
                boruhizi = 16;
            }
            if(Kus.Top<-25)
            {
                endGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            ScoreText.Text = "Game Over";
        }


    }
}
