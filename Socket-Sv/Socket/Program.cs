using System;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Text;
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
                IPAddress address = IPAddress.Parse("127.0.0.1");

                TcpListener listener = new TcpListener(address, PORT_NUMBER);

                listener.Start();
                Console.WriteLine("Server started on " + listener.LocalEndpoint);
                
                Console.WriteLine("Waiting for a connection...");

                TcpClient socket = listener.AcceptTcpClient();
               
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
                    //sock.Receive(data);
                    ns.Read(data, 0, data.Length);

                    string str = encoding.GetString(data,0, ns.Read(data, 0, data.Length));
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
                    //sock.Send(encoding.GetBytes(s));
                    ns.Write(Encoding.ASCII.GetBytes(s), 0, s.Length);
                    ns.Flush();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
