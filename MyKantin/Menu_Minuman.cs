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
using System.IO;

namespace MyKantin
{
    public partial class Menu_Minuman : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter da;
        public Menu_Minuman()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Makanan().Show();
                this.Hide();

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new pilihKantin().Show();
                this.Hide();

            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int idProduk = 0016; // ID Produk untuk makanan yang dipilih dari database

            Detail_Minuman detailMinuman = new Detail_Minuman();
            detailMinuman.IdProduk = idProduk;
            detailMinuman.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox10.Visible = false;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string connectionString = "Server=127.0.0.1;Database=mykantin;Uid=root";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();

                    string query = "SELECT * FROM produk_tbl WHERE nama_produk LIKE @keyword";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@keyword", "%" + searchText + "%");

                    MySqlDataReader reader = command.ExecuteReader();

                    bool MenuDitemukan = false; // Menandakan apakah kantin ditemukan atau tidak

                    while (reader.Read())
                    {
                        string namaProduk = reader.GetString("nama_produk");

                        if (namaProduk.Equals("Air Mineral", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox1.Visible = true;
                            MenuDitemukan = true;
                        }
                        else if (namaProduk.Equals("Es Teh", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox2.Visible = true;
                            MenuDitemukan = true;
                        }
                        else if (namaProduk.Equals("Es Buah Pelangi ", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox3.Visible = true;
                            MenuDitemukan = true;
                        }
                        else if (namaProduk.Equals("Es Cincau Milo", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox4.Visible = true;
                            MenuDitemukan = true;
                        }
                        else if (namaProduk.Equals("Choco Es Milo", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox5.Visible = true;
                            MenuDitemukan = true;
                        }
                        else if (namaProduk.Equals("Brown Sugar Milk", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox10.Visible = true;
                            MenuDitemukan = true;
                        }
                    }

                    if (!MenuDitemukan)
                    {
                        MessageBox.Show("Menu Minuman tidak ditemukan.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox10.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int idProduk = 0015; // ID Produk untuk makanan yang dipilih dari database

            Detail_Minuman detailMinuman = new Detail_Minuman();
            detailMinuman.IdProduk = idProduk;
            detailMinuman.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int idProduk = 0017; // ID Produk untuk makanan yang dipilih dari database

            Detail_Minuman detailMinuman = new Detail_Minuman();
            detailMinuman.IdProduk = idProduk;
            detailMinuman.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int idProduk = 0010; // ID Produk untuk makanan yang dipilih dari database

            Detail_Minuman detailMinuman = new Detail_Minuman();
            detailMinuman.IdProduk = idProduk;
            detailMinuman.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int idProduk = 0011; // ID Produk untuk makanan yang dipilih dari database

            Detail_Minuman detailMinuman = new Detail_Minuman();
            detailMinuman.IdProduk = idProduk;
            detailMinuman.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int idProduk = 0012; // ID Produk untuk makanan yang dipilih dari database

            Detail_Minuman detailMinuman = new Detail_Minuman();
            detailMinuman.IdProduk = idProduk;
            detailMinuman.Show();
            this.Hide();
        }

        private void Menu_Minuman_Load(object sender, EventArgs e)
        {

        }
    }
}
