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
            
            string player1Choice = "";
            string player2Choice = "";
            string player1Score = "0";
            string player2Score = "0";
            
            GameClient gameClient = new GameClient();
            gameClient.SetPlayerScore(player1Score, player2Score);

            while (true)
            {
                Console.WriteLine("playerchoice" + player1Choice + player2Choice);
                
                
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

                Console.WriteLine("mine: " + player1Choice);
                //player2Choice = ReadTextMessage(client);
                Console.WriteLine("other" + player2Choice);
                Console.WriteLine("end string" + player1Choice + player2Choice);
                gameClient.SetPlayerScore(player1Score, player2Score);
                gameClient.SetPlayerChoice(player1Choice, player2Choice);
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
