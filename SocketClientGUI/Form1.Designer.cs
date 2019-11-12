namespace SocketClientGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.receiveBox = new System.Windows.Forms.TextBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receiveBox
            // 
            this.receiveBox.Enabled = false;
            this.receiveBox.Location = new System.Drawing.Point(335, 53);
            this.receiveBox.Multiline = true;
            this.receiveBox.Name = "receiveBox";
            this.receiveBox.Size = new System.Drawing.Size(300, 220);
            this.receiveBox.TabIndex = 0;
            // 
            // sendBox
            // 
            this.sendBox.Enabled = false;
            this.sendBox.Location = new System.Drawing.Point(12, 53);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(300, 220);
            this.sendBox.TabIndex = 1;
            this.sendBox.TextChanged += new System.EventHandler(this.sendBox_TextChanged);
            // 
            // sortButton
            // 
            this.sortButton.Enabled = false;
            this.sortButton.Location = new System.Drawing.Point(62, 13);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(85, 23);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(553, 15);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(81, 20);
            this.portBox.TabIndex = 3;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(365, 16);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(150, 20);
            this.ipBox.TabIndex = 4;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(521, 18);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "Port";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(342, 19);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 13);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "IP";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(187, 14);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 285);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.receiveBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Number sorting program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox receiveBox;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button connectButton;
        private Client client = new Client();
    }
}

