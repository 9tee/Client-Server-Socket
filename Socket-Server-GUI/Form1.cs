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
        private Server server = new Server();
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
            StartButton.Enabled = false;
            ExitButton.Enabled = true;
            server.Start();
        }
        public static void show(string s)
        {
            textBox.Invoke(new MethodInvoker(delegate ()
            {
                textBox.Text += s;
                textBox.Text += "\r\n";
            }));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            server.End();
            this.Close();
        }
    }
}
