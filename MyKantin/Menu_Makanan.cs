using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace MyKantin
{
    public partial class Menu_Makanan : Form
    {
        public static string id_makan;
        public string IDMakan { get; set; }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter da;
        public Menu_Makanan()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new pilihKantin().Show();
                this.Hide();

            }
        }

        private MySqlConnection GetConnection()
        {
            string connectionString = "server=127.0.0.1; user=root; password=; database=mykantin"; // Ganti dengan connection string Anda
            return new MySqlConnection(connectionString);
        }

        

        private void Menu_Makanan_Load(object sender, EventArgs e)
        {
            string id_makan = IDMakan;

            MySqlConnection connection = GetConnection();

            try
            {
                string query = "SELECT nama_kantin, id_kantin FROM kantin";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string namaKantin = reader.GetString("nama_kantin");
                    string kantinId = reader.GetString("id_kantin");

                    if (kantinId.Equals(id_makan))
                    {
                        label2.Text = "Menu Kantin " + namaKantin;
                        break; // Exit the loop once the matching kantinId is found
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

                        if (namaProduk.Equals("Bakso", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox1.Visible = true;
                            MenuDitemukan = true;
                        }
                        else if (namaProduk.Equals("Nasi Goreng", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox2.Visible = true;
                            MenuDitemukan = true;
                        }
                        else if (namaProduk.Equals("Soto", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox3.Visible = true;
                            MenuDitemukan = true;
                        }
                        else if (namaProduk.Equals("Gado-Gado", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox4.Visible = true;
                            MenuDitemukan = true;
                        }
                        else if (namaProduk.Equals("Rendang", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox5.Visible = true;
                            MenuDitemukan = true;
                        }
                        else if (namaProduk.Equals("Siomay", StringComparison.OrdinalIgnoreCase))
                        {
                            pictureBox10.Visible = true;
                            MenuDitemukan = true;
                        }
                    }

                    if (!MenuDitemukan)
                    {
                        MessageBox.Show("Menu Makanan tidak ditemukan.");
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

        private void label1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Minuman().Show();
                this.Hide();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int idProduk = 0002; // ID Produk untuk makanan yang dipilih dari database

            Detail_Makanan detailMakanan = new Detail_Makanan();
            detailMakanan.IdProduk = idProduk;
            detailMakanan.Show();
            this.Hide();
        }

        

        private void textBox1_TextChange(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int idProduk = 0014; // ID Produk untuk makanan yang dipilih dari database

            Detail_Makanan detailMakanan = new Detail_Makanan();
            detailMakanan.IdProduk = idProduk;
            detailMakanan.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int idProduk = 0003; // ID Produk untuk makanan yang dipilih dari database

            Detail_Makanan detailMakanan = new Detail_Makanan();
            detailMakanan.IdProduk = idProduk;
            detailMakanan.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int idProduk = 0004; // ID Produk untuk makanan yang dipilih dari database

            Detail_Makanan detailMakanan = new Detail_Makanan();
            detailMakanan.IdProduk = idProduk;
            detailMakanan.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int idProduk = 0005; // ID Produk untuk makanan yang dipilih dari database

            Detail_Makanan detailMakanan = new Detail_Makanan();
            detailMakanan.IdProduk = idProduk;
            detailMakanan.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int idProduk = 0006; // ID Produk untuk makanan yang dipilih dari database

            Detail_Makanan detailMakanan = new Detail_Makanan();
            detailMakanan.IdProduk = idProduk;
            detailMakanan.Show();
            this.Hide();
        }

        

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPilihPembayaran_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
 }
