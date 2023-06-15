using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace MyKantin
{
    public partial class Detail_Makanan : Form
    {
        private int idProduk;
        private decimal hargaMakanan = 10;

        public Detail_Makanan()
        {
            InitializeComponent();
        }
        public int IdProduk
        {
            get { return idProduk; }
            set { idProduk = value; }
        }

        public Image FavoritImage { get; private set; }

        public static class TotalHargaManager
        {
            public static decimal TotalHarga { get; set; }
        }

        private MySqlConnection GetConnection()
        {
            string connectionString = "server=127.0.0.1; user=root; password=; database=mykantin"; // Ganti dengan connection string Anda
            return new MySqlConnection(connectionString);
        }


        private void Detail_Makanan_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = GetConnection();

            try
            {
                string query = $"SELECT nama_produk,harga_produk, gambar_produk, deskripsi_produk FROM produk_tbl WHERE id_produk = {IdProduk}";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {   
                    string namaProduk = reader.GetString("nama_produk");
                    decimal hargaMakananDB = reader.GetDecimal("harga_produk");
                    byte[] gambarBytes = (byte[])reader["gambar_produk"];
                    string deskripsi = reader.GetString("deskripsi_produk");

                    hargaMakanan = hargaMakananDB;
                    label1.Text = hargaMakanan.ToString("C");
                    //label4.Text = hargaMakanan.ToString("C");
                    label2.Text = "About " + namaProduk;
                    pictureBox1.Image = ByteArrayToImage(gambarBytes);
                    label3.Text = deskripsi;
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var stream = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(stream);
            }
        }

        int jumlah = 0;
        //int hargaMakanan = 10;
        private void label6_Click(object sender, EventArgs e)
        {
            jumlah++;
            UpdateTotalHarga();
            label5.Text = jumlah.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (jumlah >= 1)
            {
            jumlah--;
            UpdateTotalHarga();
            label5.Text = jumlah.ToString();
            }
        }

        private decimal HitungTotalHarga(int jumlah, decimal hargaMakanan)
        {
            return jumlah * hargaMakanan;
        }

        private void UpdateTotalHarga()
        {
            decimal totalHarga = HitungTotalHarga(jumlah, hargaMakanan);
            TotalHargaManager.TotalHarga = totalHarga; // Supaya harga tetap

            String hargaMakananFormatted = "Rp. " + totalHarga.ToString();
            label4.Text = hargaMakananFormatted;
            label4.Text = totalHarga.ToString("C");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
         
        }

        private void labelPilihPembayaran_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Makanan().Show();
                this.Hide();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Keranjang().Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Keranjang().Show();
                this.Hide();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //like button merah
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {// like button putih
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
            MySqlConnection connection = GetConnection();
            try
            {
                string query = $"SELECT gambar_produk FROM produk_tbl WHERE id_produk = {IdProduk}";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    byte[] gambarBytes = (byte[])reader["gambar_produk"];
                    FavoritImage = ByteArrayToImage(gambarBytes);

                    Favorit_Makanan favoritForm = new Favorit_Makanan();
                    favoritForm.SetDetailMakananImage(pictureBox1.Image);
                    favoritForm.Show(); 
                    this.Hide(); 
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (true)
            {
                new Keranjang().Show();
                this.Hide();

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(true)
            {
                new Keranjang().Show();
                this.Hide();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Keranjang().Show();
                this.Hide();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
