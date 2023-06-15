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
    public partial class Keranjang : Form
    {
        public Keranjang()
        {
            InitializeComponent();
        }



        private void Tombol_Kurang1(object sender, EventArgs e)
        {
            int currentQuantity = int.Parse(label1.Text);
            if (currentQuantity > 0)
            {
                currentQuantity--;
                label1.Text = currentQuantity.ToString();
                Totalharga(sender, e); // Memanggil Totalharga untuk memperbarui total quantity
            }
        }

        private void Tombol_Tambah1(object sender, EventArgs e)
        {
            int currentQuantity = int.Parse(label1.Text);
            currentQuantity++;
            label1.Text = currentQuantity.ToString();
            Totalharga(sender, e); // Memanggil  Totalharga untuk memperbarui total quantity
        }


        private void Tombol_Kurang2(object sender, EventArgs e)
        {
            /*
            int currentQuantity = int.Parse(label13.Text);
            if (currentQuantity > 0)
            {
                currentQuantity--;
                label13.Text = currentQuantity.ToString();
                Totalharga(sender, e); // Memanggil  Totalharga untuk memperbarui total quantity
            }
            */
        }

        private void Tombol_Tambah2(object sender, EventArgs e)
        {
            /*
            int currentQuantity = int.Parse(label13.Text);
            currentQuantity++;
            label13.Text = currentQuantity.ToString();
            Totalharga(sender, e); // Memanggil  Totalharga untuk memperbarui total quantity
            */
        }

        private void Tombol_Kurang3(object sender, EventArgs e)
        {
            /*
            int currentQuantity = int.Parse(label15.Text);
            if (currentQuantity > 0)
            {
                currentQuantity--;
                label15.Text = currentQuantity.ToString();
                Totalharga(sender, e); // Memanggil  Totalharga untuk memperbarui total quantity
            }
            */
        }

        private void Tombol_Tambah3(object sender, EventArgs e)
        {
            /*
            int currentQuantity = int.Parse(label15.Text);
            currentQuantity++;
            label15.Text = currentQuantity.ToString();
            Totalharga(sender, e); // Memanggil  Totalharga untuk memperbarui total quantity
            */
        }

        private void Totalharga(object sender, EventArgs e)
        {
            try
            {
                // Mengambil nilai quantity dari setiap label
                int quantity1 = int.Parse(label1.Text);
                //int quantity2 = int.Parse(label13.Text); ////////////
                //int quantity3 = int.Parse(label15.Text); ////////////

                // Menghitung jumlah total
                totalHarga = (quantity1 * 10000); // + (quantity2 * 10000) + (quantity3 * 5000);

                // Menampilkan hasil jumlah pada label dengan tanda titik sebagai penanda ribuan
                label19.Text = totalHarga.ToString("N0");
            }
            catch (FormatException)
            {
                // Mengupdate label19 dengan pesan kesalahan format angka
                label19.Text = "Kesalahan format angka";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Menghapus teks pada label21 saat teks pada textBox1 berubah
            label21.Text = "";
        }

        private int totalHarga = 0;

        private void label17_Click(object sender, EventArgs e)
        {
            string promoCode = textBox1.Text;

            try
            {
                // Menghitung jumlah diskon
                int diskon = 0;

                // Memeriksa apakah kode promo valid
                if (promoCode == "DISCOUNT10%")
                {
                    diskon = totalHarga * 10 / 100;
                }
                else
                {
                    throw new Exception("Kode promo salah");
                }

                // Mengupdate label21 dengan hasil diskon
                label21.Text = "Rp       -" + diskon.ToString("N0");
                label21.ForeColor = Color.Black; // Mengubah warna teks menjadi hitam

                // Menghitung total harga setelah diskon
                int totalHargaSetelahDiskon = totalHarga - diskon;
                label19.Text = totalHargaSetelahDiskon.ToString("N0");
            }
            catch (Exception ex)
            {
                // Mengupdate label21 dengan pesan kesalahan kode promo
                label21.Text = ex.Message;
                label21.ForeColor = Color.Red; // Mengubah warna teks menjadi merah
            }
        }



        private void pictureBox17_Click(object sender, EventArgs e)
        {
            // Menghapus teks pada label21 saat label21 diklik
            label21.Text = "";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (true)
            {
                // Membuat objek Pembayaran
                Pembayaran pembayaranForm = new Pembayaran();

                // Mengirim nilai diskon dan total harga setelah diskon ke form Pembayaran
                pembayaranForm.SetDiskon(label21.Text, label19.Text);

                // Menampilkan form Pembayaran
                pembayaranForm.Show();
                this.Hide();
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

        private void pictureBox16_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

       

        private void Keranjang_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
