using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ground_Station_2
{
    public partial class LoginForm : Form
    {
        // Basit kullanıcı adı ve şifre kontrolü için sabit değerler
        private const string Username = "admin";
        private const string Password = "1234";


        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == Username && textBoxPassword.Text == Password)
            {
                // Giriş başarılı, ana forma geç
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide(); // Giriş formunu gizle
            }
            else
            {
                // Giriş başarısız, hata mesajı göster
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
