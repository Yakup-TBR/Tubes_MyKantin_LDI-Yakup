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
    public partial class Pembayaran : Form
    {
        
        private string diskon;
        private string totalHargaSetelahDiskon;
        public Pembayaran()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Keranjang().Show();
                this.Hide();

            }
        }

        // Metode untuk mengatur nilai diskon dan total harga setelah diskon dari form keranjang
        public void SetDiskon(string diskonValue, string totalHargaSetelahDiskonValue)
        {
            diskon = diskonValue;
            totalHargaSetelahDiskon = totalHargaSetelahDiskonValue;

            label4.Text = diskon;
            label5.Text = totalHargaSetelahDiskon;
        }


        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Status_Bayar().Show();
                this.Hide();

            }
        }

        private void labelPilihPembayaran_Click(object sender, EventArgs e)
        {

        }

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
           
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
