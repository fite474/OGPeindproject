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
    public partial class EndScreen : Form
    {
        public EndScreen()
        {
            InitializeComponent();
            
        }

        private void winLoseLabel_Click(object sender, EventArgs e)
        {

        }

        public void setWinStatus(string status)
        {
            winLoseLabel.Text = status;

        }
    }
}
