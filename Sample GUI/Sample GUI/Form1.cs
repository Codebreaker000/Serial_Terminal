using System;
using System.IO.Ports;
using System.Windows.Forms;
namespace Sample_GUI
{
    public partial class Form1 : Form

    {
        private SerialPort serialPort1;
        public Form1()
        {

            InitializeComponent();
            serialPort1 = new SerialPort();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the available serial port names
            string[] ports = SerialPort.GetPortNames();

            // Clear the existing items in the ComboBox (optional, but good practice)
            portslist.Items.Clear();

            // Add the available ports to the ComboBox
            portslist.Items.AddRange(ports);
            serialPort1.DataReceived += SerialPort1_DataReceived;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    // Set properties for the serial port
                    serialPort1.PortName = portslist.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);   // Set baud rate
                    serialPort1.Parity = Parity.None; // Set parity
                    serialPort1.DataBits = 8;         // Set data bits
                    serialPort1.StopBits = StopBits.One; // Set stop bits

                    // Open the serial port
                    serialPort1.Open();
                    statuslabel.Text = "Connected";
                    statuslabel.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., port not available)
                    //.Show($"Error: {ex.Message}");
                    statuslabel.Text = "Error Opening";
                    statuslabel.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                // If the port is already open, close it
                serialPort1.Close();
                //MessageBox.Show("Serial port closed.");
                // statuslabel.Text = "Disconnected";
                statuslabel.Text = "Already Connected";
                statuslabel.ForeColor = System.Drawing.Color.Orange;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // Close the serial port
                serialPort1.Close();

                // Update UI for disconnected state
                statuslabel.Text = "Disconnected";
                statuslabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                statuslabel.Text = "Already Disconnected";
                statuslabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read data from the serial port
                string receivedData = serialPort1.ReadExisting();

