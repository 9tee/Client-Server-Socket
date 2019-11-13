using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Socket_Server_GUI
{
    public partial class Form1 : Form
    {
        private static Server server = new Server();
        private static TextBox textBox = new TextBox();
        public Form1()
        {
            InitializeComponent();

            textBox.Name = "textBox";
            textBox.Enabled = false;
            textBox.Location = new Point(13, 28);
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Size = new Size(301, 207);
            this.Controls.Add(textBox);
            textBox.Text += "Server Start \r\n";
            textBox.Text += "Waiting for a connection... \r\n";

        }
        private void AcceptClientButton_Click(object sender, EventArgs e)
        {
            server.Start();
            StartButton.Enabled = false;
            ExitButton.Enabled = true;
        }
        public static void show(string s)
        {
            textBox.Invoke(new MethodInvoker(delegate ()
            {
                textBox.Text += s;
                textBox.Text += "\r\n";
                if(s == "socket is disconected")
                {
                    server.Start();
                }
            }));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            server.End();
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.End();
        }
    }
}
