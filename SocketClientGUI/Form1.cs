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

        private void ipBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(portBox.Text, "^()([1-9]|[1-5]?[0-9]{2,4}|6[1-4][0-9]{3}|65[1-4][0-9]{2}|655[1-2][0-9]|6553[1-5])$") && Regex.IsMatch(ipBox.Text, "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"))
            {
                connectButton.Enabled = true;
            }
            else
            {
                connectButton.Enabled = false;
            }
        }

        private void portBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(portBox.Text, "^()([1-9]|[1-5]?[0-9]{2,4}|6[1-4][0-9]{3}|65[1-4][0-9]{2}|655[1-2][0-9]|6553[1-5])$") && Regex.IsMatch(ipBox.Text, "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"))
            {
                connectButton.Enabled = true;
            }
            else
            {
                connectButton.Enabled = false;
            }
        }
    }
}
