using System;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Socket_Server_GUI
{
    class Server
    {
        private const int BUFFER_SIZE = 100;
        private const int PORT_NUMBER = 9999;
        private ASCIIEncoding encoding;
        private IPAddress address;
        private TcpListener listener;
        private TcpClient socket;
        //private Timer timer = new Timer();
        private Stream ns; 
        private Thread recvThread; 
        private int countClient = -1;

        public Server()
        {
            address = IPAddress.Parse("127.0.0.1");
            listener = new TcpListener(address, PORT_NUMBER);
            encoding = new ASCIIEncoding();
        }

        public void End()
        {
            try
            {
                socket.Close();
                listener.Stop();
                ns.Close();
            }catch (Exception e)
            {

            }
        }
         
        public void Start()
        {
            listener.Start();
            countClient++;
            socket = listener.AcceptTcpClient();
            
            string s = "A client has connected";
            Form1.show(s);
            ns = socket.GetStream();
            recvThread = new Thread(() => RevAndSend(ns));
            recvThread.Start();
        }

        public void RevAndSend(Stream ns)
        {
            countClient++;
            while (true)
            {
                try
                {

                    byte[] data = new byte[BUFFER_SIZE];

                    ns.Read(data, 0, BUFFER_SIZE);

                    string result = encoding.GetString(data);
                    Form1.show("Chuoi nhan : " + result);
                    string[] num = result.Split(' ');
                    int[] arr = new int[num.Length];

                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(num[i]);
                    }
                    Array.Sort(arr);
                    String s = "";
                    foreach (int i in arr)
                    {
                        s += Convert.ToString(i) + " ";
                    }
                    Form1.show("Chuoi tra : " + s);

                    ns.Write(Encoding.ASCII.GetBytes(s), 0, s.Length);
                   
                }
                catch (Exception e)
                {
                    Form1.show("socket is disconected");
                    break;
                }
            }
        }

    }
}
