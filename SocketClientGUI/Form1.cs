using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace SocketClientGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            client.Connect(ipBox.Text, Int32.Parse(portBox.Text));
            sortButton.Enabled = true;
            sendBox.Enabled = true;
            receiveBox.BackColor = Color.White;
            receiveBox.ForeColor = Color.Black;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            while (sendBox.Text.Contains("  "))
            {
                sendBox.Text = sendBox.Text.Replace("  ", " ");
            }
            sendBox.Text = sendBox.Text.Trim();
            client.send(sendBox.Text);
            receiveBox.Text = client.recv();
        }

        private void sendBox_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(sendBox.Text, "^[0-9 ]*$"))
            {
                sortButton.Enabled = true;
            }
            else
            {
                sortButton.Enabled = false;
            }
            
        }
    }
}
