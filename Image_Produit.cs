using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_stock
{
    public partial class Image_Produit : Form
    {
        public Image_Produit()
        {
            InitializeComponent();
        }

        private void Image_Produit_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (PicE.Visible == true)
            {
                PicE.Visible = false;
                pictureBox1.Visible = true;
            }
            else if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                PicE.Visible = true;
            }
        }
    }
}