                // Update the UI using Invoke to ensure thread safety
                this.Invoke(new MethodInvoker(() =>
                {
                    //textBox1.AppendText($"Received: {receivedData}{Environment.NewLine}");

                    AppendTextInColor(textBox1, $"Received: {receivedData} ", Color.Red);


                }));
            }
            catch (Exception ex)
            {
                // Handle exceptions
                this.Invoke(new MethodInvoker(() =>
                {
                    textBox1.AppendText($"Error: {ex.Message}{Environment.NewLine}");
                }));
            }
        }

        private void AppendTextInColor(RichTextBox richTextBox, string text, Color color)
        {
            richTextBox.Invoke(new MethodInvoker(() =>
            {
                richTextBox.SelectionStart = richTextBox.TextLength;  // Set cursor at the end
                richTextBox.SelectionLength = 0;                     // Clear selection
                richTextBox.SelectionColor = color;                  // Set color for text
                richTextBox.AppendText($"{text}{Environment.NewLine}"); // Append text with newline
                richTextBox.SelectionColor = richTextBox.ForeColor;  // Reset color
            }));
        }
        private void send1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get data from the TextBox
                string dataToSend = datainput1.Text.Trim(); // Trim removes leading/trailing whitespace

                // Validate input
                if (string.IsNullOrEmpty(dataToSend))
                {
                    MessageBox.Show("Please enter hexadecimal values separated by spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Split the input into individual hex values
                string[] hexValues = dataToSend.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // Convert hex values to bytes
                byte[] dataBytes = hexValues.Select(hex => Convert.ToByte(hex, 16)).ToArray();

                // Send the bytes over the serial port
                serialPort1.Write(dataBytes, 0, dataBytes.Length);

                // Log sent data in the RichTextBox
                textBox1.SelectionColor = Color.Black; // Set color to black for sent data
                textBox1.AppendText($"Sent: {string.Join(" ", dataBytes.Select(b => $"0x{b:X2}"))}{Environment.NewLine}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid hexadecimal value detected. Please enter valid hex values separated by spaces (e.g., '0 2').", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to append text in a specified color
    

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void send2_Click(object sender, EventArgs e)
        {

            try
            {
                // Get data from the TextBox
                string dataToSend = datainput2.Text.Trim(); // Trim removes leading/trailing whitespace

                // Validate input
                if (string.IsNullOrEmpty(dataToSend))
                {
                    MessageBox.Show("Please enter hexadecimal values separated by spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Split the input into individual hex values
                string[] hexValues = dataToSend.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // Convert hex values to bytes
                byte[] dataBytes = hexValues.Select(hex => Convert.ToByte(hex, 16)).ToArray();

                // Send the bytes over the serial port
                serialPort1.Write(dataBytes, 0, dataBytes.Length);

                // Log sent data in the RichTextBox
                textBox1.SelectionColor = Color.Black; // Set color to black for sent data
                textBox1.AppendText($"Sent: {string.Join(" ", dataBytes.Select(b => $"0x{b:X2}"))}{Environment.NewLine}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid hexadecimal value detected. Please enter valid hex values separated by spaces (e.g., '0 2').", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void send3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                try
                {
                    // Get data from the TextBox
                    string dataToSend = datainput3.Text.Trim(); // Trim removes leading/trailing whitespace

                    // Validate input
                    if (string.IsNullOrEmpty(dataToSend))
                    {
                        MessageBox.Show("Please enter hexadecimal values separated by spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Split the input into individual hex values
                    string[] hexValues = dataToSend.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    // Convert hex values to bytes
                    byte[] dataBytes = hexValues.Select(hex => Convert.ToByte(hex, 16)).ToArray();

                    // Send the bytes over the serial port
                    serialPort1.Write(dataBytes, 0, dataBytes.Length);

                    // Log sent data in the RichTextBox
                    textBox1.SelectionColor = Color.Black; // Set color to black for sent data
                    textBox1.AppendText($"Sent: {string.Join(" ", dataBytes.Select(b => $"0x{b:X2}"))}{Environment.NewLine}");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid hexadecimal value detected. Please enter valid hex values separated by spaces (e.g., '0 2').", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textBox1.AppendText($"Error: Serial port is not connected.{Environment.NewLine}");
            }
        }

        private void send4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                try
                {
                    // Get data from the TextBox
                    string dataToSend = datainput4.Text.Trim(); // Trim removes leading/trailing whitespace

                    // Validate input
                    if (string.IsNullOrEmpty(dataToSend))
                    {
                        MessageBox.Show("Please enter hexadecimal values separated by spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Split the input into individual hex values
                    string[] hexValues = dataToSend.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    // Convert hex values to bytes
                    byte[] dataBytes = hexValues.Select(hex => Convert.ToByte(hex, 16)).ToArray();

                    // Send the bytes over the serial port
                    serialPort1.Write(dataBytes, 0, dataBytes.Length);

                    // Log sent data in the RichTextBox
                    textBox1.SelectionColor = Color.Black; // Set color to black for sent data
                    textBox1.AppendText($"Sent: {string.Join(" ", dataBytes.Select(b => $"0x{b:X2}"))}{Environment.NewLine}");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid hexadecimal value detected. Please enter valid hex values separated by spaces (e.g., '0 2').", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textBox1.AppendText($"Error: Serial port is not connected.{Environment.NewLine}");
            }
        }

        private void send5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                try
                {
                    // Get data from the TextBox
                    string dataToSend = datainput5.Text.Trim(); // Trim removes leading/trailing whitespace

                    // Validate input
                    if (string.IsNullOrEmpty(dataToSend))
                    {
                        MessageBox.Show("Please enter hexadecimal values separated by spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Split the input into individual hex values
                    string[] hexValues = dataToSend.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    // Convert hex values to bytes
                    byte[] dataBytes = hexValues.Select(hex => Convert.ToByte(hex, 16)).ToArray();

                    // Send the bytes over the serial port
                    serialPort1.Write(dataBytes, 0, dataBytes.Length);

                    // Log sent data in the RichTextBox
                    textBox1.SelectionColor = Color.Black; // Set color to black for sent data
                    textBox1.AppendText($"Sent: {string.Join(" ", dataBytes.Select(b => $"0x{b:X2}"))}{Environment.NewLine}");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid hexadecimal value detected. Please enter valid hex values separated by spaces (e.g., '0 2').", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textBox1.AppendText($"Error: Serial port is not connected.{Environment.NewLine}");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
