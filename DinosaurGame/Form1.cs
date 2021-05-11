using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinosaurGame
{
    public partial class Form1 : Form
    {
        int propSpeed = 8;
        int gravity = 20;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score++;
            bad.Left -= propSpeed;
            scoreText.Text = score.ToString();
            dino.Top += gravity;
            
            if(bad.Left < -50)
            {
                bad.Left = 650;
            }
            if (dino.Bounds.IntersectsWith(bad.Bounds))
            {
                endGame();
            }
            if (dino.Bounds.IntersectsWith(ground.Bounds))
            {
                dino.Top = 310;
            }
        }

        void endGame()
        {
            timer1.Stop();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -20;
            } 
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 20;
            }
        }
    }
}
