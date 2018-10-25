using System;
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
            bool lastGameDraw = false;


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
            string winnerPlayer1;
            string winnerPlayer2;
            string winner = "";
            while (gamesToPlay > 1|| !round.RoundOver || lastGameDraw) //aftellen van aantal games
            {
                round.Reset();
                //string winner = "";
                //playerChoices = GetChoices();
                round.Player1Choice = playerChoices.Item1;
                round.Player2Choice = playerChoices.Item2;
                Console.WriteLine("player1: "+round.Player1Choice);
                Console.WriteLine("player2: "+round.Player2Choice +"\n");


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

                    Console.WriteLine(winner);
                    if (winner == "player1")
                    {
                        winnerPlayer1 = "you";
                        winnerPlayer2 = "enemy";
                        lastGameDraw = false;
                        //scores.GivePoint((int)Players.First);

                    }
                    else if(winner == "player2")
                    {
                        winnerPlayer1 = "enemy";
                        winnerPlayer2 = "you";
                        lastGameDraw = false;
                    }
                    else
                    {
                        winnerPlayer1 = "draw";
                        winnerPlayer2 = "draw";
                        lastGameDraw = true;
                    }
                    string messageToClient1 = BuildString(scores.Player1Score, scores.Player2Score, playerChoices.Item2, gamesToPlay, winnerPlayer1, gameOver);
                    string messageToClient2 = BuildString(scores.Player2Score, scores.Player1Score, playerChoices.Item1, gamesToPlay, winnerPlayer2, gameOver);
                    WriteTextMessage(client1, messageToClient1);
                    WriteTextMessage(client2, messageToClient2);
                    //round.RoundOver = false;
                    
                    
                    
                }
                playerChoices = GetChoices();
            }
            gameOver = true;
            //Show players who won
            

            //if (winner == "player1")
            //{
            //    scores.GivePoint((int)Players.First);
            //}
            //else
            //{
            //    scores.GivePoint((int)Players.Second);
            //}

            int finalScorePlayer1 = scores.Player1Score;
            int finalScorePlayer2 = scores.Player2Score;


            if (finalScorePlayer1 < finalScorePlayer2)
            {
                finalScorePlayer2++;
                string winPlayer = BuildString(finalScorePlayer2, finalScorePlayer1, playerChoices.Item1, 0, "win", gameOver);
                string losePlayer = BuildString(finalScorePlayer1, finalScorePlayer2, playerChoices.Item2, 0, "lose", gameOver);
                WriteTextMessage(client1, losePlayer);
                WriteTextMessage(client2, winPlayer);
                Console.WriteLine(winPlayer);
                Console.WriteLine(losePlayer);

            }
            else
            {
                finalScorePlayer1++;
                string winPlayer = BuildString(finalScorePlayer1, finalScorePlayer2, playerChoices.Item2, 0, "win", gameOver);
                string losePlayer = BuildString(finalScorePlayer2, finalScorePlayer1, playerChoices.Item1, 0, "lose", gameOver);
                WriteTextMessage(client2, losePlayer);
                WriteTextMessage(client1, winPlayer);
                Console.WriteLine(winPlayer);
                Console.WriteLine(losePlayer);
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
    }
}
