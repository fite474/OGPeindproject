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
    public partial class Player1Screen : Form
    {
        public string GameMode { get; set; }
        public Player1Screen()
        {
            InitializeComponent();
        }

        private void bo3Button_Click(object sender, EventArgs e)
        {
            GameMode = "3";
            this.Close();
        }

        private void bo7Button_Click(object sender, EventArgs e)
        {
            GameMode = "7";
            this.Close();

        }

        private void bo13Button_Click(object sender, EventArgs e)
        {
            GameMode = "13";
            this.Close();

        }

        private void infiniteButton_Click(object sender, EventArgs e)
        {
            GameMode = "x";
            this.Close();

        }

    }
}
