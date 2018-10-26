using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindproject
{
    class Client
    {
        private static List<string> gameResults;
        private static string playerName;
        static GameClient gameClient;
        static string roundsLeft;
        static TcpClient client;
        //new Thread(ShowScreen).Start();

        static void Main(string[] args)
        {
            Console.Beep();

            client = new TcpClient("145.49.26.212", 1330);
            Console.WriteLine(@"
          =-=-=-=-=-=-=-=-=-=-=-=-=-=
     -=-=-=-=      Connected      =-=-=-=-
--=-=-=-             to an             -=-=-=--   
     -=-=-=-=     awesome server  =-=-=-=-
          =-=-=-=-=-=-=-=-=-=-=-=-=-=");
            string playernumber = ReadTextMessage(client);
            if (playernumber == "1")
            {
                playerName = "Player 1";
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
                playerName = "Player2";
                WaitingForm waitingForm = new WaitingForm(client);
                //waitingForm.ShowDialog();
                //string starting = ReadTextMessage(client);
                //waitingForm.Close();
                //start wachtscherm --> nog maken
            }


            roundsLeft = ReadTextMessage(client);


            gameClient = new GameClient(playerName);
            //  Application.Run(gameClient);
            Thread gameThread = new Thread(showGameScreen);
            gameThread.Start();
            new Thread(runGameLoop).Start();
        }

            private static void runGameLoop(object o)
            {
            string player1Choice = "niets";
            string player2Choice = "";
            string player1Score = "0";
            string player2Score = "0";
            string roundWinner = "";
            bool gameOver = false;
            int roundNumber = 0;

            //gameClient.ShowDialog();
            gameClient.SetPlayerScore(player1Score, player2Score);
            gameClient.SetRoundsLeft(roundsLeft);
            gameResults = new List<string>();

            while (!gameOver)
            {
                Console.WriteLine("playerchoice" + player1Choice + player2Choice);
                gameClient.resetAwnser();
                player1Choice = "niets";
                Console.Beep();
                //gameClient.setScore(int.Parse(score));
                //string message = ReadTextMessage(client);
                //Console.Write(message);
                //gameClient.setQuestion(message);
                //gameClient.ShowDialog();

                while(player1Choice == "niets")
                player1Choice = gameClient.GetAwnser();
                
                
                WriteTextMessage(client, player1Choice);

                string serverResponse = ReadTextMessage(client);
                string[] responses = Regex.Split(serverResponse, "--");
                player1Score = responses[0];
                player2Score = responses[1];
                player2Choice = responses[2];
                roundsLeft = responses[3];
                roundWinner = responses[4];
                string matchResult = (player1Choice + "  " + player1Score + " - " + player2Score + "  " + player2Choice);
                gameResults.Add(matchResult);
                roundNumber++;
                string isGameOver = responses[5];
                if (isGameOver == "yes")
                {
                    gameOver = true;
                }
                else
                {
                    gameClient.SetWinLoseImage(roundWinner);
                }
                Console.WriteLine("mine: " + player1Choice);
                //player2Choice = ReadTextMessage(client);
                Console.WriteLine("other" + player2Choice);
                Console.WriteLine("end string" + player1Choice + player2Choice);
                gameClient.SetPlayerScore(player1Score, player2Score);
                gameClient.SetPlayerChoice(player1Choice, player2Choice);
                gameClient.SetRoundsLeft(roundsLeft);
                
            }

            if (roundWinner.Equals("win"))
            {
                WinLoseScreen endscreen = new WinLoseScreen(roundWinner, gameResults, playerName);
                endscreen.ShowDialog();
                
            }
            if (roundWinner.Equals("lose"))
            {
                WinLoseScreen endscreen = new WinLoseScreen(roundWinner, gameResults, playerName);
                endscreen.ShowDialog();
            }





            while (true)
            {

            }

        }


        public static void showGameScreen(object o)
        {
            gameClient.ShowDialog();

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
