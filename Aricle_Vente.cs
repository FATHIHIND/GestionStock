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
    public partial class Aricle_Vente : Form
    {
        public Aricle_Vente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VenteS s = new VenteS();
            s.Nump = int.Parse(txtnump.Text);
            s.Nom =txtnom.Text;
            s.Quantité = int.Parse(txtpoid.Text);
            s.Mesure = cmbMesure.Text;
           

            if (s.ajouter(s) == true)
            {
                MessageBox.Show("Vente Ajouter Avec Succes");
               dgvpv.DataSource = null;
                dgvpv.DataSource = VenteS.c;
            }
            else
            {
                MessageBox.Show("Vente n'A Pas Ajouter ");
            }
        }

        private void txtnump_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpoid_TextChanged(object sender, EventArgs e)
        {
            if(cmbMesure.Text=="")
            {
                txtpoid.Text = "0";
            }
        }
    }
}
