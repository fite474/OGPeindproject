using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindproject
{
    public partial class WaitingForm : Form
    {
        public WaitingForm()
        {
            InitializeComponent();
           
        }
        
        public WaitingForm(TcpClient client)
        {
            InitializeComponent();
            Client.ReadTextMessage(client);
            this.Close();
        }

        private void WaitingForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
