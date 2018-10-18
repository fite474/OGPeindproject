using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Eindproject
{
    public partial class GameClient : Form
    {
        string awnser;
        public GameClient()
        {
            InitializeComponent();

            //this.button1.BackgroundImage = Eindproject.Properties.Resource1.lizard;

            this.rockbutton.BackgroundImage = Eindproject.Properties.Resource1.rock;
            this.paperbutton.BackgroundImage = Eindproject.Properties.Resource1.paper;
            this.scissorbutton.BackgroundImage = Eindproject.Properties.Resource1.scissors;
            this.lizardButton.BackgroundImage = Eindproject.Properties.Resource1.spock;
            this.spockButton.BackgroundImage = Eindproject.Properties.Resource1.lizard;
            //player1choice.Image = Eindproject.Properties.Resource1.lizard;
            //player2choice.Image = Eindproject.Properties.Resource1.lizard;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            awnser = "Rock";
            Console.WriteLine(awnser);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            awnser = "Paper";
            Console.WriteLine(awnser);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            awnser = "Scissors";
            Console.WriteLine(awnser);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            awnser = "Lizard";
            Console.WriteLine(awnser);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            awnser = "Spock";

           Console.WriteLine(awnser);
           this.Close();

        }

        public string GetAwnser() {
            //this.Close();
            return awnser;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        public void SetPlayerScore(string score1, string score2)
        {
            scoreplayer1.Text = score1;
            scoreplayer2.Text = score2;
        }

        public void SetRoundsLeft(string roundsLeft)
        {
            RoundsLeftLabel.Text = "Rounds left: " + roundsLeft;
        }

        public void SetWinLose(string winOrLoser)
        {
            WinLoseLabel.Text = winOrLoser;
            WinLoseLabel.Visible = true;
            rockbutton.Visible = false;
            paperbutton.Visible = false;
            scissorbutton.Visible = false;
            spockButton.Visible = false;
            lizardButton.Visible = false;
           
        }


        public void SetPlayerChoice(string Player1Choice, string Player2Choice)
        {
            switch (Player1Choice)
            {
                case "Rock":
                    {
                        player1choice.Image = Eindproject.Properties.Resource1.rock;
                        break;
                    }
                case "Paper":
                    {
                        player1choice.Image = Eindproject.Properties.Resource1.paper;
                        break;
                    }
                case "Scissors":
                    {
                        player1choice.Image = Eindproject.Properties.Resource1.scissors;
                        break;
                    }
                case "Spock":
                    {
                        player1choice.Image = Eindproject.Properties.Resource1.spock;
                        break;
                    }
                case "Lizard":
                    {
                        player1choice.Image = Eindproject.Properties.Resource1.lizard;
                        break;
                    }
                case "":
                    {
                        
                        break;
                    }
            }

            switch (Player2Choice)
            {
                case "Rock":
                    {
                        player2choice.Image = Eindproject.Properties.Resource1.rock;
                        break;
                    }
                case "Paper":
                    {
                        player2choice.Image = Eindproject.Properties.Resource1.paper;
                        break;
                    }
                case "Scissors":
                    {
                        player2choice.Image = Eindproject.Properties.Resource1.scissors;
                        break;
                    }
                case "Spock":
                    {
                        player2choice.Image = Eindproject.Properties.Resource1.spock;
                        break;
                    }
                case "Lizard":
                    {
                        player2choice.Image = Eindproject.Properties.Resource1.lizard;
                        break;
                    }


            }

            Player1IndicatorLabel.Visible = true;
            Player2IndicatorLabel.Visible = true;
            WinnerIndicatorLabel.Visible = true;


        }

        public void SetWinLoseImage(string winlose)
        {
            switch(winlose)
            {
                case "you":
                    {
                        WinLosePictureBox.Image = Properties.Resource1.WinnerCheck;
                        break;
                    }
                case "enemy":
                    {
                        WinLosePictureBox.Image = Properties.Resource1.LoserCross;
                        break;
                    }
                case "draw":
                    {
                        WinLosePictureBox.Image = Properties.Resource1.Draw;
                        break;
                    }
            }
        }
    }
}
