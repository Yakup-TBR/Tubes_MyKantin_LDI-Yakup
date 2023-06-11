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
            try { 
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
                    MySqlCommand mySqlCommand = new MySqlCommand("select * from login", mySqlConnection);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if (username.Equals(reader.GetString("username")) && password.Equals(reader.GetString("password")))
                        {
                            new Home().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login");
                        }
                    }
                    mySqlConnection.Close();
                }
            }catch (Exception ex) 
            {
            
            }

            // if (true)
            //{
            //  if(textbox_username.Text == "Supri" && textBox_password.Text == "supri123")
            //{
            //  new Home().Show();
            //this.Hide();
            //}
            //else
            //{
            //MessageBox.Show("Username atau password salah, silahkan coba lagi");
            //textbox_username.Clear();
            //textBox_password.Clear(); 
            //textbox_username.Focus();
            //}
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



