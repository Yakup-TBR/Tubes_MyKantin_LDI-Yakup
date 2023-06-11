using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKantin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private String coba = "tes";


        private void Form1_Load(object sender, EventArgs e) 
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (true)
            {
                if(textbox_username.Text == "Supri" && textBox_password.Text == "supri123")
                {
                    new Home().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah, silahkan coba lagi");
                    textbox_username.Clear();
                    textBox_password.Clear(); 
                    textbox_username.Focus();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



