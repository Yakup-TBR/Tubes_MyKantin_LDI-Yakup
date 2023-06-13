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
    public partial class Status_Bayar : Form
    {
        public Status_Bayar()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Pembayaran().Show();
                this.Hide();

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Home().Show();
                this.Hide();

            }
        }
    }
}
