using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindproject
{
    public partial class WinLoseScreen : Form
    {
        string winner;
        Label currentMatchScore;

        public WinLoseScreen()
        {
            InitializeComponent();
        }

        public WinLoseScreen(string winorLose, List<string> gameHistory)
        {
            InitializeComponent();
            SetGameHistory(gameHistory);
            this.winner = winorLose;
            if (winner == "win")
            {
                WinLoseLabel.Text = "You won!";
                WinOrLosePictureBox.Image = Properties.Resource1.Winner;
            }
            else
            {
                WinLoseLabel.Text = "You lost...";
                WinOrLosePictureBox.Image = Properties.Resource1.Lose;
            }
            //GameResultPanel
        }

        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WinOrLosePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void SetGameHistory(List<string> historyList)
        {
            int distanceScaler = 0;
            int pictureBoxHeight = 22;
            PictureBox p1 = new PictureBox
            {
                //Height = pictureBoxHeight,
                Width = 170,
                BorderStyle = BorderStyle.Fixed3D,
                BackColor = Color.LightGray
            };
            foreach (string score in historyList)
            {
                currentMatchScore = new Label();
                currentMatchScore.Width = 150;
                currentMatchScore.Text = score;
                currentMatchScore.Top = distanceScaler;

                p1.Controls.Add(currentMatchScore);
                distanceScaler += 22;
                pictureBoxHeight += 22;
                Console.WriteLine("picturebox heigt: "+ pictureBoxHeight);

            }
            p1.Height = pictureBoxHeight;
           
            GameResultPanel.Controls.Add(p1);
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            //saveFileDialog1.FileName = FileNameTextBox.Text;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }


    }
}
