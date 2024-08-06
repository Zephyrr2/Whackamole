using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace whackamole
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int locationNum = 0;
        int score = 0;
        int misses = 0;
        bool isHit = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void gotMole(object sender, EventArgs e)
        {
            score++;
            Mole.Image = Properties.Resources.dead;
            isHit = true;
            Mole.Enabled = false;
        }

        private void moveMole(object sender, EventArgs e)
        {
            lblHit.Text = "Hit: " + score;
            lblMiss.Text = "Miss: " + misses;

            if (isHit == false)
            {
                misses++;
            }

            if (score > 15)
            {
                timer1.Stop();
                Mole.Enabled = false;
                MessageBox.Show("You Win");

                level level = new level();
                level.Show();
                this.Hide();
            }
            else if (misses > 10)
            {
                timer1.Stop();
                Mole.Enabled = false;
                MessageBox.Show("You Lose");

                btnRetry.Visible = true;
            }
            moveMole();
        }

        private void moveMole()
        {
            isHit = false;
            Mole.Enabled = true;
            Mole.Image = Properties.Resources.mario_removebg_preview__1_;
            Mole.BackColor = System.Drawing.Color.Transparent;

            locationNum = rnd.Next(1, 7);

            switch (locationNum)
            {
                case 1:
                    Mole.Left = 366;
                    Mole.Top = 261;
                    break;
                case 2:
                    Mole.Left = 207;
                    Mole.Top = 227;
                    break;
                case 3:
                    Mole.Left = 46;
                    Mole.Top = 258;
                    break;
                case 4:
                    Mole.Left = 65;
                    Mole.Top = 332;
                    break;
                case 5:
                    Mole.Left = 212;
                    Mole.Top = 381;
                    break;
                case 6:
                    Mole.Left = 350;
                    Mole.Top = 338;
                    break;

                default:
                    break;
            }
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            score = 0;
            misses = 0;

            timer1.Start();
            btnRetry.Visible = false;
            moveMole();
        }
    }
}
