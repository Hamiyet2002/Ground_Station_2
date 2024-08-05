namespace Ground_Station_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Portlar = new System.Windows.Forms.Label();
            this.Baud = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonRefreshPorts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.Başlık = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.Templabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaxAltitudelabel1 = new System.Windows.Forms.Label();
            this.MaxAltitude = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.Millslabel1 = new System.Windows.Forms.Label();
            this.Mills = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.Locationlabel1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Location1 = new System.Windows.Forms.Label();
            this.AccZlabel1 = new System.Windows.Forms.Label();
            this.AccYlabel1 = new System.Windows.Forms.Label();
            this.AccXlabel1 = new System.Windows.Forms.Label();
            this.AccZ = new System.Windows.Forms.Label();
            this.AccY = new System.Windows.Forms.Label();
            this.AccX = new System.Windows.Forms.Label();
            this.Altitudelabel1 = new System.Windows.Forms.Label();
            this.Altitude = new System.Windows.Forms.Label();
            this.Presslabel1 = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBoxSerialOutput = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SerialScreenlabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 505);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 567);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // Portlar
            // 
            this.Portlar.AutoSize = true;
            this.Portlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Portlar.ForeColor = System.Drawing.Color.Firebrick;
            this.Portlar.Location = new System.Drawing.Point(11, 474);
            this.Portlar.Name = "Portlar";
            this.Portlar.Size = new System.Drawing.Size(96, 25);
            this.Portlar.TabIndex = 2;
            this.Portlar.Text = "PORTS:";
            this.Portlar.Click += new System.EventHandler(this.label1_Click);
            // 
            // Baud
            // 
            this.Baud.AutoSize = true;
            this.Baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baud.ForeColor = System.Drawing.Color.Firebrick;
            this.Baud.Location = new System.Drawing.Point(12, 540);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(145, 24);
            this.Baud.TabIndex = 3;
            this.Baud.Text = "BAUD RATES:";
            this.Baud.Click += new System.EventHandler(this.Baud_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(200, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "On ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(200, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "Off";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRefreshPorts
            // 
            this.buttonRefreshPorts.Location = new System.Drawing.Point(16, 443);
            this.buttonRefreshPorts.Name = "buttonRefreshPorts";
            this.buttonRefreshPorts.Size = new System.Drawing.Size(84, 25);
            this.buttonRefreshPorts.TabIndex = 8;
            this.buttonRefreshPorts.Text = "Refresh";
            this.buttonRefreshPorts.UseVisualStyleBackColor = true;
            this.buttonRefreshPorts.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(173, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bağlantı durumu...";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(115, 446);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(63, 53);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 21;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Click += new System.EventHandler(this.pictureBox18_Click);
            // 
            // Başlık
            // 
            this.Başlık.AutoSize = true;
            this.Başlık.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Başlık.ForeColor = System.Drawing.Color.Firebrick;
            this.Başlık.Location = new System.Drawing.Point(70, 23);
            this.Başlık.Name = "Başlık";
            this.Başlık.Size = new System.Drawing.Size(468, 25);
            this.Başlık.TabIndex = 22;
            this.Başlık.Text = "TURNA ROCKET TEAM GROUND STATION";
            this.Başlık.Click += new System.EventHandler(this.Başlık_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(12, 12);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(52, 46);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 27;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            // 
            // Templabel1
            // 
            this.Templabel1.AutoSize = true;
            this.Templabel1.BackColor = System.Drawing.SystemColors.Control;
            this.Templabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Templabel1.Location = new System.Drawing.Point(203, 50);
            this.Templabel1.Name = "Templabel1";
            this.Templabel1.Size = new System.Drawing.Size(21, 20);
            this.Templabel1.TabIndex = 28;
            this.Templabel1.Text = "...";
            this.Templabel1.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.MaxAltitudelabel1);
            this.panel1.Controls.Add(this.MaxAltitude);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Millslabel1);
            this.panel1.Controls.Add(this.Mills);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(561, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 470);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MaxAltitudelabel1
            // 
            this.MaxAltitudelabel1.AutoSize = true;
            this.MaxAltitudelabel1.BackColor = System.Drawing.SystemColors.Control;
            this.MaxAltitudelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaxAltitudelabel1.Location = new System.Drawing.Point(218, 433);
            this.MaxAltitudelabel1.Name = "s";
            this.MaxAltitudelabel1.Size = new System.Drawing.Size(17, 20);
            this.MaxAltitudelabel1.TabIndex = 36;
            this.MaxAltitudelabel1.Text = "s";
            // 
            // MaxAltitude
            // 
            this.MaxAltitude.AutoSize = true;
            this.MaxAltitude.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MaxAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaxAltitude.Location = new System.Drawing.Point(73, 433);
            this.MaxAltitude.Name = "MaxAltitude";
            this.MaxAltitude.Size = new System.Drawing.Size(96, 20);
            this.MaxAltitude.TabIndex = 35;
            this.MaxAltitude.Text = "Max Altitude";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Firebrick;
            this.panel5.Controls.Add(this.pictureBox8);
            this.panel5.Location = new System.Drawing.Point(328, 369);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 37);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(264, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // Millslabel1
            // 
            this.Millslabel1.AutoSize = true;
            this.Millslabel1.BackColor = System.Drawing.SystemColors.Control;
            this.Millslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Millslabel1.Location = new System.Drawing.Point(505, 433);
            this.Millslabel1.Name = "Millslabel1";
            this.Millslabel1.Size = new System.Drawing.Size(21, 20);
            this.Millslabel1.TabIndex = 34;
            this.Millslabel1.Text = "...";
            this.Millslabel1.Click += new System.EventHandler(this.Millslabel1_Click);
            // 
            // Mills
            // 
            this.Mills.AutoSize = true;
            this.Mills.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Mills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mills.Location = new System.Drawing.Point(408, 433);
            this.Mills.Name = "Mills";
            this.Mills.Size = new System.Drawing.Size(39, 20);
            this.Mills.TabIndex = 33;
            this.Mills.Text = "Mills";
            this.Mills.Click += new System.EventHandler(this.Mills_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(329, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 391);
            this.panel3.TabIndex = 32;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(79, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payload Computer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.Location1);
            this.panel2.Controls.Add(this.AccZlabel1);
            this.panel2.Controls.Add(this.AccYlabel1);
            this.panel2.Controls.Add(this.AccXlabel1);
            this.panel2.Controls.Add(this.AccZ);
            this.panel2.Controls.Add(this.AccY);
            this.panel2.Controls.Add(this.AccX);
            this.panel2.Controls.Add(this.Altitudelabel1);
            this.panel2.Controls.Add(this.Altitude);
            this.panel2.Controls.Add(this.Presslabel1);
            this.panel2.Controls.Add(this.Pressure);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Temperature);
            this.panel2.Controls.Add(this.Templabel1);
            this.panel2.Location = new System.Drawing.Point(15, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 391);
            this.panel2.TabIndex = 31;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(11, 277);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(44, 39);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(11, 232);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 187);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 133);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Controls.Add(this.Locationlabel1);
            this.panel4.Location = new System.Drawing.Point(0, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 38);
            this.panel4.TabIndex = 41;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(279, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(28, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // Locationlabel1
            // 
            this.Locationlabel1.AutoSize = true;
            this.Locationlabel1.BackColor = System.Drawing.SystemColors.Control;
            this.Locationlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Locationlabel1.Location = new System.Drawing.Point(137, 9);
            this.Locationlabel1.Name = "Locationlabel1";
            this.Locationlabel1.Size = new System.Drawing.Size(21, 20);
            this.Locationlabel1.TabIndex = 0;
            this.Locationlabel1.Text = "...";
            this.Locationlabel1.Click += new System.EventHandler(this.Locationlabel1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Location1
            // 
            this.Location1.AutoSize = true;
            this.Location1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Location1.Location = new System.Drawing.Point(115, 321);
            this.Location1.Name = "Location1";
            this.Location1.Size = new System.Drawing.Size(70, 20);
            this.Location1.TabIndex = 42;
            this.Location1.Text = "Location";
            this.Location1.Click += new System.EventHandler(this.Location1_Click);
            // 
            // AccZlabel1
            // 
            this.AccZlabel1.AutoSize = true;
            this.AccZlabel1.BackColor = System.Drawing.SystemColors.Control;
            this.AccZlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccZlabel1.Location = new System.Drawing.Point(203, 289);
            this.AccZlabel1.Name = "AccZlabel1";
            this.AccZlabel1.Size = new System.Drawing.Size(21, 20);
            this.AccZlabel1.TabIndex = 40;
            this.AccZlabel1.Text = "...";
            this.AccZlabel1.Click += new System.EventHandler(this.AccZlabel1_Click);
            // 
            // AccYlabel1
            // 
            this.AccYlabel1.AutoSize = true;
            this.AccYlabel1.BackColor = System.Drawing.SystemColors.Control;
            this.AccYlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccYlabel1.Location = new System.Drawing.Point(203, 242);
            this.AccYlabel1.Name = "AccYlabel1";
            this.AccYlabel1.Size = new System.Drawing.Size(21, 20);
            this.AccYlabel1.TabIndex = 39;
            this.AccYlabel1.Text = "...";
            this.AccYlabel1.Click += new System.EventHandler(this.AccYlabel1_Click);
            // 
            // AccXlabel1
            // 
            this.AccXlabel1.AutoSize = true;
            this.AccXlabel1.BackColor = System.Drawing.SystemColors.Control;
            this.AccXlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccXlabel1.Location = new System.Drawing.Point(203, 196);
            this.AccXlabel1.Name = "AccXlabel1";
            this.AccXlabel1.Size = new System.Drawing.Size(21, 20);
            this.AccXlabel1.TabIndex = 38;
            this.AccXlabel1.Text = "...";
            this.AccXlabel1.Click += new System.EventHandler(this.AccXlabel1_Click);
            // 
            // AccZ
            // 
            this.AccZ.AutoSize = true;
            this.AccZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccZ.Location = new System.Drawing.Point(67, 289);
            this.AccZ.Name = "AccZ";
            this.AccZ.Size = new System.Drawing.Size(46, 20);
            this.AccZ.TabIndex = 37;
            this.AccZ.Text = "AccZ";
            this.AccZ.Click += new System.EventHandler(this.AccZ_Click);
            // 
            // AccY
            // 
            this.AccY.AutoSize = true;
            this.AccY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccY.Location = new System.Drawing.Point(66, 242);
            this.AccY.Name = "AccY";
            this.AccY.Size = new System.Drawing.Size(47, 20);
            this.AccY.TabIndex = 36;
            this.AccY.Text = "AccY";
            this.AccY.Click += new System.EventHandler(this.AccY_Click);
            // 
            // AccX
            // 
            this.AccX.AutoSize = true;
            this.AccX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccX.Location = new System.Drawing.Point(65, 196);
            this.AccX.Name = "AccX";
            this.AccX.Size = new System.Drawing.Size(47, 20);
            this.AccX.TabIndex = 35;
            this.AccX.Text = "AccX";
            this.AccX.Click += new System.EventHandler(this.AccX_Click);
            // 
            // Altitudelabel1
            // 
            this.Altitudelabel1.AutoSize = true;
            this.Altitudelabel1.BackColor = System.Drawing.SystemColors.Control;
            this.Altitudelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Altitudelabel1.Location = new System.Drawing.Point(203, 148);
            this.Altitudelabel1.Name = "Altitudelabel1";
            this.Altitudelabel1.Size = new System.Drawing.Size(21, 20);
            this.Altitudelabel1.TabIndex = 34;
            this.Altitudelabel1.Text = "...";
            this.Altitudelabel1.Click += new System.EventHandler(this.Altitudelabel1_Click);
            // 
            // Altitude
            // 
            this.Altitude.AutoSize = true;
            this.Altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Altitude.Location = new System.Drawing.Point(65, 148);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(63, 20);
            this.Altitude.TabIndex = 33;
            this.Altitude.Text = "Altitude";
            this.Altitude.Click += new System.EventHandler(this.Altitude_Click);
            // 
            // Presslabel1
            // 
            this.Presslabel1.AutoSize = true;
            this.Presslabel1.BackColor = System.Drawing.SystemColors.Control;
            this.Presslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Presslabel1.Location = new System.Drawing.Point(203, 97);
            this.Presslabel1.Name = "Presslabel1";
            this.Presslabel1.Size = new System.Drawing.Size(21, 20);
            this.Presslabel1.TabIndex = 32;
            this.Presslabel1.Text = "...";
            this.Presslabel1.Click += new System.EventHandler(this.Presslabel1_Click);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Pressure.Location = new System.Drawing.Point(65, 97);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(72, 20);
            this.Pressure.TabIndex = 31;
            this.Pressure.Text = "Pressure";
            this.Pressure.Click += new System.EventHandler(this.Pressure_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(64, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Main Flight Computer";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temperature.Location = new System.Drawing.Point(58, 50);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(100, 20);
            this.Temperature.TabIndex = 29;
            this.Temperature.Text = "Temperature";
            this.Temperature.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(32, 81);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "AccX";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "AccY";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "AccZ";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(485, 312);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // richTextBoxSerialOutput
            // 
            this.richTextBoxSerialOutput.Location = new System.Drawing.Point(5, 27);
            this.richTextBoxSerialOutput.Name = "richTextBoxSerialOutput";
            this.richTextBoxSerialOutput.Size = new System.Drawing.Size(448, 91);
            this.richTextBoxSerialOutput.TabIndex = 32;
            this.richTextBoxSerialOutput.Text = "";
            this.richTextBoxSerialOutput.TextChanged += new System.EventHandler(this.richTextBoxSerialOutput_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.SerialScreenlabel1);
            this.panel6.Controls.Add(this.richTextBoxSerialOutput);
            this.panel6.Location = new System.Drawing.Point(561, 491);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(456, 121);
            this.panel6.TabIndex = 33;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // SerialScreenlabel1
            // 
            this.SerialScreenlabel1.AutoSize = true;
            this.SerialScreenlabel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SerialScreenlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SerialScreenlabel1.ForeColor = System.Drawing.Color.Black;
            this.SerialScreenlabel1.Location = new System.Drawing.Point(172, 4);
            this.SerialScreenlabel1.Name = "SerialScreenlabel1";
            this.SerialScreenlabel1.Size = new System.Drawing.Size(104, 20);
            this.SerialScreenlabel1.TabIndex = 33;
            this.SerialScreenlabel1.Text = "Serial Screen";
            this.SerialScreenlabel1.Click += new System.EventHandler(this.SerialScreenlabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 621);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.Başlık);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefreshPorts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Baud);
            this.Controls.Add(this.Portlar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.panel6);
            this.Name = "Form1";
            this.Text = "Turna Ground Station";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label Portlar;
        private System.Windows.Forms.Label Baud;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonRefreshPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.Label Başlık;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Label Templabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Presslabel1;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label Altitude;
        private System.Windows.Forms.Label Altitudelabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AccX;
        private System.Windows.Forms.Label AccXlabel1;
        private System.Windows.Forms.Label AccZ;
        private System.Windows.Forms.Label AccY;
        private System.Windows.Forms.Label AccZlabel1;
        private System.Windows.Forms.Label AccYlabel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Location1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Locationlabel1;
        private System.Windows.Forms.Label Millslabel1;
        private System.Windows.Forms.Label Mills;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label MaxAltitude;
        private System.Windows.Forms.Label MaxAltitudelabel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox richTextBoxSerialOutput;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label SerialScreenlabel1;
    }
}

