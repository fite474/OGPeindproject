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
            this.pockbutton.BackgroundImage = Eindproject.Properties.Resource1.spock;
            this.lizardbutton.BackgroundImage = Eindproject.Properties.Resource1.lizard;
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
            awnser = "Spock";
            Console.WriteLine(awnser);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            awnser = "Lizard";

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
                case "Siccors":
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
                case "Siccors":
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


        }
    }
}
