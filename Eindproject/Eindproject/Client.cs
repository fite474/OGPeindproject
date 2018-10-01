using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindproject
{
    class Client
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("127.0.0.1", 1330);

            //int score = 0;
            string score = "0";
            GameClient gameClient = new GameClient();
            //Application.Run(gameClient);
            while (true)
            {

                //gameClient.setScore(int.Parse(score));
                //string message = ReadTextMessage(client);
                //Console.Write(message);
                //gameClient.setQuestion(message);
                gameClient.ShowDialog();
                Console.WriteLine("test");

                string message = gameClient.GetAwnser();
                Console.WriteLine(gameClient.GetAwnser());
                WriteTextMessage(client, message);

                //score = ReadTextMessage(client);
                //Console.WriteLine(score);
                

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
