﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();

            gambar_maning.Visible = false;
            gambar_yummy.Visible = false;
            gambar_mbahnjontor.Visible = false;
            gambar_jepang.Visible = false;
            gambar_omjenggot.Visible = false;
            gambar_emak.Visible = false;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string connectionString = "Server=127.0.0.1;Database=pilihkantin;Uid=root";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();

                    string query = "SELECT * FROM kantin WHERE id_kantin LIKE @keyword";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@keyword", "%" + searchText + "%");

                    MySqlDataReader reader = command.ExecuteReader();

                    bool kantinDitemukan = false; // Menandakan apakah kantin ditemukan atau tidak

                    while (reader.Read())
                    {
                        string namaKantin = reader.GetString("id_kantin");

                        if (namaKantin.Equals("maning", StringComparison.OrdinalIgnoreCase))
                        {
                            gambar_maning.Visible = true;
                            kantinDitemukan = true;
                        }
                        else if (namaKantin.Equals("yummy", StringComparison.OrdinalIgnoreCase))
                        {
                            gambar_yummy.Visible = true;
                            kantinDitemukan = true;
                        }
                        else if (namaKantin.Equals("mbahnjontor", StringComparison.OrdinalIgnoreCase))
                        {
                            gambar_mbahnjontor.Visible = true;
                            kantinDitemukan = true;
                        }
                        else if (namaKantin.Equals("jepang", StringComparison.OrdinalIgnoreCase))
                        {
                            gambar_jepang.Visible = true;
                            kantinDitemukan = true;
                        }
                        else if (namaKantin.Equals("omjenggot", StringComparison.OrdinalIgnoreCase))
                        {
                            gambar_omjenggot.Visible = true;
                            kantinDitemukan = true;
                        }
                        else if (namaKantin.Equals("emak", StringComparison.OrdinalIgnoreCase))
                        {
                            gambar_emak.Visible = true;
                            kantinDitemukan = true;
                        }
                    }

                    if (!kantinDitemukan)
                    {
                        MessageBox.Show("Kantin tidak ditemukan.");
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

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
