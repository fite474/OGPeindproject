using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindproject
{
    class Client
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("10.254.187.28", 1330);
            string playernumber = ReadTextMessage(client);
            if (playernumber == "1")
            {
                Player1Screen player1Screen = new Player1Screen();
                player1Screen.ShowDialog();
                string gameMode = player1Screen.GameMode;
                WriteTextMessage(client, gameMode);
                //start keuzescherm --> nog maken

                //response naar de server:
                // best of xxx games;
            }
            else
            {
                WaitingForm waitingForm = new WaitingForm(client);
                //waitingForm.ShowDialog();
                //string starting = ReadTextMessage(client);
                //waitingForm.Close();
                //start wachtscherm --> nog maken
            }
            string player1Choice = "";
            string player2Choice = "";
            string player1Score = "0";
            string player2Score = "0";
            string roundsLeft = "0";
            string gameOver = "";
            
            GameClient gameClient = new GameClient();
           
            gameClient.SetPlayerScore(player1Score, player2Score);

            while (true)
            {
                Console.WriteLine("playerchoice" + player1Choice + player2Choice);

                if (gameOver.Equals("win"))
                {
                    gameClient.SetWinLose("WINNER!!");
                }
                if (gameOver.Equals("lose"))
                {
                    gameClient.SetWinLose("LOSER!!");
                }
                //gameClient.setScore(int.Parse(score));
                //string message = ReadTextMessage(client);
                //Console.Write(message);
                //gameClient.setQuestion(message);
                gameClient.ShowDialog();


                player1Choice = gameClient.GetAwnser();

                
                WriteTextMessage(client, player1Choice);

                string serverResponse = ReadTextMessage(client);
                string[] responses = Regex.Split(serverResponse, "--");
                player1Score = responses[0];
                player2Score = responses[1];
                player2Choice = responses[2];
                roundsLeft = responses[3];
                gameOver = responses[4];
                


                Console.WriteLine("mine: " + player1Choice);
                //player2Choice = ReadTextMessage(client);
                Console.WriteLine("other" + player2Choice);
                Console.WriteLine("end string" + player1Choice + player2Choice);
                gameClient.SetPlayerScore(player1Score, player2Score);
                gameClient.SetPlayerChoice(player1Choice, player2Choice);
                gameClient.SetRoundsLeft(roundsLeft);
                
            }

        }
        public static void WriteTextMessage(TcpClient client, string message)
        {

            var stream = new StreamWriter(client.GetStream(), Encoding.ASCII);
            stream.WriteLine(message);
            stream.Flush();
        }



        public static string ReadTextMessage(TcpClient client)
        {

            StreamReader stream = new StreamReader(client.GetStream(), Encoding.ASCII);

            try
            {


                string line = stream.ReadLine(); ;


                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR");
                return "ERROR";
            }


        }
    }
}
