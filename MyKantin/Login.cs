using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyKantin
{
    public partial class Login : Form
    {
        public static int id_user;
        

        public Login()
        {
            InitializeComponent();
        }

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
            string mysqlCon = "server=127.0.0.1; user=root; password=; database=mykantin";
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

                string username = textbox_username.Text.ToString();
                string password = textBox_password.Text.ToString();
                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("no empty fields allowed");
                }
                else
                {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT id_user FROM akun WHERE username = '{username}' AND password = '{password}'", mySqlConnection);
                    MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                    if (dataReader.Read())
                    {
                        id_user = dataReader.GetInt32("id_user");
                        dataReader.Close();

                        Home homeForm = new Home();
                        Profile profileForm = new Profile();
                        homeForm.UserId = id_user; // Set nilai UserId pada form Home
                        profileForm.UserId = id_user; // Set nilai UserId pada form Profile
                        homeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        dataReader.Close();
                        MessageBox.Show("Username atau password salah");
                    }
                    mySqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                // Tangani eksepsi
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



