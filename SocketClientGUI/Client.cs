using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace SocketClientGUI
{
    class Client
    {
        private TcpClient server;
        private ASCIIEncoding encoding;
        private Stream stream;

        public Client()
        {
            server = new TcpClient();
            encoding = new ASCIIEncoding();
        }
        public Client(TcpClient server)
        {
            this.server = server;
            encoding = new ASCIIEncoding();
        }

        public void Connect(string ipAddress,int portNumber)
        {
            server.Connect(ipAddress, portNumber);
            stream = server.GetStream();

        }
        public void send(string source)
        {
            byte[] data = encoding.GetBytes(source);
            stream.Write(data,0,data.Length);
        }
        public string recv()
        {
            byte[] data = new byte[1024];
            stream.Read(data, 0, 1024);
            return encoding.GetString(data);
        }
    }
}
