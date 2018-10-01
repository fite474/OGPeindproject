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
    public partial class GameClient : Form
    {
        public GameClient()
        {
            InitializeComponent();
            this.button1.BackgroundImage = Eindproject.Properties.Resource1.lizard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
