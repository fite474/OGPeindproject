﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class HandleClientThread
    {
        private TcpClient client1;
        private TcpClient client2;

        enum Players : int
        {
            First = 1, Second = 2
        };

        

        public void HandleSeshion(Object obj)
        {
            Tuple<TcpClient, TcpClient> clients = obj as Tuple<TcpClient, TcpClient>;
            client1 = clients.Item1;
            client2 = clients.Item2;
            Score scores = new Score();
            Round round = new Round();
            int gamesToPlay = 0;
            bool gameOver = false;


            WriteTextMessage(client1, "1");
            WriteTextMessage(client2, "2");

            string gamesAmount = ReadTextMessage(client1);
            if(gamesAmount == "x")
            {
                gamesToPlay = 9999;
            }
            else
            {
                gamesToPlay = Int32.Parse(gamesAmount);
            }
            WriteTextMessage(client2, "starting");

            WriteTextMessage(client1, gamesToPlay.ToString());
            WriteTextMessage(client2, gamesToPlay.ToString());

            Tuple<string, string> playerChoices = new Tuple<string, string>("niets", "niets");

            while (gamesToPlay > 1) //aftellen van aantal games
            {
                
                string winner = "";
                playerChoices = GetChoices();
                round.Player1Choice = playerChoices.Item1;
                round.Player2Choice = playerChoices.Item2;

                
                round.CheckWinner();
                if (round.RoundOver)
                {
                    switch (round.Player1Won)
                    {
                        case true:
                            //Give player 1 a point
                            scores.GivePoint((int)Players.First);
                            winner = "player1";
                            break;

                        case false:
                            //Check if the result of the round was a draw
                            if (round.Draw)
                            {
                                //Show the players that it was a draw
                                winner = "draw";
                                break;
                            }
                            scores.GivePoint((int)Players.Second);
                            winner = "player2";
                           
                            // --> Update points in GUI
                            break;
                    }
                    //Reset all the fields
                    if (gamesAmount != "x" && !round.Draw)
                    {
                        gamesToPlay--;
                    }
                    string winnerPlayer1;
                    string winnerPlayer2;
                    if(winner == "player1")
                    {
                        winnerPlayer1 = "you";
                        winnerPlayer2 = "enemy";
                    }
                    else if(winner == "player2")
                    {
                        winnerPlayer1 = "enemy";
                        winnerPlayer2 = "you";
                    }
                    else
                    {
                        winnerPlayer1 = "draw";
                        winnerPlayer2 = "draw";
                    }
                    string messageToClient1 = BuildString(scores.Player1Score, scores.Player2Score, playerChoices.Item2, gamesToPlay, winnerPlayer1, gameOver);
                    string messageToClient2 = BuildString(scores.Player2Score, scores.Player1Score, playerChoices.Item1, gamesToPlay, winnerPlayer2, gameOver);
                    WriteTextMessage(client1, messageToClient1);
                    WriteTextMessage(client2, messageToClient2);
                    round.RoundOver = false;
                    round.Reset();
                    
                    
                }
                
            }
            gameOver = true;
            //Show players who won
            int finalScorePlayer1 = scores.Player1Score;
            int finalScorePlayer2 = scores.Player2Score;
            

            if (finalScorePlayer1 < finalScorePlayer2)
            {
                string winPlayer = BuildString(finalScorePlayer2, finalScorePlayer1, playerChoices.Item1, 0, "win", gameOver);
                string losePlayer = BuildString(finalScorePlayer1, finalScorePlayer2, playerChoices.Item2, 0, "lose", gameOver);
                WriteTextMessage(client1, losePlayer);
                WriteTextMessage(client2, winPlayer);
            }
            else
            {
                string winPlayer = BuildString(finalScorePlayer1, finalScorePlayer2, playerChoices.Item2, 0, "win", gameOver);
                string losePlayer = BuildString(finalScorePlayer2, finalScorePlayer1, playerChoices.Item1, 0, "lose", gameOver);
                WriteTextMessage(client2, losePlayer);
                WriteTextMessage(client1, winPlayer);
            }
            

        }

        public HandleClientThread()
        {

        }

        private string BuildString(int yourScore, int enemyScore, string enemyChoice, int gamesToPlay, string winStatus, bool gameOver)
        {
            string isGameOver = "";
            if(gameOver)
            {
                isGameOver = "yes";
            }
            else
            {
                isGameOver = "no";
            }

            //TODO: games left meesturen --> DONE
            string stringToSend = yourScore.ToString() + "--" + enemyScore.ToString() + "--" + enemyChoice + "--" + gamesToPlay.ToString() + "--" + winStatus + "--"+ isGameOver;
            return stringToSend;
        }

        private Tuple<string, string> GetChoices()
        {
            return new Tuple<string, string>(ReadTextMessage(client1), ReadTextMessage(client2));
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
            string line = stream.ReadLine();

            return line;
        }
























        public HandleClientThread(object obj1, object obj2) {
            client1 = obj1 as TcpClient;
            client2 = obj2 as TcpClient;
            int x = 0;
            Score scores = new Score();
            while (true) {
                Round round = new Round();

                //string message = ReadTextMessage(client1);
                //Console.WriteLine(message);
                //round.Player1Choice = ReadTextMessage(client1);
                //WriteTextMessage(client2, round.Player1Choice);
                //Console.WriteLine(round.Player1Choice);
                //round.Player2Choice = ReadTextMessage(client2);
                //WriteTextMessage(client1, round.Player2Choice);

                Tuple<string, string> tupleke = GetChoices();

                WriteTextMessage(client1, "jouw keus: " + tupleke.Item1);
                WriteTextMessage(client1, "Tegenstanders keus: " + tupleke.Item2);  
                WriteTextMessage(client2, "jouw keus: " + tupleke.Item2);
                WriteTextMessage(client2, "Tegenstanders keus: " + tupleke.Item1);
                //round.CheckWinner();
                if (round.RoundOver)
                {
                    switch(round.Player1Won)
                    {
                        case true:
                            //Give player 1 a point
                            scores.GivePoint((int)Players.First);
                            // --> Update points in GUI
                            break;

                        case false:
                            //Check if the result of the round was a draw
                            if(round.Draw)
                            {
                                //Show the players that it was a draw
                                break;
                            }
                            scores.GivePoint((int)Players.Second);
                            // --> Update points in GUI
                            break;
                    }
                    //Reset all the fields

                    round.RoundOver = false;
                }
            }
        }

        
        
    }
}
