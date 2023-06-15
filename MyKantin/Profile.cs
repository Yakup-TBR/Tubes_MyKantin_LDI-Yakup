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

namespace MyKantin
{
    public partial class Profile : Form
    {
        public static int id_user;
        public int UserId { get; set; }
        public static Profile Instance;

        public Profile()
        {
            InitializeComponent();
        }

        private MySqlConnection GetConnection()
        {
            string connectionString = "server=127.0.0.1; user=root; password=; database=mykantin"; // Ganti dengan connection string Anda
            return new MySqlConnection(connectionString);
        }

        private void Profile_Load(object sender, EventArgs e)
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

                    labelNama.Text = "Halo, " + namaUser;
                    guna2CirclePictureBox2.Image = ByteArrayToImage(gambarBytes);

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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Favorit_Makanan().Show();
                this.Hide();
            }
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Favorit_Makanan().Show();
                this.Hide();
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Terakhir_PesanMakanan().Show();
                this.Hide();
            }
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Terakhir_PesanMakanan().Show();
                this.Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Home().Show();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Keranjang().Show();
                this.Hide();
            }
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void labelPilihPembayaran_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
