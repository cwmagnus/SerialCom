using System;
using System.Windows.Forms;

namespace SerialCom
{
    /// <summary>
    /// Handles UI interaction.
    /// </summary>
    public partial class SerialCom : Form
    {
        private SerialConnection serialConnection = new SerialConnection();

        /// <summary>
        /// Initialize the UI.
        /// </summary>
        public SerialCom()
        {
            InitializeComponent();
            Logger.Initialize(OutputBox);
        }

        /// <summary>
        /// Handles when the send button is clicked.
        /// </summary>
        /// <param name="sender">What was clicked.</param>
        /// <param name="e">Event parameters.</param>
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (serialConnection.Port.IsOpen)
            {
                serialConnection.Port.Write(MessageBox.Text);
                Logger.WriteLine($"{MessageBox.Text} [Sent {DateTime.Now.ToString("t")}]");
                MessageBox.Text = string.Empty;
            }
            else
            {
                Logger.WriteLine("Not connected to serial port");
            }
        }

        /// <summary>
        /// Handles when the connect button is clicked.
        /// </summary>
        /// <param name="sender">What was clicked.</param>
        /// <param name="e">Event parameters.</param>
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (PortNameBox.Text != string.Empty && BaudRateBox.Text != string.Empty)
            {
                if (int.TryParse(BaudRateBox.Text, out int baudRate))
                {
                    serialConnection.Connect(PortNameBox.Text, baudRate);
                }
                else
                {
                    Logger.WriteLine("Invalid baud rate");
                }
            }
            else
            {
                Logger.WriteLine("Enter a port name and baud rate");
            }
        }

        /// <summary>
        /// Handles when the disconnect button is clicked.
        /// </summary>
        /// <param name="sender">What was clicked.</param>
        /// <param name="e">Event parameters.</param>
        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (serialConnection.Port.IsOpen)
            {
                serialConnection.Disconnect();
            }
            else
            {
                Logger.WriteLine("Not connected to serial port");
            }
        }
    }
}
