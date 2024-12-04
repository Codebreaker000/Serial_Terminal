namespace Sample_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            portslist = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            send1 = new Button();
            datainput1 = new RichTextBox();
            datainput2 = new RichTextBox();
            datainput3 = new RichTextBox();
            datainput4 = new RichTextBox();
            datainput5 = new RichTextBox();
            send2 = new Button();
            send3 = new Button();
            send4 = new Button();
            send5 = new Button();
            label3 = new Label();
            bindingSource1 = new BindingSource(components);
            label4 = new Label();
            label5 = new Label();
            statuslabel = new Label();
            textBox1 = new RichTextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(567, 64);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(661, 64);
            button2.Name = "button2";
            button2.Size = new Size(87, 23);
            button2.TabIndex = 1;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // portslist
            // 
            portslist.AccessibleName = "com";
            portslist.FormattingEnabled = true;
            portslist.Items.AddRange(new object[] { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8" });
            portslist.Location = new Point(224, 62);
            portslist.Name = "portslist";
            portslist.Size = new Size(89, 23);
            portslist.TabIndex = 2;
            portslist.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 62);
            label1.Name = "label1";
            label1.Size = new Size(165, 19);
            label1.TabIndex = 3;
            label1.Text = "Available Serial Ports";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(336, 64);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 5;
            label2.Text = "Baud Rate";
            label2.Click += label2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "9600", "115200", "19200" });
            comboBox2.Location = new Point(444, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(89, 23);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // send1
            // 
            send1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            send1.Location = new Point(32, 167);
            send1.Name = "send1";
            send1.Size = new Size(75, 23);
            send1.TabIndex = 7;
            send1.Text = "Send";
            send1.UseVisualStyleBackColor = true;
            send1.Click += send1_Click;
            // 
            // datainput1
            // 
            datainput1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datainput1.Location = new Point(125, 167);
            datainput1.Name = "datainput1";
            datainput1.Size = new Size(84, 23);
            datainput1.TabIndex = 8;
            datainput1.Text = "";
            datainput1.TextChanged += richTextBox1_TextChanged;
            // 
            // datainput2
            // 
            datainput2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datainput2.Location = new Point(125, 217);
            datainput2.Name = "datainput2";
            datainput2.Size = new Size(84, 23);
            datainput2.TabIndex = 9;
            datainput2.Text = "";
            // 
            // datainput3
            // 
            datainput3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datainput3.Location = new Point(125, 263);
            datainput3.Name = "datainput3";
            datainput3.Size = new Size(84, 23);
            datainput3.TabIndex = 10;
            datainput3.Text = "";
            // 
            // datainput4
            // 
            datainput4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datainput4.Location = new Point(125, 313);
            datainput4.Name = "datainput4";
            datainput4.Size = new Size(84, 23);
            datainput4.TabIndex = 11;
            datainput4.Text = "";
            // 
            // datainput5
            // 
            datainput5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datainput5.Location = new Point(125, 363);
            datainput5.Name = "datainput5";
            datainput5.Size = new Size(84, 23);
            datainput5.TabIndex = 12;
            datainput5.Text = "";
            // 
            // send2
            // 
            send2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            send2.Location = new Point(32, 216);
            send2.Name = "send2";
            send2.Size = new Size(75, 23);
            send2.TabIndex = 13;
            send2.Text = "Send";
            send2.UseVisualStyleBackColor = true;
            send2.Click += send2_Click;
            // 
            // send3
            // 
            send3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            send3.Location = new Point(32, 263);
            send3.Name = "send3";
            send3.Size = new Size(75, 23);
            send3.TabIndex = 14;
            send3.Text = "Send";
            send3.UseVisualStyleBackColor = true;
            send3.Click += send3_Click;
            // 
            // send4
            // 
            send4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            send4.Location = new Point(32, 313);
            send4.Name = "send4";
            send4.Size = new Size(75, 23);
            send4.TabIndex = 15;
            send4.Text = "Send";
            send4.UseVisualStyleBackColor = true;
            send4.Click += send4_Click;
            // 
            // send5
            // 
            send5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            send5.Location = new Point(32, 363);
            send5.Name = "send5";
            send5.Size = new Size(75, 23);
            send5.TabIndex = 16;
            send5.Text = "Send";
            send5.UseVisualStyleBackColor = true;
            send5.Click += send5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(399, 429);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 17;
            label3.Text = "Thank You ";
            label3.Click += label3_Click;
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 119);
            label4.Name = "label4";
            label4.Size = new Size(197, 19);
            label4.TabIndex = 18;
            label4.Text = "Send Command Sequence";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 90);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 19;
            label5.Click += label5_Click;
            // 
            // statuslabel
            // 
            statuslabel.AutoSize = true;
            statuslabel.Font = new Font("Book Antiqua", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statuslabel.Location = new Point(609, 103);
            statuslabel.Name = "statuslabel";
            statuslabel.Size = new Size(73, 15);
            statuslabel.TabIndex = 20;
            statuslabel.Text = "Disconnected";
            statuslabel.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(524, 219);
            textBox1.TabIndex = 21;
            textBox1.Text = "";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(652, 401);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 22;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 472);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(statuslabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(send5);
            Controls.Add(send4);
            Controls.Add(send3);
            Controls.Add(send2);
            Controls.Add(datainput5);
            Controls.Add(datainput4);
            Controls.Add(datainput3);
            Controls.Add(datainput2);
            Controls.Add(datainput1);
            Controls.Add(send1);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(portslist);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Serial Terminal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox portslist;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Button send1;
        private RichTextBox datainput1;
        private RichTextBox datainput2;
        private RichTextBox datainput3;
        private RichTextBox datainput4;
        private RichTextBox datainput5;
        private Button send2;
        private Button send3;
        private Button send4;
        private Button send5;
        private Label label3;
        private BindingSource bindingSource1;
        private Label label4;
        private Label label5;
        private Label statuslabel;
        private RichTextBox textBox1;
        private Button button3;
    }
}
