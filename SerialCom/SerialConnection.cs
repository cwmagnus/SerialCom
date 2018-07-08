using System.IO.Ports;
using System.IO;

namespace SerialCom
{
    /// <summary>
    /// Handles connecting a serial port.
    /// </summary>
    public class SerialConnection
    {
        public SerialPort Port { get; private set; }

        /// <summary>
        /// Initialize the port.
        /// </summary>
        public SerialConnection()
        {
            Port = new SerialPort();
        }

        /// <summary>
        /// Try to connect the port.
        /// </summary>
        /// <param name="portName">Port to connect.</param>
        /// <param name="baudRate">Baud rate to connect at.</param>
        public void Connect(string portName, int baudRate)
        {
            try
            {
                Port.PortName = portName;
                Port.BaudRate = baudRate;
                Port.Open();
                Logger.WriteLine($"Connected to {Port.PortName}");
            }
            catch (IOException e)
            {
                Logger.WriteLine($"Could not connect to port: {e.Message}");
            }
        }

        /// <summary>
        /// Disconnect the serial port.
        /// </summary>
        public void Disconnect()
        {
            Port.Close();
            Logger.WriteLine($"Disconnected from {Port.PortName}");
        }
    }
}
