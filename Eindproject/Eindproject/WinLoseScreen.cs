using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<string> gameHistory;


        public WinLoseScreen()
        {
            InitializeComponent();
        }

        public WinLoseScreen(string winorLose, List<string> gameHistory, string playerName)
        {
            InitializeComponent();
            this.Text = "You  --" + playerName + "--  "+ winorLose;
            SetGameHistory(gameHistory);
            this.gameHistory = gameHistory;
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

        [STAThread]
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = FileNameTextBox.Text;
                if(fileName == "")
                {
                    MessageBox.Show("Voer een naam in aub!");
                }
                else
                {
                    fileName = string.Concat(fileName, ".txt");
                    MessageBox.Show("Opslaan naar bestand: " + fileName + "...");

                    File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\" + fileName, gameHistory);
                }
            }
            catch(Exception Thc)
            {
                Debug.Write(Thc);
            }

            FileNameTextBox.Text = "";
            SaveFileButton.Enabled = false;

            
        }

        private void FileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveFileButton.Enabled = true;
        }

        private void WinLoseScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
