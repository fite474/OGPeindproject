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
        public HandleClientThread(object obj1, object obj2) {
            TcpClient client1 = obj1 as TcpClient;
            TcpClient client2 = obj2 as TcpClient;
            int x = 0;
            while (true) {
                Round round = new Round();

                //string message = ReadTextMessage(client1);
                //Console.WriteLine(message);
                round.Player1Choice = ReadTextMessage(client1);
                WriteTextMessage(client2, round.Player1Choice);
                //Console.WriteLine(round.Player1Choice);
                round.Player2Choice = ReadTextMessage(client2);
                WriteTextMessage(client1, round.Player2Choice);

                //round.CheckWinner();
                if (round.RoundOver)
                {
                    switch(round.Player1Won)
                    {
                        case true:


                            break;
                    }
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
