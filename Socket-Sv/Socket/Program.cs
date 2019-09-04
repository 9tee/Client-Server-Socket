using System;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Threading;
namespace SocketSv
{
    class Program
    {
        private const int BUFFER_SIZE = 10;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        public static void Main()
        {
            try
            {
                IPAddress address = IPAddress.Parse("192.168.0.101");

                TcpListener listener = new TcpListener(address, PORT_NUMBER);

                // 1. listen
                listener.Start();

                Console.WriteLine("Server started on " + listener.LocalEndpoint);
                Console.WriteLine("Waiting for a connection...");

                Socket socket = listener.AcceptSocket();
                Console.WriteLine("Connection received from " + socket.RemoteEndPoint);

                Thread recvThread = new Thread(()=>ReceiverThread(socket));

                recvThread.Start();

                // 3. send
                socket.Send(encoding.GetBytes("Hello "));
                recvThread.Join();
                // 4. close
                socket.Close();
                listener.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.Read();

        }
        public static void ReceiverThread(Socket sock)
        {
            while (true)
            {
                byte[] data = new byte[BUFFER_SIZE];
                sock.Receive(data);

                string str = encoding.GetString(data);

                Console.WriteLine(str);
            }
        }
    }
}
