using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            
            IPAddress localhost = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new System.Net.Sockets.TcpListener(IPAddress.Any, 1330);

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
                Console.WriteLine("\nClient 1 connected!");
                TcpClient client2 = listener.AcceptTcpClient();
                Console.WriteLine("\nClient 2 connected!");
                Console.WriteLine("Starting session...");

                Tuple<TcpClient, TcpClient> clients = new Tuple<TcpClient, TcpClient>(client1, client2);

                HandleClientThread task = new HandleClientThread();
                Thread thread = new Thread(task.HandleSeshion);
                thread.Start(clients);


            }
        }

        
    }
}

