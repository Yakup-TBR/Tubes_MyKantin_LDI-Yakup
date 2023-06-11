using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKantin
{
    public partial class Detail_Makanan : Form
    {
        public Detail_Makanan()
        {
            InitializeComponent();
        }

        private void Detail_Makanan_Load(object sender, EventArgs e)
        {
        
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

        int jumlah = 1;
        int hargaMakanan = 10;
        private void label6_Click(object sender, EventArgs e)
        {
            jumlah++;
            UpdateTotalHarga();
            label5.Text = jumlah.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (jumlah > 1) 
            {
                jumlah--;
                UpdateTotalHarga();
                label5.Text = jumlah.ToString(); 
            }
        }

        private int HitungTotalHarga(int jumlah, int harga)
        {
            return jumlah * harga;
        }

        private void UpdateTotalHarga()
        {
            int totalHarga = HitungTotalHarga(jumlah, hargaMakanan);
            String hargaMakananFormatted = "Rp. " + totalHarga.ToString("#.##0");
            label4.Text = hargaMakananFormatted;
            //label4.Text = totalHarga.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
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
        {
            //like button putih
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
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
            if (true)
            {
                new Pembayaran().Show();
                this.Hide();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Pembayaran().Show();
                this.Hide();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
