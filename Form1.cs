using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting; // Charting namespace'ini ekleyin

namespace Ground_Station_2
{
    public partial class Form1 : Form
    {
        string[] paketSrad;
        string[] paketPayload;
        int x = 0, y = 0, z = 0;
        bool cx = false, cy = false, cz = false;
        int height;
        int maxAlt = 0;
        int int_ignt1;
        int int_ignt2;

        public Form1()
        {
            InitializeComponent();
            LoadAvailablePorts();
            LoadAvailableBaudRates();
            InitializeChart(); // Grafiği başlat

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }


        private void InitializeChart()
        {
            chart1.Series.Clear();

            Series seriesAccX = new Series("AccX")
            {
                ChartType = SeriesChartType.Spline
            };
            chart1.Series.Add(seriesAccX);

            Series seriesAccY = new Series("AccY")
            {
                ChartType = SeriesChartType.Spline
            };
            chart1.Series.Add(seriesAccY);

            Series seriesAccZ = new Series("AccZ")
            {
                ChartType = SeriesChartType.Spline
            };
            chart1.Series.Add(seriesAccZ);

            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Acceleration (m/s^2)";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                string sonuc = serialPort1.ReadExisting();

                // Verileri ayrıştır ve yazdır
                ParseSensorData(sonuc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri okunamadı: " + ex.Message);
                timer1.Stop();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)  // Sonc
        {

        }

        private void label1_Click(object sender, EventArgs e) //portlar yazısı
        {

        }

        private void Baud_Click(object sender, EventArgs e) // Baud yazısı
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableConnectButton();
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
        private void Başlık_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void Pressure_Click(object sender, EventArgs e)
        {

        }
        private void Presslabel1_Click(object sender, EventArgs e)
        {

        }
        private void Altitudelabel1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableConnectButton();
        }

