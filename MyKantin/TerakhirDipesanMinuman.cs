﻿using System;
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
    public partial class TerakhirDipesanMinuman : Form
    {
        public TerakhirDipesanMinuman()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Profile().Show();
                this.Hide();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new TerakhirDipesanMinuman().Show();
                this.Hide();
            }
        }
    }
}
