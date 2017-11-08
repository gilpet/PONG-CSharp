using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Pong : Form
    {
        int compScore;
        int plrScore;
        double speed;
        double xVel;
        double yVel;
        
        public Pong()
        {
            InitializeComponent();
            compScore = 0;
            plrScore = 0;
            speed = 40;
            Random random = new Random();
            xVel = Math.Cos(random.Next(5, 10)) * speed;
            yVel = Math.Sin(random.Next(5, 10)) * speed; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball.Location = new Point(Convert.ToInt32(Ball.Location.X + xVel), Convert.ToInt32(Ball.Location.Y + yVel));
            //move computer paddle
            if (Ball.Location.Y > 5 && Ball.Location.Y < this.Height - 40 - Player.Height)
            {
                Computer.Location = new Point(Computer.Location.X, Ball.Location.Y);
            }
            //check top wall
            if (Ball.Location.Y < 0)
            {
                Ball.Location = new Point(Ball.Location.X, 0);
                yVel = -yVel;
            }
            //check bottom wall
            if (Ball.Location.Y > this.Height - Ball.Size.Height - 45)
            {
                Ball.Location = new Point(Ball.Location.X, this.Height - Ball.Size.Height - 45);
                yVel = -yVel;
            }
            //check left wall
            if (Ball.Location.X < 0)
            {
                plrScore += 1;
                Ball.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
                PlayerScore.Text = Convert.ToString(plrScore);
            }
            //check right wall
            if (Ball.Location.X > this.Width - Ball.Size.Width - Player.Width)
            {
                compScore += 1;
                Ball.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
                ComputerScore.Text = Convert.ToString(compScore);
            }
            //check player paddle
            if (Ball.Bounds.IntersectsWith(Player.Bounds))
            {
                Ball.Location = new Point(Player.Location.X - Ball.Size.Width, Ball.Location.Y);
                xVel = -xVel;
            }
            //check computer paddle
            if (Ball.Bounds.IntersectsWith(Computer.Bounds))
            {
                Ball.Location = new Point(Computer.Location.X + Computer.Size.Width + 1, Ball.Location.Y);
                xVel = -xVel;
            }

            if (compScore == 15 || plrScore == 15)
            {
                PauseGame();
                PlaySound();
                DialogResult result = MessageBox.Show("Play again?", "Game over.", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ResetScore();
                    PauseGame();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
        private void ResetScore()
        {
            compScore = 0;
            ComputerScore.Text = Convert.ToString(compScore);
            plrScore = 0;
            PlayerScore.Text = Convert.ToString(plrScore);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Y > 5 & e.Y < this.Height - 40 - Player.Height)
            {
                Player.Location = new Point(Player.Location.X, e.Y);
            }
        }

        private void PlaySound()
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.game);
            sp.Play();
        }

        private void PauseGame()
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
        }

    }
}
