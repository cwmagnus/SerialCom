using System;
using System.Windows.Forms;

namespace SerialCom
{
    /// <summary>
    /// Logs messages to the UI output box.
    /// </summary>
    public static class Logger
    {
        private static TextBox outputBox;

        /// <summary>
        /// Set the output box to write to.
        /// </summary>
        /// <param name="outputTextBox"></param>
        public static void Initialize(TextBox outputTextBox)
        {
            outputBox = outputTextBox;
        }

        /// <summary>
        /// Write to the output box.
        /// </summary>
        /// <param name="message">Message to write.</param>
        public static void Write(string message)
        {
            outputBox.AppendText(message);
        }

        /// <summary>
        /// Write to the output box and start a new line.
        /// </summary>
        /// <param name="message">Message to write.</param>
        public static void WriteLine(string message)
        {
            outputBox.AppendText(message);
            outputBox.AppendText(Environment.NewLine);
        }
    }
}
