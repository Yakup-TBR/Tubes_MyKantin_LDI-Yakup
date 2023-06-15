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
    public partial class Favorit_Minuman : Form
    {
        public Favorit_Minuman()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                new Favorit_Makanan().Show();
                this.Hide();
            }
        }

        public void SetDetailMinumanImage(Image image)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.Size = new Size(150, 138); // Atur ukuran sesuai kebutuhan
            label.BackgroundImage = image;
            label.BackgroundImageLayout = ImageLayout.Zoom; // Atur tata letak gambar sesuai preferensi Anda
            flowLayoutPanel1.Controls.Add(label);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
