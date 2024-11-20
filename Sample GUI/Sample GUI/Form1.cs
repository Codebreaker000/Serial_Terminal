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
            // Your code here
            try
            {
                string receivedData = serialPort1.ReadLine();
                this.Invoke(new MethodInvoker(delegate
                {
                    textBox1.AppendText($"Received: {receivedData}{Environment.NewLine}");
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    textBox1.AppendText($"Error: {ex.Message}{Environment.NewLine}");

                }));
            }
        }
        private void send1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    string dataToSend = datainput1.Text; // Get data from TextBox
                    serialPort1.WriteLine(dataToSend);    // Send data
                    textBox1.AppendText($"Sent: {dataToSend}{Environment.NewLine}\n"); // Log sent data
                                                                                       // Set the color to red for received data
                    textBox1.SelectionColor = Color.Red;

                }
                catch (Exception ex)
                {
                    textBox1.AppendText($"Error: {ex.Message}{Environment.NewLine}\n");
                }
            }
            else
            {
                textBox1.AppendText($"Error: Serial port is not connected.{Environment.NewLine}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void send2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    string dataToSend = datainput2.Text; // Get data from TextBox
                    serialPort1.WriteLine(dataToSend);    // Send data
                    textBox1.AppendText($"Sent: {dataToSend}{Environment.NewLine}\n"); // Log sent data
                                                                                       // Set the color to red for received data
                    textBox1.SelectionColor = Color.Red;

                }
                catch (Exception ex)
                {
                    textBox1.AppendText($"Error: {ex.Message}{Environment.NewLine}\n");
                }
            }
            else
            {
                textBox1.AppendText($"Error: Serial port is not connected.{Environment.NewLine}");
            }
        }

        private void send3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    string dataToSend = datainput3.Text; // Get data from TextBox
                    serialPort1.WriteLine(dataToSend);    // Send data
                    textBox1.AppendText($"Sent: {dataToSend}{Environment.NewLine}\n"); // Log sent data
                                                                                       // Set the color to red for received data
                    textBox1.SelectionColor = Color.Red;

                }
                catch (Exception ex)
                {
                    textBox1.AppendText($"Error: {ex.Message}{Environment.NewLine}\n");
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
                    string dataToSend = datainput4.Text; // Get data from TextBox
                    serialPort1.WriteLine(dataToSend);    // Send data
                    textBox1.AppendText($"Sent: {dataToSend}{Environment.NewLine}\n"); // Log sent data
                                                                                       // Set the color to red for received data
                    textBox1.SelectionColor = Color.Red;

                }
                catch (Exception ex)
                {
                    textBox1.AppendText($"Error: {ex.Message}{Environment.NewLine}\n");
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
                    string dataToSend = datainput5.Text; // Get data from TextBox
                    serialPort1.WriteLine(dataToSend);    // Send data
                    textBox1.AppendText($"Sent: {dataToSend}{Environment.NewLine}\n"); // Log sent data
                                                                                       // Set the color to red for received data
                    textBox1.SelectionColor = Color.Red;

                }
                catch (Exception ex)
                {
                    textBox1.AppendText($"Error: {ex.Message}{Environment.NewLine}\n");
                }
            }
            else
            {
                textBox1.AppendText($"Error: Serial port is not connected.{Environment.NewLine}");
            }
        }
    }
}
