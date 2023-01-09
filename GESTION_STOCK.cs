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
    public partial class GESTION_STOCK : Form
    {
        public GESTION_STOCK()
        {
            InitializeComponent();
        }

        private void fOURNISEURToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


            
        }

        private void pRODUITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void btnquiter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
           
        }

        private void btnmenu2_Click(object sender, EventArgs e)
        {
           

        }

        private void pnlmenu1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnmenuG_Click(object sender, EventArgs e)
        {
           
        }

        private void btnmenu1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void PicE_Click(object sender, EventArgs e)
        {

        }

        private void btnsaisieetudiant_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
           



        }

        private void GESTION_STOCK_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        //    if (btnmenuG.Text == "<")
        //    {

        //        btnmenuG.Left = pnlmenu1.Left;
        //        pnlmenu1.Width = btnmenuG.Width;
        //        //pnlmenu2.Width = btnmenuG.Width;
        //        btnmenuG.Text = ">";
        //    }
        //    else
        //    {
        //        pnlmenu1.Width = 483;
        //        btnmenuG.Text = "<";
        //    }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmStock q = new frmStock();
            q.Show();
        }

        private void pnlmenu2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label5_Click_2(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
          

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
           
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmStock q = new frmStock();
            q.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //if (btnmenuG.Text == "<")
            //{

            //    btnmenuG.Left = pnlmenu1.Left;
            //    pnlmenu1.Width = btnmenuG.Width;
            //   // pnlmenu2.Width = btnmenuG.Width;
            //    btnmenuG.Text = ">";
            //}
            //else
            //{
            //    pnlmenu1.Width = 483;
            //    btnmenuG.Text = "<";
            //}
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void linkLabel7_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //try
            //{

            //    throw new Exception("Erure ne peux pas pu trouver", null);
            //}
            //catch (Exception ex)
            //{
            //    //var ss = new Gestionerreur();
            //    GestionEreur.logger(ex, this);

            //    ex.GetType().ToString();
            //}
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel7_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
          
        }
       
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        } 
        Trier_rechercher us1 = new Trier_rechercher();
        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl2_produit.Instance))
            {
                panel1.Controls.Add(UserControl2_produit.Instance);
                UserControl2_produit.Instance.Dock = DockStyle.Fill;
                UserControl2_produit.Instance.BringToFront();
            }
            else
                UserControl2_produit.Instance.BringToFront();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl2_client_fourniseur.Instance))
            {
                panel1.Controls.Add(UserControl2_client_fourniseur.Instance);
                UserControl2_client_fourniseur.Instance.Dock = DockStyle.Fill;
                UserControl2_client_fourniseur.Instance.BringToFront();
            }
            else
                UserControl2_client_fourniseur.Instance.BringToFront();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl2_achat.Instance))
            {
                panel1.Controls.Add(UserControl2_achat.Instance);
                UserControl2_achat.Instance.Dock = DockStyle.Fill;
                UserControl2_achat.Instance.BringToFront();
            }
            else
                UserControl2_achat.Instance.BringToFront();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl2_vente.Instance))
            {
                panel1.Controls.Add(UserControl2_vente.Instance);
                UserControl2_vente.Instance.Dock = DockStyle.Fill;
                UserControl2_vente.Instance.BringToFront();
            }
            else
                UserControl2_vente.Instance.BringToFront();
        }

        private void label5_Click_3(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Trier_rechercher.Instance))
            {
                panel1.Controls.Add(Trier_rechercher.Instance);
                Trier_rechercher.Instance.Dock = DockStyle.Fill;
                Trier_rechercher.Instance.BringToFront();
            }
            else
                Trier_rechercher.Instance.BringToFront();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
