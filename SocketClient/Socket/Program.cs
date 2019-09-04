using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading;

public class Y2Client
{

    private const int BUFFER_SIZE = 1024;
    private const int PORT_NUMBER = 9999;

    static ASCIIEncoding encoding = new ASCIIEncoding();

    public static void Main()
    {

        try
        {
            TcpClient client = new TcpClient();

            // 1. connect
            client.Connect("192.168.0.101", PORT_NUMBER);
            Stream stream = client.GetStream();

            Console.WriteLine("Connected to Y2Server.");
            Console.Write("Enter your name: ");

            Thread writeThread = new Thread(() => write(stream));

            writeThread.Start();

            writeThread.Join();
            // 3. receive
            byte[] data = new byte[BUFFER_SIZE];
            stream.Read(data, 0, BUFFER_SIZE);

            Console.WriteLine(encoding.GetString(data));

            // 4. Close

        }

        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex);
        }

        Console.Read();
    }
    public static void write(Stream stream)
    {
        while (true)
        {
            string str = Console.ReadLine();

            // 2. send
            byte[] data = encoding.GetBytes(str);

            stream.Write(data, 0, data.Length);
            data = encoding.GetBytes(str);
        }
    }
}