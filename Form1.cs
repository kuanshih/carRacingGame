using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRacingGame
{
    
    public partial class Form1 : Form
    {
        int roadSpeed;
        int traficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition  = new Random();
        
        
        


        bool goRight, goLeft;

        public Form1()
        {
            InitializeComponent();
            gameReset();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            labScore.Text = "Score: " + score;
            score ++;

            if(goLeft ==true && picBoxPlayer.Left > 5)
            {
                picBoxPlayer.Left -= playerSpeed;
            }
            if (goRight == true && picBoxPlayer.Left < 420)
            {
                picBoxPlayer.Left += playerSpeed;
            }

            picBoxRoadTrack1.Top += roadSpeed;
            picBoxRoadTrack2.Top += roadSpeed;

            if (picBoxRoadTrack2.Top > 519)
            {
                picBoxRoadTrack2.Top = -519;
            }
            if (picBoxRoadTrack1.Top > 519)
            {
                picBoxRoadTrack1.Top = -519;
            }

            picAI1.Top += traficSpeed;
            picAI2.Top += traficSpeed;
            

            if (picAI1.Top > 520)
            {
                //picAI1.Top = -40;
                //picAI1.Left = carPosition.Next(5, 420);
                changeIAcars(picAI1);
            }
            if(picAI2.Top > 520)
            {
                //picAI2.Top = -20;
                //picAI2.Left = carPosition.Next(5, 420);
                changeIAcars(picAI2);
            }
            if(picBoxPlayer.Bounds.IntersectsWith(picAI1.Bounds) || picBoxPlayer.Bounds.IntersectsWith(picAI2.Bounds))
            {
                gameOver();
            }

            if (score > 40 && score < 500)
            {
                picBoxAwade.Image = Properties.Resources.bronze;
            }
            else if  (score > 500 && score < 2000)
            {
                picBoxAwade.Image = Properties.Resources.silver;
                traficSpeed = 27;
                roadSpeed = 25; 
            }
            else if (score >2000)
            {
                picBoxAwade.Image = Properties.Resources.gold;
            }
      

        }

        private void changeIAcars(PictureBox tempcar)
        {
            int pick = rand.Next(1, 9);
            switch (pick)
            {
                case 1:
                    tempcar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempcar.Image = Properties.Resources.CarRed;
                    break;
                case 3:
                    tempcar.Image = Properties.Resources.carGreen;
                    break;
                case 4:
                    tempcar.Image = Properties.Resources.carGrey;
                    break;
                case 5:
                    tempcar.Image = Properties.Resources.carOrange;
                    break;
                case 6:
                    tempcar.Image = Properties.Resources.carYellow;
                    break;
                case 7:
                    tempcar.Image = Properties.Resources.carPink;
                    break;
                case 8:
                    tempcar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempcar.Image = Properties.Resources.TruckWhite;
                    break;
            }
            tempcar.Top = carPosition.Next(100, 400) * -1;

            if((string)tempcar.Tag == "carLeft")
            {
                picAI1.Left = carPosition.Next(5, 200);
            }
            if((string)tempcar.Tag == "carRight")
            {
                picAI2.Left = carPosition.Next(210, 422);
            }


        }

        private void gameOver()
        {
            playsound();
            gameTimer.Stop();
       
                picBoxExplosion.Visible = true;
                picBoxPlayer.Controls.Add(picBoxExplosion);
                picBoxExplosion.Location = new Point(-8, 5);
                picBoxExplosion.BackColor = Color.Transparent;

                picBoxAwade.Visible = true;
                picBoxAwade.BringToFront();
                btnStart.Enabled = true;
            
  
            
        }

        private void gameReset()
        {
            btnStart.Enabled = false;
            picBoxExplosion.Visible = false;
            picBoxAwade.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;
            picBoxAwade.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            traficSpeed = 15;

            picAI1.Top = carPosition.Next(200, 500) * -1;
            picAI1.Left = carPosition.Next(5, 200);

            picAI2.Top = carPosition.Next(200, 500) * -1;
            picAI2.Left = carPosition.Next(245, 422);

            gameTimer.Start();


        }

        private void resartGame(object sender, EventArgs e)
        {
            gameReset();
          
        }

        private void playsound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }
    }
}
