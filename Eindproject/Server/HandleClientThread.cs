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
        enum Players : int
        {
            First = 1, Second = 2
        };
        public HandleClientThread(object obj1, object obj2) {
            TcpClient client1 = obj1 as TcpClient;
            TcpClient client2 = obj2 as TcpClient;
            int x = 0;
            Score scores = new Score();
            while (true) {
                Round round = new Round();
                round.Player1Choice = ReadTextMessage(client1);
                Console.WriteLine(round.Player1Choice);
                //round.Player2Choice = ReadTextMessage(client2);
                //round.CheckWinner();
                if(round.RoundOver)
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
