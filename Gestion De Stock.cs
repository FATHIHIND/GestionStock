using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace gestion_stock
{
    public partial class Gestion_De_Stock : Form
    {
        public Gestion_De_Stock()
        {
            Thread d = new Thread(new ThreadStart(start_form));
            d.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            d.Abort(); 
        }
        public void start_form()
        {
            Application.Run(new Menu_Stock());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GESTION_STOCK f  = new GESTION_STOCK();
           
            f.Show();
        }

        private void Gestion_De_Stock_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                textBox2.UseSystemPasswordChar = true;
            else
                textBox2.UseSystemPasswordChar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
