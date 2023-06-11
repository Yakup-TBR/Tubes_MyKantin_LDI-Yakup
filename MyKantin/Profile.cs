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
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Favorit().Show();
                this.Hide();
            }
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Favorit().Show();
                this.Hide();
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Terakhir_Pesan().Show();
                this.Hide();
            }
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Terakhir_Pesan().Show();
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
    }
}
