using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindproject
{
    public partial class WinLoseScreen : Form
    {
        string winner;

        public WinLoseScreen()
        {
            InitializeComponent();
        }

        public WinLoseScreen(string winorLose)
        {
            InitializeComponent();
            this.winner = winorLose;
            if(winner == "win")
            {
                WinLoseLabel.Text = "You won!";
                WinOrLosePictureBox.Image = Properties.Resource1.Winner;
            }
            else
            {
                WinLoseLabel.Text = "You lost...";
                WinOrLosePictureBox.Image = Properties.Resource1.Lose;
            }
        }
    }
}
