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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void btnquiter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnjournal1_Click(object sender, EventArgs e)
        {
            frmJournale_D_achtas n = new frmJournale_D_achtas();
            n.Show();
        }

        private void btnjournal_Click(object sender, EventArgs e)
        {
            frmJournale_De_Vente c = new frmJournale_De_Vente();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aricle_Vente X = new Aricle_Vente();
            X.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
