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
            this.receiveBox.Location = new System.Drawing.Point(447, 65);
            this.receiveBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.receiveBox.Multiline = true;
            this.receiveBox.Name = "receiveBox";
            this.receiveBox.Size = new System.Drawing.Size(399, 270);
            this.receiveBox.TabIndex = 0;
            // 
            // sendBox
            // 
            this.sendBox.Enabled = false;
            this.sendBox.Location = new System.Drawing.Point(16, 65);
            this.sendBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(399, 270);
            this.sendBox.TabIndex = 1;
            this.sendBox.TextChanged += new System.EventHandler(this.sendBox_TextChanged);
            // 
            // sortButton
            // 
            this.sortButton.Enabled = false;
            this.sortButton.Location = new System.Drawing.Point(83, 16);
            this.sortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(113, 28);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(737, 18);
            this.portBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(107, 22);
            this.portBox.TabIndex = 3;
            this.portBox.TextChanged += new System.EventHandler(this.portBox_TextChanged);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(487, 20);
            this.ipBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(199, 22);
            this.ipBox.TabIndex = 3;
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(695, 22);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(34, 17);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "Port";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(456, 23);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 17);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "IP";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(249, 17);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 28);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            this.connectButton.Enabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 351);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.receiveBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

