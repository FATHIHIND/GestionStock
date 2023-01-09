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
    public partial class ProduitDemender : Form
    {
        public ProduitDemender()
        {
            InitializeComponent();
        }

        private void txtNumDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbValididité_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpDA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTransformer_Click(object sender, EventArgs e)
        {

        }

        private void lblAccepter_Click(object sender, EventArgs e)
        {

        }

        private void lblValididité_Click(object sender, EventArgs e)
        {

        }

        private void lblDataA_Click(object sender, EventArgs e)
        {

        }

        private void lblNumDA_Click(object sender, EventArgs e)
        {

        }

        private void txtTransformer_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbAccepter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProduitDemender_Load(object sender, EventArgs e)
        {
            //Article.DataSource = Data.g;
            //Article.DisplayMember = "Numerop";
            //Article.ValueMember = "Numerop";
            Data.serialiserclsproduit();
            Data.Dserialiserclsproduit();
            dgvrechercher.DataSource = null;
            dgvrechercher.DataSource = Data.r;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
        }

        private void dtjsaisiedesdemandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtjsaisiedesdemandes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtjsaisiedesdemandes.CurrentRow.Cells["Article"].Value != null)
            {
                for (int i = 0; i <= Data.g.Count - 1; i++)
                {
                    if (Data.g[i].Numerop == int.Parse(dtjsaisiedesdemandes.CurrentRow.Cells["Article"].Value.ToString()))
                    {
                        dtjsaisiedesdemandes.CurrentRow.Cells["Nom"].Value = Data.g[i].Nomp;
                        //dataGridView1.CurrentRow.Cells["QteProduit"].Value = Clientcombo.q[i].QuantitéDemander1;

                        break;
                    }
                }
            }
            if (dtjsaisiedesdemandes.CurrentRow.Cells["Article"].Value != null)
            {
                for (int i = 0; i <= Data.g.Count - 1; i++)
                {
                    if (Data.g[i].Numerop == int.Parse(dtjsaisiedesdemandes.CurrentRow.Cells["Article"].Value.ToString()))
                    {
                        dtjsaisiedesdemandes.CurrentRow.Cells["Poid"].Value = Data.g[i].Poid;
                        //dataGridView1.CurrentRow.Cells["QteProduit"].Value = Clientcombo.q[i].QuantitéDemander1;

                        break;
                    }
                }
            }
            if (dtjsaisiedesdemandes.CurrentRow.Cells["Article"].Value != null)
            {
                for (int i = 0; i <=Data.g.Count - 1; i++)
                {
                    if (Data.g[i].Numerop == int.Parse(dtjsaisiedesdemandes.CurrentRow.Cells["Article"].Value.ToString()))
                    {
                        dtjsaisiedesdemandes.CurrentRow.Cells["Mesure"].Value = Data.g[i].Mesure;
                        //dataGridView1.CurrentRow.Cells["QteProduit"].Value = Clientcombo.q[i].QuantitéDemander1;

                        break;
                    }
                }
            }

        }

        private void btnNouveauda_Click(object sender, EventArgs e)
        {
            clnInterface x = new clnInterface();
            x.ViderForm(this);
        }

        private void btnModifierda_Click(object sender, EventArgs e)
        {

            DemendeAchat r = new DemendeAchat();
            r.Num = txtNumero.Text;
            r.DateDa = DateTime.Parse(mskDatedeprevu.Text);
            r.Datea = DateTime.Parse(mskda.Text);
            r.Validité = chkValiderda.Checked;
            r.Accepté = chkAccepterda.Checked;
            r.Transformer = chbtransformerendp.Checked;
            MessageBox.Show(r.modifier(r, r).ToString(), "modifier avec sucee".ToString());
            dtjsaisiedesdemandes.DataSource = null;
            dtjsaisiedesdemandes.DataSource = Data.r;

        }

        private void btnAjouterda_Click(object sender, EventArgs e)
        {
            DemendeAchat r = new DemendeAchat();
            r.Num = txtNumero.Text;
            r.DateDa = DateTime.Parse(mskDatedeprevu.Text);
            r.Datea = DateTime.Parse(mskda.Text);
            r.Validité = chkValiderda.Checked;
            r.Accepté = chkAccepterda.Checked;
            r.Transformer = chbtransformerendp.Checked;
            MessageBox.Show(r.ajouter().ToString(), "ajouter avec sucee".ToString());
            dtjsaisiedesdemandes.DataSource = null;
            dtjsaisiedesdemandes.DataSource = Data.r;

        }

        private void btnSupprimerda_Click(object sender, EventArgs e)
        {
            DemendeAchat r = new DemendeAchat();
            r.Num =txtNumero.Text;
            r.DateDa = DateTime.Parse(mskDatedeprevu.Text);
            r.Datea = DateTime.Parse(mskda.Text);
            r.Validité = chkValiderda.Checked;
            r.Accepté = chkAccepterda.Checked;
            r.Transformer = chbtransformerendp.Checked;
            MessageBox.Show(r.supprimer(r).ToString(), "Supprimer avec sucee".ToString());
            dtjsaisiedesdemandes.DataSource = null;
            dtjsaisiedesdemandes.DataSource = Data.r;
        }

        private void btnQuitterda_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //Boolean Rechercher = false;
            //for (int i = 0; i < dtjsaisiedesdemandes.Rows.Count; i++)
            //    dtjsaisiedesdemandes.Rows[i].Selected = false;
            //for (int i = 0; i < dtjsaisiedesdemandes.Rows.Count; i++)
            //{
            //    if (txtNumero.Text.Equals(dtjsaisiedesdemandes.Rows[i].Cells[4].Value))
            //    {
            //        dgvrechercher.DataSource = Data.r;
            //        dgvrechercher.Rows[i].Selected = true;

            //        Rechercher = true;
            //    }
            //}
            //for (int i = 0; i < dtjsaisiedesdemandes.Rows.Count; i++)
            //{
            //    if (mskDatedeprevu.Text.Equals(dtjsaisiedesdemandes.Rows[i].Cells[5].Value))
            //    {
            //        dgvrechercher.DataSource = Data.r;
            //        dgvrechercher.Rows[i].Selected = true;

            //        Rechercher = true;
            //    }
            //}
            //for (int i = 0; i < dtjsaisiedesdemandes.Rows.Count; i++)
            //{
            //    if (mskda.Text.Equals(dtjsaisiedesdemandes.Rows[i].Cells[6].Value))
            //    {

            //        dgvrechercher.DataSource = Data.r;
            //        dgvrechercher.Rows[i].Selected = true;

            //        Rechercher = true;
            //    }
            //}
            //for (int i = 0; i < dtjsaisiedesdemandes.Rows.Count; i++)
            //{
            //    if (chkValiderda.Checked.Equals(dtjsaisiedesdemandes.Rows[i].Cells[7].Value))
            //    {
            //        dgvrechercher.DataSource = Data.r;
            //        dgvrechercher.Rows[i].Selected = true;

            //        Rechercher = true;
            //    }
            //}
            //for (int i = 0; i < dtjsaisiedesdemandes.Rows.Count; i++)
            //{
            //    if (chkAccepterda.Checked.Equals(dtjsaisiedesdemandes.Rows[i].Cells[8].Value))
            //    {
            //        dgvrechercher.DataSource = Data.r;
            //        dgvrechercher.Rows[i].Selected = true;

            //        Rechercher = true;
            //    }
            //}
            //if (Rechercher == false) MessageBox.Show("Ereur");

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAfficherDétail_Click(object sender, EventArgs e)
        {
            dgvrechercher.DataSource = Data.g;
            dgvrechercher.DataSource = Data.r;
        }

        private void dtjsaisiedesdemandes_DoubleClick(object sender, EventArgs e)
        {
            DemendeAchat f = new DemendeAchat();
            f.Num= dtjsaisiedesdemandes.CurrentRow.Cells[4].Value.ToString();
            f.DateDa =DateTime.Parse(   dtjsaisiedesdemandes.CurrentRow.Cells[5].Value.ToString());
            f.Datea = DateTime.Parse(dtjsaisiedesdemandes.CurrentRow.Cells[6].Value.ToString());
            f.Validité =bool.Parse( dtjsaisiedesdemandes.CurrentRow.Cells[7].Value.ToString());
            f.Accepté = bool.Parse(dtjsaisiedesdemandes.CurrentRow.Cells[8].Value.ToString());
            f.Transformer = bool.Parse(dtjsaisiedesdemandes.CurrentRow.Cells[9].Value.ToString());
            //-----
            txtNumero.Text = f.Num.ToString();
            mskDatedeprevu.Text = f.DateDa.ToString();
            mskda.Text = f.Datea.ToString();
            chkValiderda.Text = f.Validité.ToString();
            chkAccepterda.Text = f.Accepté.ToString();
            chbtransformerendp.Text = f.Transformer.ToString();
        }

        private void txtNuméro_TextChanged(object sender, EventArgs e)
        {
            dtjsaisiedesdemandes.DataSource = Data.rechercher(txtNuméro.Text);
        }

        private void ProduitDemender_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.serialiserclsproduit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvrechercher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
