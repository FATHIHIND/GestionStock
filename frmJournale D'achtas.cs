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
    public partial class frmJournale_D_achtas : Form
    {
        public frmJournale_D_achtas()
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
            dgvlesbon.DataSource = fourniseur.c;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvlesaticle.DataSource = VenteS.c;
        }

        private void frmJournale_D_achtas_Load(object sender, EventArgs e)
        {

        }
    }
}
