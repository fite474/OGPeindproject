using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            int clients = 0;
            IPAddress localhost = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new System.Net.Sockets.TcpListener(localhost, 1330);

            listener.Start();

            bool ipIsOk = IPAddress.TryParse("127.0.0.1", out localhost);

            if (!ipIsOk)
            {
                Console.WriteLine("ip adres kan niet geparsed worden.");
                Environment.Exit(1);
            }

            while (true)
            {
                Console.WriteLine("Waiting for connection...");
                TcpClient client1 = listener.AcceptTcpClient();
                TcpClient client2 = listener.AcceptTcpClient();
                HandleClientThread task = new HandleClientThread(client1, client2);
                


            }
        }
    }
}

