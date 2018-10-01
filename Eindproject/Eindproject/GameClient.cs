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
            player1choice.Image = Eindproject.Properties.Resource1.lizard;
            player2choice.Image = Eindproject.Properties.Resource1.lizard;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            awnser = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            awnser = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            awnser = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            awnser = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            awnser = "";
        }

        public string GetAwnser() {
            return awnser;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
    }
}
