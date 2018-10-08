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
        TcpClient client;
        public WaitingForm()
        {
            InitializeComponent();
           
        }
        
        public WaitingForm(TcpClient client)
        {
            InitializeComponent();
            this.client = client;
            Client.ReadTextMessage(client);
            this.Dispose();
        }


        private void WaitingForm_Load(object sender, EventArgs e)
        {

        }
        private void WaitingForm_Show(object sender, EventArgs e)
        {
            
        }

        
    }
}
