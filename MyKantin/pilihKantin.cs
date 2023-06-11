using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyKantin
{
    public partial class pilihKantin : Form
    {
        public pilihKantin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Makanan().Show();
                this.Hide();

            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Makanan().Show();
                this.Hide();

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
                new Menu_Makanan().Show();
                this.Hide();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Menu_Makanan().Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                new Home().Show();
                this.Hide();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }



        private enum State
        {
            Initial,
            Maning,
            Yummy,
            Mbahnjontor,
            Jepang,
            Jenggot,
            Emak
        }


        private State currentState;

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower(); // Mengambil teks dari TextBox dan mengubahnya menjadi huruf kecil

            gambar_maning.Visible = false;
            gambar_yummy.Visible = false;
            gambar_mbahnjontor.Visible = false;
            gambar_jepang.Visible = false;
            gambar_omjenggot.Visible = false;
            gambar_emak.Visible = false;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                currentState = State.Initial;

                foreach (char c in searchText)
                {
                    switch (currentState)
                    {
                        case State.Initial:
                            if (c == 'm')
                                currentState = State.Maning;
                            else if (c == 'y')
                                currentState = State.Yummy;
                            else if (c == 'b')
                                currentState = State.Mbahnjontor;
                            else if (c == 'j')
                                currentState = State.Jepang;
                            else if (c == 'e')
                                currentState = State.Emak;
                            else
                                currentState = State.Initial;
                            break;
                        case State.Maning:
                            if (c == 'a')
                                currentState = State.Maning;
                            else if (c == 'n')
                                currentState = State.Maning;
                            else if (c == 'i')
                                currentState = State.Maning;
                            else if (c == 'g')
                                currentState = State.Maning;
                            else
                                currentState = State.Initial;
                            break;
                        case State.Yummy:
                            if (c == 'u')
                                currentState = State.Yummy;
                            else if (c == 'm')
                                currentState = State.Yummy;
                            else if (c == 'm')
                                currentState = State.Yummy;
                            else if (c == 'y')
                                currentState = State.Yummy;
                            else
                                currentState = State.Initial;
                            break;
                        case State.Mbahnjontor:
                            if (c == 'm')
                                currentState = State.Mbahnjontor;
                            else if (c == 'b')
                                currentState = State.Mbahnjontor;
                            else if (c == 'a')
                                currentState = State.Mbahnjontor;
                            else if (c == 'h')
                                currentState = State.Mbahnjontor;
                            else if (c == 'n')
                                currentState = State.Mbahnjontor;
                            else if (c == 'j')
                                currentState = State.Mbahnjontor;
                            else if (c == 'o')
                                currentState = State.Mbahnjontor;
                            else if (c == 'n')
                                currentState = State.Mbahnjontor;
                            else if (c == 't')
                                currentState = State.Mbahnjontor;
                            else if (c == 'o')
                                currentState = State.Mbahnjontor;
                            else if (c == 'r')
                                currentState = State.Mbahnjontor;
                            else
                                currentState = State.Initial;
                            break;
                        case State.Jepang:
                            if (c == 'e')
                                currentState = State.Jepang;
                            else if (c == 'p')
                                currentState = State.Jepang;
                            else if (c == 'a')
                                currentState = State.Jepang;
                            else if (c == 'n')
                                currentState = State.Jepang;
                            else if (c == 'g')
                                currentState = State.Jepang;
                            else
                                currentState = State.Initial;
                            break;
                        case State.Jenggot:
                            if (c == 'j')
                                currentState = State.Jenggot;
                            else if (c == 'e')
                                currentState = State.Jenggot;
                            else if (c == 'n')
                                currentState = State.Jenggot;
                            else if (c == 'g')
                                currentState = State.Jenggot;
                            else if (c == 'g')
                                currentState = State.Jenggot;
                            else if (c == 'o')
                                currentState = State.Jenggot;
                            else if (c == 't')
                                currentState = State.Jenggot;
                            else
                                currentState = State.Initial;
                            break;
                        case State.Emak:
                            if (c == 'e')
                                currentState = State.Emak;
                            else if (c == 'm')
                                currentState = State.Emak;
                            else if (c == 'a')
                                currentState = State.Emak;
                            else if (c == 'k')
                                currentState = State.Emak;
                            else
                                currentState = State.Initial;
                            break;
                    }
                }

                switch (currentState)
                {
                    case State.Maning:
                        gambar_maning.Visible = true;
                        break;
                    case State.Yummy:
                        gambar_yummy.Visible = true;
                        break;
                    case State.Mbahnjontor:
                        gambar_mbahnjontor.Visible = true;
                        break;
                    case State.Jepang:
                        gambar_jepang.Visible = true;
                        break;
                    case State.Jenggot:
                        gambar_omjenggot.Visible = true;
                        break;
                    case State.Emak:
                        gambar_emak.Visible = true;
                        break;
                    default:
                        // Teks tidak cocok dengan keadaan yang didefinisikan
                        break;
                }
            }
            else
            {
                // Teks kosong, menampilkan semua gambar
                gambar_maning.Visible = true;
                gambar_yummy.Visible = true;
                gambar_mbahnjontor.Visible = true;
                gambar_jepang.Visible = true;
                gambar_omjenggot.Visible = true;
                gambar_emak.Visible = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (true)
            {
                new Home().Show();
                this.Hide();
            }
        }
    }
}
