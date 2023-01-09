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
    public partial class frmJournale_De_Vente : Form
    {
        public frmJournale_De_Vente()
        {
            InitializeComponent();
        }

        private void btnquiter_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvlesbon.DataSource = client.c;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            dgvlesaticle.DataSource = Data.g;
        }
    }
}
