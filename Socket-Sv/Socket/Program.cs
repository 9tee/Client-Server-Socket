using System;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Threading;

namespace SocketSv
{
    class Program
    {
        private const int BUFFER_SIZE = 100;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        public static void Main()
        {
            try
            {
                IPAddress address = IPAddress.Parse("192.168.0.101");

                TcpListener listener = new TcpListener(address, PORT_NUMBER);

                listener.Start();

                Console.WriteLine("Server started on " + listener.LocalEndpoint);
                Console.WriteLine("Waiting for a connection...");

                Socket socket = listener.AcceptSocket();
                Console.WriteLine("Connection received from " + socket.RemoteEndPoint);

                Thread recvThread = new Thread(()=>ReceiverThread(socket));

                recvThread.Start();
                recvThread.Join();

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
                try
                {
                    
                    byte[] data = new byte[BUFFER_SIZE];
                    sock.Receive(data);

                    string str = encoding.GetString(data);
                    string[] num = str.Split(' ');
                    int[] arr = new int[num.Length];

                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(num[i]);
                    }
                    Console.Write("Chuoi nhan : ");
                    foreach (int i in arr)
                    {
                        Console.Write($"{i} ");
                    }
                    Array.Sort(arr);
                    String s = "";
                    Console.Write("\nChuoi tra : ");
                    foreach (int i in arr)
                    {
                        Console.Write($"{i} ");
                        s = s + Convert.ToString(i) + " ";
                    }
                    sock.Send(encoding.GetBytes(s));
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
