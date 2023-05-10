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
    public partial class Home : Form
    {
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

        private void Home_Load(object sender, EventArgs e)
        {
            labeldapatdiskon.Parent = pictureBox1;
            labeldapatdiskon.BackColor = Color.Transparent;

            labelDiskon.Parent = pictureBox1;
            labelDiskon.BackColor = Color.Transparent;

            /*
            label_merchantMakanan.Parent = pictureBox2;
            label_merchantMakanan.BackColor = Color.Transparent;



            label_makananMerchant2.Parent = pictureBox3;
            label_makananMerchant2.BackColor = Color.Transparent;
            label_makananMerchant2.Location = new Point(330, 591); //atur posisi relatif terhadap pictureBox3
            */




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
                new Terakhir_Pesan().Show();
                this.Hide();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label_merchantMakanan_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label_makananMerchant2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

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
    }
}
