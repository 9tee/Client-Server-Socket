using System;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace SocketServer
{
    class Server
    {
        private const int BUFFER_SIZE = 100;
        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        public static void Main()
        {
            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");

                TcpListener listener = new TcpListener(address, PORT_NUMBER);

                listener.Start();

                Console.WriteLine("Server started on " + listener.LocalEndpoint);
                
                Console.WriteLine("Waiting for a connection...");

                TcpClient socket = listener.AcceptTcpClient();

                Console.WriteLine("A client has connected");
               
                Stream ns = socket.GetStream();

               

                Thread recvThread = new Thread(()=>ReceiverThread(ns));
                recvThread.Start();
                recvThread.Join();

                socket.Close();
                listener.Stop();
                ns.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.Read();

        }
        public static void ReceiverThread(Stream ns)
        {
            while (true)
            {
                try
                {

                    byte[] data = new byte[BUFFER_SIZE];

                    ns.Read(data, 0, BUFFER_SIZE);

                    string result = encoding.GetString(data);
                    while (result.Contains("  "))
                    {
                       result = result.Replace("  ", " ");
                    }
                    while (result.Contains("\n"))
                    {
                        result = result.Replace("\n", " ");
                    }
                    while (result.Contains("\t"))
                    {
                        result = result.Replace("\t", " ");
                    }
                    result = result.Trim();
                    string[] num = result.Split(' ');
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
                        s += Convert.ToString(i) + " ";
                    }
                    Console.Write(s);

                    ns.Write(Encoding.ASCII.GetBytes(s), 0, s.Length);
                }
                catch(Exception e)
                {
                    break;
                }
            }
        }
    }
}