        private void EnableConnectButton()
        {
            // comboBox1 ve comboBox2'daki değerler geçerli ise butonu aktif et
            button1.Enabled = !string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bağlan butonu
            if (!serialPort1.IsOpen)
            {
                if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                {
                    MessageBox.Show("Lütfen bir port ve baud rate seçin.");
                    return;
                }

                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);

                try
                {
                    serialPort1.Open();
                    label1.Text = "Bağlantı açıldı...";
                    timer1.Start();
                    button1.Enabled = false; // Bağlan butonunu devre dışı bırak
                    button2.Enabled = true;  // Bağlantıyı kes butonunu aktif et
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Hata: Port kullanımda. Başka bir uygulama tarafından kullanılıyor olabilir.");
                }
                catch (IOException)
                {
                    MessageBox.Show("Hata: Bağlantı kurulamadı. Port ayarlarını kontrol edin.");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata: " + hata.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Bağlantıyı kes butonu
            if (serialPort1.IsOpen)
            {
                try
                {
                    timer1.Stop();
                    serialPort1.Close();
                    label1.Text = "Bağlantı kapatıldı...";
                    button1.Enabled = true;  // Bağlan butonunu aktif et
                    button2.Enabled = false; // Bağlantıyı kes butonunu devre dışı bırak
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata: " + hata.Message);
                }
            }
        }

        private void LoadAvailablePorts()
        {
            try
            {
                string[] portlar = SerialPort.GetPortNames();
                comboBox1.Items.Clear(); // Önceki öğeleri temizleyelim
                foreach (string portAdi in portlar)
                {
                    comboBox1.Items.Add(portAdi); // portları ekledik
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Portlar yüklenemedi: " + ex.Message);
            }
        }

        private void LoadAvailableBaudRates()
        {
            try
            {
                comboBox2.Items.Clear(); // Önceki öğeleri temizleyelim
                int[] baudRates = { 9600, 14400, 19200, 38400, 57600, 115200 };
                foreach (int baudRate in baudRates)
                {
                    comboBox2.Items.Add(baudRate.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baud rate'ler yüklenemedi: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void Altitude_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, EventArgs e)
        {

        }

        private void AccX_Click(object sender, EventArgs e)
        {

        }

        private void AccY_Click(object sender, EventArgs e)
        {

        }

        private void AccZ_Click(object sender, EventArgs e)
        {

        }

        private void AccXlabel1_Click(object sender, EventArgs e)
        {

        }

        private void AccYlabel1_Click(object sender, EventArgs e)
        {

        }

        private void AccZlabel1_Click(object sender, EventArgs e)
        {

        }

        private void Location1_Click(object sender, EventArgs e)
        {

        }

        private void Locationlabel1_Click(object sender, EventArgs e)
        {

        }

        private void Mills_Click(object sender, EventArgs e)
        {

        }

        private void Millslabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadAvailablePorts();
            LoadAvailableBaudRates();
        }

        private void richTextBoxSerialOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SerialScreenlabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAvailablePorts();
            LoadAvailableBaudRates();
            button1.Enabled = false; // Bağlan butonunu başlangıçta devre dışı bırak
            button2.Enabled = false; // Bağlantıyı kes butonunu başlangıçta devre dışı bırak
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void ParseSensorData(string data)
        {
            string[] lines = data.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                if (line.StartsWith("T:"))
                {
                    string temperatureValue = line.Substring(2).Trim();
                    Templabel1.Text = temperatureValue + " °C";
                }
                else if (line.StartsWith("P:"))
                {
                    string pressureValue = line.Substring(2).Trim();
                    Presslabel1.Text = pressureValue + " hPa";
                }
                else if (line.StartsWith("H:"))
                {
                    string heightValue = line.Substring(2).Trim();
                    Altitudelabel1.Text = heightValue + " m";

                    // Maksimum yüksekliği güncelle
                    if (int.TryParse(heightValue, out int heightValueInt))
                    {
                        if (heightValueInt > maxAlt)
                        {
                            maxAlt = heightValueInt;
                            MaxAltitudelabel1.Text = maxAlt + " m"; // Maksimum yüksekliği göstermek için bir label ekleyin
                        }
                    }
                }
                else if (line.StartsWith("AccX:"))
                {
                    string accXValue = line.Substring(6).Trim();
                    AccXlabel1.Text = accXValue + " m/s^2";
                    AddDataPointToChart("AccX", accXValue);
                }
                else if (line.StartsWith("AccY:"))
                {
                    string accYValue = line.Substring(6).Trim();
                    AccYlabel1.Text = accYValue + " m/s^2";
                    AddDataPointToChart("AccY", accYValue);
                }
                else if (line.StartsWith("AccZ:"))
                {
                    string accZValue = line.Substring(6).Trim();
                    AccZlabel1.Text = accZValue + " m/s^2";
                    AddDataPointToChart("AccZ", accZValue);
                }
                else if (line.StartsWith("Location:"))
                {
                    string locationValue = line.Substring(2).Trim();
                    Locationlabel1.Text = locationValue;
                }
                else if (line.StartsWith("Millis:"))
                {
                    string millisValue = line.Substring(7).Trim();
                    Millslabel1.Text = millisValue;
                }

                AppendTextToSerialOutput(data); // seri ekrana yazdırma
            }
        }

        private void AppendTextToSerialOutput(string text)
        {
            if (richTextBoxSerialOutput.InvokeRequired)
            {
                richTextBoxSerialOutput.Invoke(new Action<string>(AppendTextToSerialOutput), new object[] { text });
            }
            else
            {
                richTextBoxSerialOutput.AppendText(text + Environment.NewLine);
                richTextBoxSerialOutput.ScrollToCaret();
            }
        }

        private void AddDataPointToChart(string seriesName, string value)
        {
            if (double.TryParse(value, out double doubleValue))
            {
                chart1.Series[seriesName].Points.AddY(doubleValue);

                if (chart1.Series[seriesName].Points.Count > 100)
                {
                    chart1.Series[seriesName].Points.RemoveAt(0); // 100'den fazla nokta varsa, en eski olanı kaldır
                }

                chart1.ResetAutoValues();
            }
        }
    }
}
