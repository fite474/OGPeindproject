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
