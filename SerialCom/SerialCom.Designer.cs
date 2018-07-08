namespace SerialCom
{
    partial class SerialCom
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
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.OutputBoxLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.PortNameBox = new System.Windows.Forms.TextBox();
            this.PortNameLabel = new System.Windows.Forms.Label();
            this.BaudLabel = new System.Windows.Forms.Label();
            this.BaudRateBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageBox
            // 
            this.MessageBox.BackColor = System.Drawing.Color.White;
            this.MessageBox.Location = new System.Drawing.Point(11, 239);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(213, 20);
            this.MessageBox.TabIndex = 1;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(8, 223);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(91, 13);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.Text = "Message to send:";
            // 
            // OutputBoxLabel
            // 
            this.OutputBoxLabel.AutoSize = true;
            this.OutputBoxLabel.Location = new System.Drawing.Point(8, 57);
            this.OutputBoxLabel.Name = "OutputBoxLabel";
            this.OutputBoxLabel.Size = new System.Drawing.Size(42, 13);
            this.OutputBoxLabel.TabIndex = 4;
            this.OutputBoxLabel.Text = "Output:";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(230, 237);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 24);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.White;
            this.OutputBox.Location = new System.Drawing.Point(12, 74);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputBox.Size = new System.Drawing.Size(293, 146);
            this.OutputBox.TabIndex = 6;
            // 
            // PortNameBox
            // 
            this.PortNameBox.Location = new System.Drawing.Point(11, 25);
            this.PortNameBox.Name = "PortNameBox";
            this.PortNameBox.Size = new System.Drawing.Size(65, 20);
            this.PortNameBox.TabIndex = 7;
            // 
            // PortNameLabel
            // 
            this.PortNameLabel.AutoSize = true;
            this.PortNameLabel.Location = new System.Drawing.Point(8, 9);
            this.PortNameLabel.Name = "PortNameLabel";
            this.PortNameLabel.Size = new System.Drawing.Size(58, 13);
            this.PortNameLabel.TabIndex = 8;
            this.PortNameLabel.Text = "Port name:";
            // 
            // BaudLabel
            // 
            this.BaudLabel.AutoSize = true;
            this.BaudLabel.Location = new System.Drawing.Point(85, 9);
            this.BaudLabel.Name = "BaudLabel";
            this.BaudLabel.Size = new System.Drawing.Size(61, 13);
            this.BaudLabel.TabIndex = 10;
            this.BaudLabel.Text = "Baud Rate:";
            // 
            // BaudRateBox
            // 
            this.BaudRateBox.Location = new System.Drawing.Point(82, 25);
            this.BaudRateBox.Name = "BaudRateBox";
            this.BaudRateBox.Size = new System.Drawing.Size(65, 20);
            this.BaudRateBox.TabIndex = 9;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(157, 22);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(71, 24);
            this.ConnectButton.TabIndex = 11;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(234, 22);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(71, 24);
            this.DisconnectButton.TabIndex = 12;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // SerialCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 271);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.BaudLabel);
            this.Controls.Add(this.BaudRateBox);
            this.Controls.Add(this.PortNameLabel);
            this.Controls.Add(this.PortNameBox);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.OutputBoxLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MessageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SerialCom";
            this.Text = "Serial Com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label OutputBoxLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.TextBox PortNameBox;
        private System.Windows.Forms.Label PortNameLabel;
        private System.Windows.Forms.Label BaudLabel;
        private System.Windows.Forms.TextBox BaudRateBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
    }
}

