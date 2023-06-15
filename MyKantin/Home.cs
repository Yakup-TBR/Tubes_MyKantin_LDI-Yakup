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
    public partial class Home : Form
    {
        public static int id_user;
        public int UserId { get; set; }

        public static Home Instance;

        public Home()
        {
            InitializeComponent();

        }

        private void label_ayo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private MySqlConnection GetConnection()
        {
            string connectionString = "server=127.0.0.1; user=root; password=; database=mykantin"; // Ganti dengan connection string Anda
            return new MySqlConnection(connectionString);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            int id_user = UserId; // Ambil nilai UserId dari properti

            MySqlConnection connection = GetConnection();

            try
            {
                string query = $"SELECT nama_user, gambar_user FROM akun WHERE id_user = {id_user}";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string namaUser = reader.GetString("nama_user");
                    byte[] gambarBytes = (byte[])reader["gambar_user"];

                    label_selamat.Text = "Halo, " + namaUser;
                    pictureBox7.Image = ByteArrayToImage(gambarBytes);

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                // Tangani eksepsi
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var stream = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(stream);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Detail_Makanan().Show();
                this.Hide();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Makanan().Show();
                this.Hide();
            }
        }

        private void label_dapatkandiskon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labeldapatdiskon_Click(object sender, EventArgs e)
        {

        }

        private void labelDiskon_Click(object sender, EventArgs e)
        {

        }

        private void label_all1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                    new pilihKantin().Show();
                    this.Hide();
                
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Keranjang().Show();
                this.Hide();

            }
        }

        private void label_all2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Terakhir_PesanMakanan().Show();
                this.Hide();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Detail_Makanan().Show();
                this.Hide();

            }
        }

        private void label_merchantMakanan_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label_makananMerchant2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Detail_Makanan().Show();
                this.Hide();

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Profile().Show();
                this.Hide();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if(true)
            {
                new Menu_Makanan().Show();
                this.Hide();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Makanan().Show();
                this.Hide();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Makanan().Show();
                this.Hide();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new pilihKantin().Show();
                this.Hide();

            }
        }

        private void label_selamat_Click(object sender, EventArgs e)
        {

        }
    }
}
